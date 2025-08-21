using ElectronicIdentityApp.Data;
using ElectronicIdentityApp.Services.Core.Contracts;
using ElectronicIdentityApp.ViewModels.Document;
using Microsoft.EntityFrameworkCore;

namespace ElectronicIdentityApp.Services.Core;

public class DocumentTypeService(ApplicationDbContext context):IDocumentTypeService
{
    public async Task<IEnumerable<CreateDocumentTypeDropDownViewModel>> GetAllDocumentTypesForCreateAsync()
    {
        var allTypes = await context
            .DocumentTypes
            .Select(x => new CreateDocumentTypeDropDownViewModel()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();

        return allTypes;
    }
}