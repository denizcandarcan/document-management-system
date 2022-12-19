using AutoMapper;
using DocumentManagementSystem.Business.Interfaces;
using DocumentManagementSystem.Business.Mappings.AutoMapper;
using DocumentManagementSystem.Business.Services;
using DocumentManagementSystem.Business.ValidationRules;
using DocumentManagementSystem.DataAccess.Contexts;
using DocumentManagementSystem.DataAccess.UnitOfWork;
using DocumentManagementSystem.Dtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DocumentContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });
            var mapperConfiguration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new DocumentProfile());
            });
            var mapper = mapperConfiguration.CreateMapper();

            services.AddSingleton(mapper);
            services.AddScoped<IUow, Uow>();

            services.AddTransient<IValidator<DocumentCreateDto>,DocumentCreateDtoValidator>();
            services.AddTransient<IValidator<DocumentUpdateDto>, DocumentUpdateDtoValidator>();

            services.AddScoped<IDocumentService, DocumentService>();
        }
    }
}
