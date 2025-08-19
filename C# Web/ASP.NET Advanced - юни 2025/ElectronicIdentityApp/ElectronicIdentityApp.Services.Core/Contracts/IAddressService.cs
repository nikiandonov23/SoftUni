using ElectronicIdentityApp.ViewModels;

namespace ElectronicIdentityApp.Services.Core.Contracts;

public interface IAddressService
{
    Task<IEnumerable<CreateDocumentAddressDropDownViewModel>> GetAllAddressesForCreateAsync();
}