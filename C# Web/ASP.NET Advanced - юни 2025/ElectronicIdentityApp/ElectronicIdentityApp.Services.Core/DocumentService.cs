using ElectronicIdentityApp.Data;
using ElectronicIdentityApp.Services.Core.Contracts;
using ElectronicIdentityApp.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ElectronicIdentityApp.Services.Core;

public class DocumentService(ApplicationDbContext documentService):IDocumentService
{
    public async Task<IEnumerable<IndexDocumentViewModel>> GetAllDocumentsAsync(string? currentUserId)
    {
        

        var allDocuments=await documentService
            .Documents
            .Where(x=>x.OwnerId==currentUserId )
            .Select(x=>new IndexDocumentViewModel()
            {
                Address = x.Address.City+" "+ x.Address.Street+" "+x.Address.HouseNumber,
                DocumentNumber = x.DocumentNumber,
                ExpiredOn = x.ExpiredOn,
                FirstName = x.FirstName,
                LastName = x.LastName,
                MiddleName = x.MiddleName,
                Id = x.Id,
                IssuedOn = x.IssuedOn,
                IsValid = x.ExpiredOn > DateTime.UtcNow,   
                Nationality = x.Nationality.Name,

            }).ToListAsync();

        return allDocuments;
    }
}