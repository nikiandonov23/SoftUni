using ElectronicIdentityApp.ViewModels.Address;
using ElectronicIdentityApp.ViewModels.Address.Dropdowns;
using ElectronicIdentityApp.ViewModels.Document;

namespace ElectronicIdentityApp.Services.Core.Contracts;

public interface IAddressService
{

    //За  Document
    //Get Address dropdown for Create 
    Task<IEnumerable<CreateDocumentAddressDropDownViewModel>> GetAllAddressesForCreateAsync();

    //todo Get Address dropdown for Edit




    //За  Address
    //Index GetAllModels  
    public Task<IEnumerable<IndexAddressViewModel>> GetAllAddressesAsync(string? currentUserId);


    
    
    
    //GetAllHouseNames in the City/Street/StreetNumber

    //GetAll Cities
    Task<IEnumerable<CitiesDropDownViewModel>> GetAllCitiesAsync();
    //GetAll Streets in the City
    Task<IEnumerable<StreetsDropDownViewModel>> GetAllStreetsInCityAsync(string cityName);


    //GetAll Numbers in the Street
    Task<IEnumerable<HouseNumbersDropDownViewModel>> GetAllNumbersInStreetAsync(string streetName,string cityName);

    //GetAll Postcodes in the City
    Task<IEnumerable<PostCodeDropDownViewModel>> GetAllPostcodesInCityStreetNumberAsync(string cityName,string streetName,string streetNumber);



}