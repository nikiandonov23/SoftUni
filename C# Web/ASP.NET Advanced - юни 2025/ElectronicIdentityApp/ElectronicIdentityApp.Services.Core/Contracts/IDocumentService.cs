using ElectronicIdentityApp.ViewModels;

namespace ElectronicIdentityApp.Services.Core.Contracts;

public interface IDocumentService
{

    //Index GetAllModels
    public Task<IEnumerable<IndexDocumentViewModel>> GetAllDocumentsAsync(string? currentUserId);
}