using ElectronicIdentityApp.ViewModels.Document;

namespace ElectronicIdentityApp.Services.Core.Contracts;

public interface IDocumentService
{

    //Index GetAllModels
    public Task<IEnumerable<IndexDocumentViewModel>> GetAllDocumentsAsync(string? currentUserId);


    //Create /Add ;
    //Използвам сървисите от IAddressService за дропдауните при Create ,вместо да ги пиша пак
    public Task<bool> CreateDocumentAsync(string userId, CreateDocumentViewModel inputModel);

}