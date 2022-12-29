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
using DocumentManagementSystem.Dtos.Interfaces;
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

        public async Task<IActionResult> Index([FromQuery] string search, [FromQuery] string searchopt, [FromQuery] string sortOption)
        {
            if (String.IsNullOrEmpty(search))
            {
                if (sortOption == "title")
                {
                    var docs = _context.Documents.OrderBy(x => x.Title);
                    var dtos = new List<DocumentListDto>();
                    foreach (var doc in docs)
                    {
                        var dto = _mapper.Map<DocumentListDto>(doc);
                        dtos.Add(dto);
                    }
                    return View("Index", dtos);
                }
                else if (sortOption == "type")
                {
                    var docs = _context.Documents.OrderBy(x => x.TypeOfDoc);
                    var dtos = new List<DocumentListDto>();
                    foreach (var doc in docs)
                    {
                        var dto = _mapper.Map<DocumentListDto>(doc);
                        dtos.Add(dto);
                    }
                    return View("Index", dtos);
                }
                else if (sortOption == "status")
                {
                    var docs = _context.Documents.OrderBy(x => x.DocStatus);
                    var dtos = new List<DocumentListDto>();
                    foreach (var doc in docs)
                    {
                        var dto = _mapper.Map<DocumentListDto>(doc);
                        dtos.Add(dto);
                    }
                    return View("Index", dtos);
                }
                else if (sortOption == "state")
                {
                    var docs = _context.Documents.OrderBy(x => x.DocState);
                    var dtos = new List<DocumentListDto>();
                    foreach (var doc in docs)
                    {
                        var dto = _mapper.Map<DocumentListDto>(doc);
                        dtos.Add(dto);
                    }
                    return View("Index", dtos);
                }
                else
                {
                    var docs = await _context.Documents.ToListAsync();
                    var response = await _documentService.GetAllAsync();
                    return this.ResponseView(response);
                }
            }
            else
            {
                int selectedOpt = int.Parse(searchopt);
                var docs = await _context.Documents.Where(x => x.Title.Contains(search)).ToListAsync();

                switch (selectedOpt)
                {
                    default:
                        docs = await _context.Documents.Where(x => x.Title.Contains(search)).ToListAsync();
                        if (sortOption == "title")
                        {
                            docs = docs.OrderBy(x=>x.Title).ToList();
                        }
                        else if (sortOption == "type")
                        {
                            docs = docs.OrderBy(x => x.TypeOfDoc).ToList();
                        }
                        else if (sortOption == "status")
                        {
                            docs = docs.OrderBy(x => x.DocStatus).ToList();
                        }
                        else if (sortOption == "state")
                        {
                            docs = docs.OrderBy(x => x.DocState).ToList();
                        }
                        break;
                    case 1:
                        docs = await _context.Documents.Where(x => x.SenderName.Contains(search)).ToListAsync();
                        break;
                    case 2:
                        docs = await _context.Documents.Where(x => x.ReceiverName.Contains(search)).ToListAsync();
                        break;
                    case 3:
                        docs = await _context.Documents.Where(x => x.TypeOfDoc.Contains(search)).ToListAsync();
                        break;
                    case 4:
                        docs = await _context.Documents.Where(x => x.ClassOfDoc.Contains(search)).ToListAsync();
                        break;
                }
                var dtos = new List<DocumentListDto>();
                foreach (var doc in docs)
                {
                    var dto = _mapper.Map<DocumentListDto>(doc);
                    dtos.Add(dto);
                }
                var response = await _documentService.GetAllAsync();
                return View("Index",dtos);
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
                dto.ReceiveDate = DateTime.Now;
            }
            var response = await _documentService.UpdateAsync(dto);
            return this.ResponseRedirectAction(response, "Index");
        }

        public async Task<IActionResult> Detail(int id)
        {
            var response = await _documentService.GetByIdAsync<DocumentUpdateDto>(id);
            return this.ResponseView(response);
        }
    }
}
