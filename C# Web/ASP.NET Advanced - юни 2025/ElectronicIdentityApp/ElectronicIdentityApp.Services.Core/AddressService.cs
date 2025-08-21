using ElectronicIdentityApp.Data;
using ElectronicIdentityApp.DataModels;
using ElectronicIdentityApp.Services.Core.Contracts;
using ElectronicIdentityApp.ViewModels.Address;
using ElectronicIdentityApp.ViewModels.Address.Dropdowns;
using ElectronicIdentityApp.ViewModels.Document;
using Microsoft.EntityFrameworkCore;

namespace ElectronicIdentityApp.Services.Core;

public class AddressService(ApplicationDbContext context) : IAddressService
{
    public async Task<IEnumerable<CreateDocumentAddressDropDownViewModel>> GetAllAddressesForCreateAsync()
    {
        var allAddresses = await context
            .Addresses
            .Select(x => new CreateDocumentAddressDropDownViewModel()
            {
                Id = x.Id,
                Name = x.City + " " + x.Street + " " + x.HouseNumber,
            }).ToListAsync();


        return allAddresses;
    }

    public async Task<IEnumerable<IndexAddressViewModel>> GetAllAddressesAsync(string? currentUserId)
    {
        var addressHistory = await context
            .UsersAddresses
            .Where(x => x.UserId == currentUserId)
            .Select(x => new IndexAddressViewModel()
            {
                City = x.Address.City,
                Street = x.Address.Street,
                HouseNumber = x.Address.HouseNumber,
                BuildingType = x.Address.BuildingType,
                HouseName = x.Address.HouseName,
                PostalCode = x.Address.PostalCode,
                IsCurrent = x.IsCurrent,
                MovedIn = x.MovedIn,
                MovedOut = x.MovedOut


            }).ToListAsync();


        return addressHistory;
    }

    public async Task<IEnumerable<CitiesDropDownViewModel>> GetAllCitiesAsync()
    {
        var allCities = await context.Addresses
            .Select(x => new CitiesDropDownViewModel
            {
                Id = x.Id,
                Name = x.City
            })
            .GroupBy(x => x.Name)   // групира по име на града
            .Select(g => g.First()) // взима първия Id за всеки уникален град
            .ToListAsync();

        return allCities;
    }

    public async Task<IEnumerable<StreetsDropDownViewModel>> GetAllStreetsInCityAsync(string cityName)
    {


        if (string.IsNullOrEmpty(cityName))
        {
            return new List<StreetsDropDownViewModel>();
        }

      

        var allStreets = await context
            .Addresses
            .Where(x => x.City == cityName)
            .GroupBy(x => x.Street)           // групира по име на улицата
            .Select(x => new StreetsDropDownViewModel()
            {
                Id = x.First().Id,           // взимаме Id-то на първата улица
                Name = x.Key                 // името на улицата

            })
           
            .ToListAsync();

        return allStreets;
    }

    public async Task<IEnumerable<HouseNumbersDropDownViewModel>> GetAllNumbersInStreetAsync(string streetName, string cityName)
    {
        if (string.IsNullOrEmpty(streetName) || string.IsNullOrEmpty(cityName))
        {
            return new List<HouseNumbersDropDownViewModel>();
        }

        var allNumbers = await context
            .Addresses
            .Where(x => x.Street == streetName && x.City==cityName)
            .GroupBy(x => x.HouseNumber)
            .Select(x => new HouseNumbersDropDownViewModel()
            {
                Id = x.First().Id,
                Name = x.Key

            }).ToListAsync();
        return allNumbers;

    }

    public async Task<IEnumerable<HouseNameDropDownViewModel>> GetAllHouseNamesAsync(string cityName, string streetName, string streetNumber)
    {
        if (string.IsNullOrEmpty(cityName) || string.IsNullOrEmpty(streetName) || string.IsNullOrEmpty(streetNumber))
        {
            return new List<HouseNameDropDownViewModel>();
        }

        var houseNames = await context.Addresses
            .Where(x => x.City == cityName && x.Street == streetName && x.HouseNumber == streetNumber)
            .GroupBy(x => x.HouseName)
            .Select(g => new HouseNameDropDownViewModel
            {
                Id = g.First().Id,
                Name = string.IsNullOrEmpty(g.Key) ? "N/A" : g.Key
            })
            .ToListAsync();

        return houseNames;
    }

    public async Task<IEnumerable<PostCodeDropDownViewModel>> GetAllPostcodesInCityStreetNumberAsync(string cityName, string streetName,string streetNumber)
    {
        if (string.IsNullOrEmpty(cityName) || string.IsNullOrEmpty(streetName) || string.IsNullOrEmpty(streetNumber))
        {
            return new List<PostCodeDropDownViewModel>();
        }

        var postcodes = await context.Addresses
            .Where(x => x.City == cityName && x.Street == streetName && x.HouseNumber == streetNumber)
            .GroupBy(x => x.PostalCode)
            .Select(g => new PostCodeDropDownViewModel
            {
                Id = g.First().Id,
                Name = g.Key 
            })
            .ToListAsync();

        return postcodes;
    }

    public async Task<bool> CreateAddressAsync(string userId, CreateAddressViewModel inputModel)
    {


        var cityName = await context.Addresses
            .Where(a => a.Id == inputModel.CityId)
            .Select(a => a.City)
            .FirstOrDefaultAsync();

        var streetName = await context.Addresses
            .Where(a => a.Id == inputModel.StreetId)
            .Select(a => a.Street)
            .FirstOrDefaultAsync();

        var houseNumber = await context.Addresses
            .Where(a => a.Id == inputModel.HouseNumberId)
            .Select(a => a.HouseNumber)
            .FirstOrDefaultAsync();

        var postCode = await context.Addresses
            .Where(a => a.Id == inputModel.PostCodeId)
            .Select(a => a.PostalCode)
            .FirstOrDefaultAsync();


        // Ако липсва нещо от задължителните му връщам фалс
        if (string.IsNullOrEmpty(cityName) || string.IsNullOrEmpty(streetName))
            return false;

    
        var address = await context.Addresses
            .FirstOrDefaultAsync(a =>
                a.City == cityName &&
                a.Street == streetName &&
                (houseNumber == null || a.HouseNumber == houseNumber) &&
                (postCode == null || a.PostalCode == postCode)
            );

        if (address == null)
        {
            
            return false;
        }

       
        var userAddress = new UserAddress()
        {
            UserId = userId,
            AddressId = address.Id,
            MovedIn = inputModel.MovedIn.Value,  
            MovedOut = inputModel.MovedOut, 
            IsCurrent = inputModel.IsCurrent
        };

        await context.AddAsync(userAddress);
        await context.SaveChangesAsync();

        return true;
    }
}