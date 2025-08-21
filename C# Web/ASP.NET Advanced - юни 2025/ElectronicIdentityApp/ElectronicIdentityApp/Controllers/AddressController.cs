using ElectronicIdentityApp.Services.Core;
using ElectronicIdentityApp.Services.Core.Contracts;
using ElectronicIdentityApp.ViewModels.Address;
using ElectronicIdentityApp.ViewModels.Document;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicIdentityApp.Web.Controllers
{
    public class AddressController(IAddressService addressService) : BaseController
    {
        public async Task <IActionResult> Index()
        {
            var userId = GetUserId();
            if (userId==null)
            {
                return RedirectToAction("Index", "Home");
            }

            var allAddresses = await addressService.GetAllAddressesAsync(userId);
            return View(allAddresses);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var userId = GetUserId();
            if (userId==null)
            {
                return RedirectToAction("Index", "Home");
            }

            var createModel = new CreateAddressViewModel()
            {
                Cities = await addressService.GetAllCitiesAsync()
            };

            return View(createModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetStreetsByCity(string cityName)
        {
            var streets = await addressService.GetAllStreetsInCityAsync(cityName);
            return Json(streets);
        }




        // AJAX: Get House Numbers by Street and City
        [HttpGet]
        public async Task<IActionResult> GetHouseNumbersByStreet(string cityName, string streetName)
        {
            var numbers = await addressService.GetAllNumbersInStreetAsync(streetName, cityName);
            return Json(numbers);
        }


        // AJAX: Get HouseNames by City Street Number

        [HttpGet]
        public async Task<IActionResult> GetHouseNames(string cityName, string streetName, string streetNumber)
        {
            var result = await addressService.GetAllHouseNamesAsync(cityName, streetName, streetNumber);
            return Json(result);
        }


        // AJAX: Get Postcodes by City
        [HttpGet]
        public async Task<IActionResult> GetPostCodesByCity(string cityName, string streetName,string streetNumber)
        {
            var postcodes = await addressService.GetAllPostcodesInCityStreetNumberAsync(cityName,streetName,streetNumber);
            return Json(postcodes);
        }




        [HttpPost]
        public async Task<IActionResult> Create(CreateAddressViewModel inputModel)
        {
            var userId = GetUserId();

            if (!ModelState.IsValid || userId==null)
            {

                return View(inputModel);
            }

            var isItSuccess = await addressService.CreateAddressAsync(userId, inputModel);
            if (isItSuccess)
            {
                return RedirectToAction(nameof(Index));
            }


            return View(inputModel);
        }
    }
}
