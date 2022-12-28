using AutoMapper;
using DocumentManagementSystem.Business.Interfaces;
using DocumentManagementSystem.Business.Services;
using DocumentManagementSystem.Business.ValidationRules;
using DocumentManagementSystem.Common;
using DocumentManagementSystem.Common.Enums;
using DocumentManagementSystem.DataAccess.Contexts;
using DocumentManagementSystem.DataAccess.Interfaces;
using DocumentManagementSystem.DataAccess.UnitOfWork;
using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.Entities;
using DocumentManagementSystem.UI.Extensions;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentManagementSystem.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IDocumentService _documentService;
        private readonly IValidator<DocumentCreateDto> _documentCreateValidator;
        private readonly DocumentContext _context;
        private readonly IMapper _mapper;

        public HomeController(IDocumentService documentService, IValidator<DocumentCreateDto> documentCreateValidator, DocumentContext context, IMapper mapper)
        {
            _documentService = documentService;
            _documentCreateValidator = documentCreateValidator;
            _context = context;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index([FromQuery] string search)
        {
            if (String.IsNullOrEmpty(search)){
                var docs = await _context.Documents.ToListAsync();

                var response = await _documentService.GetAllAsync();
                return this.ResponseView(response);
            }
            else
            {
                var docs = await _context.Documents.Where(x=>x.Title.Contains(search)).ToListAsync();
                var dtos = new List<DocumentListDto>();
                foreach (var doc in docs)
                {
                   var dto = _mapper.Map<DocumentListDto>(doc);
                    dtos.Add(dto);
                }
                var response = await _documentService.GetAllAsync();
                return View(dtos);
            }
        }

        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _documentService.RemoveAsync(id);
            if (result.ResponseType == Common.ResponseType.Success)
            {
                return this.ResponseRedirectAction(result, "Index");
            }
            else
            {
                return View("Index");
            }
        }
        [Authorize(Roles = "Admin,Moderator")]
        public IActionResult Create()
        {
            var model = new DocumentCreateDto() { };
            return View("Create");
        }
        [Authorize(Roles = "Admin,Moderator")]
        [HttpPost]
        public async Task<IActionResult> Create(DocumentCreateDto model)
        {
            var result = _documentCreateValidator.Validate(model);
            if (result.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                model.AppUserId = int.Parse(userId);
                var createResponse = await _documentService.CreateAsync(model);
                return this.ResponseRedirectAction(createResponse, "Index");

            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return View(model);
        }

        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> Edit(int id)
        {
            var response = await _documentService.GetByIdAsync<DocumentUpdateDto>(id);
            return this.ResponseView(response);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> Edit(DocumentUpdateDto dto)
        {
            if (dto.DocStatus == DocStatus.Delivered)
            {
                dto.ReceiveDate= DateTime.Now;
            }
            var response = await _documentService.UpdateAsync(dto);
            return this.ResponseRedirectAction(response, "Index");
        }

    }
}
