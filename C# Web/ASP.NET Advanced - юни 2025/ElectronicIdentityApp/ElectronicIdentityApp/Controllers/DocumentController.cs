using ElectronicIdentityApp.Services.Core;
using ElectronicIdentityApp.Services.Core.Contracts;
using ElectronicIdentityApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;




namespace ElectronicIdentityApp.Web.Controllers
{
    public class DocumentController
        (
            IDocumentService documentService,
            INationalityService nationalityService,
            IAddressService addressService,
            IDocumentTypeService documentTypeService
            )
        : BaseController
    {

        public async Task<IActionResult> Index()
        {
            var userId = GetUserId();


            var allDocuments = await documentService.GetAllDocumentsAsync(userId);
            return View(allDocuments);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var userId = GetUserId();

            var createModel = new CreateDocumentViewModel()
            {
                Nationalities = await nationalityService.GetAllNationalitiesForCreateAsync(),
                Addresses = await addressService.GetAllAddressesForCreateAsync(),
                DocumentType = await documentTypeService.GetAllDocumentTypesForCreateAsync()
                

            };

            return View(createModel);


        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDocumentViewModel inputModel)
        {
            var userId = GetUserId();

            if (!ModelState.IsValid)
            {

                inputModel.Addresses = await addressService.GetAllAddressesForCreateAsync();
                inputModel.Nationalities = await nationalityService.GetAllNationalitiesForCreateAsync();
                return View(inputModel);
            }

            var isItSuccess = await documentService.CreateDocumentAsync(userId, inputModel);
            if (isItSuccess)
            {
                return RedirectToAction(nameof(Index));
            }

            inputModel.Addresses = await addressService.GetAllAddressesForCreateAsync();
            inputModel.Nationalities = await nationalityService.GetAllNationalitiesForCreateAsync();
            return View(inputModel);
        }
    }
}
