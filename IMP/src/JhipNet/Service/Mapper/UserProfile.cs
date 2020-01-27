using AutoMapper;
using com.imp.net.Models;
using com.imp.net.Service.Dto;

namespace com.imp.net.Service.Mapper {
    public class UserProfile : Profile {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
