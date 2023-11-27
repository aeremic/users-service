using AutoMapper;
using UsersService.Domain;
using UsersService.Queries.User.GetAllUsersData;
using UsersService.Queries.User.GetUserData;

namespace UsersService.Mappers;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDataDto>();
        CreateMap<User, UsersDataDto>();
    }
}