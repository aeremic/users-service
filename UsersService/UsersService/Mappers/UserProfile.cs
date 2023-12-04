using AutoMapper;
using UsersService.Models;
using UsersService.Queries.User.GetAllUsersData;
using UsersService.Queries.User.GetUserData;

namespace UsersService.Mappers;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDataDto>();
    }
}