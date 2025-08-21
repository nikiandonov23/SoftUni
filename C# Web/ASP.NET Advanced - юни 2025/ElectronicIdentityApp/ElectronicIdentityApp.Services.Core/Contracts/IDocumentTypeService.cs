using ElectronicIdentityApp.ViewModels.Document;

namespace ElectronicIdentityApp.Services.Core.Contracts;

public interface IDocumentTypeService
{
    Task<IEnumerable<CreateDocumentTypeDropDownViewModel>> GetAllDocumentTypesForCreateAsync();

}