using AutoMapper;
using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.UI.Models;

namespace DocumentManagementSystem.UI.Mappings.AutoMapper
{
    public class UserUpdateModelProfile : Profile
    {
        public UserUpdateModelProfile()
        {
            CreateMap<UserUpdateModel, AppUserUpdateDto>().ReverseMap();
        }
    }
}
