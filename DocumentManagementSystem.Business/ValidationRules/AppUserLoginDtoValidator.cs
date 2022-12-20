﻿using DocumentManagementSystem.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.ValidationRules
{
    public class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(x=>x.Username).NotEmpty().WithMessage("Username couldnt'be empty.");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Password couldnt'be empty.");
        }
    }
}
