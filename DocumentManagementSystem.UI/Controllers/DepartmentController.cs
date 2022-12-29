using DocumentManagementSystem.Business.Interfaces;
using DocumentManagementSystem.Business.Services;
using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.UI.Extensions;
using DocumentManagementSystem.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace DocumentManagementSystem.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DepartmentController : Controller
    {
        private readonly IDeparmentService _departmentService;

        public DepartmentController(IDeparmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index()
        {
            var departments = await _departmentService.GetAllAsync();
            return this.ResponseView(departments);
        }
        public async Task<IActionResult> Update(int id)
        {
            var response = await _departmentService.GetByIdAsync<DepartmentUpdateDto>(id);
            return this.ResponseView(response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(DepartmentUpdateDto dto)
        {
            var response = await _departmentService.UpdateAsync(dto);
            return this.ResponseRedirectAction(response,"Index");
        }
        public IActionResult Create()
        {
            var model = new DepartmentCreateDto() { };
            return View("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentCreateDto dto)
        {
            if(dto.Definition == null)
            {
                return View("Create");
            }
            else
            {
                var createResponse = await _departmentService.CreateAsync(dto);
                return this.ResponseRedirectAction(createResponse, "Index");
            }
        }
    }
}
