using AutoMapper;
using ttdemo.Models;
using ttdemo.Service.Dto;

namespace ttdemo.Service.Mapper {
    public class UserProfile : Profile {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
