using DocumentManagementSystem.Business.Interfaces;
using DocumentManagementSystem.UI.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DocumentManagementSystem.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDocumentService _documentService;

        public HomeController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _documentService.GetAllAsync();
            return this.ResponseView(response);
        }
    }
}
