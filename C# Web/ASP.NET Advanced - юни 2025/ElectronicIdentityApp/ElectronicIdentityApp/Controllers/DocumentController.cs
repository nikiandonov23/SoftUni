using ElectronicIdentityApp.Services.Core.Contracts;
using ElectronicIdentityApp.ViewModels.Document;
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
                DocumentType = await documentTypeService.GetAllDocumentTypesForCreateAsync(),
                Cities = await addressService.GetAllCitiesAsync()
                
                

            };

            return View(createModel);


        }





        [HttpPost]
        public async Task<IActionResult> Create(CreateDocumentViewModel inputModel)
        {
            var userId = GetUserId();

            if (!ModelState.IsValid || userId == null)
            {
                inputModel.Nationalities = await nationalityService.GetAllNationalitiesForCreateAsync();
                inputModel.DocumentType = await documentTypeService.GetAllDocumentTypesForCreateAsync();
                inputModel.Cities = await addressService.GetAllCitiesAsync();

                return View(inputModel);
            }

            var isItSuccess = await documentService.CreateDocumentAsync(userId, inputModel);
            if (isItSuccess)
            {
                return RedirectToAction(nameof(Index));
            }

            inputModel.Nationalities = await nationalityService.GetAllNationalitiesForCreateAsync();
            inputModel.DocumentType = await documentTypeService.GetAllDocumentTypesForCreateAsync();
            inputModel.Cities = await addressService.GetAllCitiesAsync();

            return View(inputModel);
        }
    }
}
