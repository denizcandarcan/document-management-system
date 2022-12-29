using AutoMapper;
using DocumentManagementSystem.Business.Interfaces;
using DocumentManagementSystem.Business.Services;
using DocumentManagementSystem.DataAccess.Contexts;
using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.UI.Extensions;
using DocumentManagementSystem.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagementSystem.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly DocumentContext _context;
        private readonly IMapper _mapper;
        private readonly IDeparmentService _departmentService;


        public UserController(IAppUserService appUserService, DocumentContext context, IMapper mapper, IDeparmentService departmentService)
        {
            _appUserService = appUserService;
            _context = context;
            _mapper = mapper;
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _appUserService.GetAllAsync();
            return this.ResponseView(users);
        }
        public async Task<IActionResult> Update(int id)
        {
            var user = _context.AppUsers.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                var userDto = _mapper.Map<AppUserUpdateDto>(user);
                var model = _mapper.Map<UserUpdateModel>(userDto);
                var response = await _departmentService.GetAllAsync();
                model.Departments = new SelectList(response.Data, "Id", "Definition");
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateModel model)
        {
            var dto = _mapper.Map<AppUserUpdateDto>(model);
            await _appUserService.UpdateAsync(dto);
            return RedirectToAction("Index");

        }
    }
}
