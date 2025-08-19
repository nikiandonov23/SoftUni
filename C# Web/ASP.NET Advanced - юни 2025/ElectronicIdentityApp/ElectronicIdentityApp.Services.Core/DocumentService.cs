using ElectronicIdentityApp.Data;
using ElectronicIdentityApp.DataModels;
using ElectronicIdentityApp.Services.Core.Contracts;
using ElectronicIdentityApp.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace ElectronicIdentityApp.Services.Core;

public class DocumentService(ApplicationDbContext documentService, IWebHostEnvironment env) : IDocumentService
{

    public async Task<IEnumerable<IndexDocumentViewModel>> GetAllDocumentsAsync(string? currentUserId)
    {


        var allDocuments = await documentService
            .Documents
            .Where(x => x.OwnerId == currentUserId)
            .Select(x => new IndexDocumentViewModel()
            {
                Address = x.Address.City + " " + x.Address.Street + " " + x.Address.HouseNumber,
                DocumentNumber = x.DocumentNumber,
                ExpiredOn = x.ExpiredOn,
                FirstName = x.FirstName,
                LastName = x.LastName,
                MiddleName = x.MiddleName,
                Id = x.Id,
                IssuedOn = x.IssuedOn,
                IsValid = x.ExpiredOn > DateTime.UtcNow,
                Nationality = x.Nationality.Name,
                ImageUrl = x.ImageUrl

            }).ToListAsync();

        return allDocuments;
    }

    public async Task<bool> CreateDocumentAsync(string userId, CreateDocumentViewModel inputModel)
    {






        bool isUserIdValid = await documentService.Users
            .AnyAsync(x => x.Id == userId);
        if (!isUserIdValid)
        {
            return false;
        }


        //Логика за добавяне на изображение
        string? imagePath = null;

        if (inputModel.DocumentImage != null)
        {
            var uploadsFolder = Path.Combine(env.WebRootPath, "uploads");
            Directory.CreateDirectory(uploadsFolder);

            var uniqueFileName = Guid.NewGuid() + Path.GetExtension(inputModel.DocumentImage.FileName);
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await inputModel.DocumentImage.CopyToAsync(stream);
            }

            imagePath = "uploads/" + uniqueFileName;
        }


        var documentToBeCreated = new Document()
        {
            AddressId = inputModel.AddressId,
            NationalityId = inputModel.NationalityId,
            BirthOn = inputModel.BirthOn,
            ExpiredOn = inputModel.ExpiredOn,
            IssuedOn = inputModel.IssuedOn,
            DocumentNumber = inputModel.DocumentNumber,
            FirstName = inputModel.FirstName,
            MiddleName = inputModel.MiddleName,
            LastName = inputModel.LastName,
            OwnerId = userId,
            IsValid = true,
            ImageUrl = imagePath

        };
        await documentService.AddAsync(documentToBeCreated);
        await documentService.SaveChangesAsync();
        return true;
    }
}