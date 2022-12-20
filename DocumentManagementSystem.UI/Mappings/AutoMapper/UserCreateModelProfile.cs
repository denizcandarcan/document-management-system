using AutoMapper;
using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.UI.Models;

namespace DocumentManagementSystem.UI.Mappings.AutoMapper
{
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>();
        }
    }
}
