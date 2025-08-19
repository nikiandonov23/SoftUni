using ElectronicIdentityApp.Services.Core;
using ElectronicIdentityApp.Services.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicIdentityApp.Web.Controllers
{
    public class DocumentController(IDocumentService documentService) : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var userId = GetUserId();


            var allDocuments=await documentService.GetAllDocumentsAsync(userId);
            return View(allDocuments);
        }
    }
}
