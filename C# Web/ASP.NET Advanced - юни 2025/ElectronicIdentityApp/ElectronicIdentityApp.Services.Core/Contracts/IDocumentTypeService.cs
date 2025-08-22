using ElectronicIdentityApp.ViewModels.Document.Dropdowns;

namespace ElectronicIdentityApp.Services.Core.Contracts;

public interface IDocumentTypeService
{
    Task<IEnumerable<CreateDocumentTypeDropDownViewModel>> GetAllDocumentTypesForCreateAsync();

}