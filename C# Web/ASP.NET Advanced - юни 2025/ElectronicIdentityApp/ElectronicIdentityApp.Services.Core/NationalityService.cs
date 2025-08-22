using ElectronicIdentityApp.Data;
using ElectronicIdentityApp.Services.Core.Contracts;
using ElectronicIdentityApp.ViewModels.Document.Dropdowns;
using Microsoft.EntityFrameworkCore;

namespace ElectronicIdentityApp.Services.Core;

public class NationalityService(ApplicationDbContext context):INationalityService
{
    public async Task<IEnumerable<CreateNationalityDocumentDropDownViewModel>> GetAllNationalitiesForCreateAsync()
    {
        var allNationalities = await context
            .Nationalities
            .Select(x => new CreateNationalityDocumentDropDownViewModel()
            {
                Id = x.Id,
                Name = x.Name,

            }).ToListAsync();

        return allNationalities;
    }
}