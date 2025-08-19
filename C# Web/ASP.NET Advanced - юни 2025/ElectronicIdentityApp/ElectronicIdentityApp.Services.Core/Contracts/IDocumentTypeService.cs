using ElectronicIdentityApp.ViewModels;

namespace ElectronicIdentityApp.Services.Core.Contracts;

public interface IDocumentTypeService
{
    Task<IEnumerable<CreateDocumentTypeDropDownViewModel>> GetAllDocumentTypesForCreateAsync();

}