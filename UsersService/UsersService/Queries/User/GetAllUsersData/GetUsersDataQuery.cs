using MediatR;
using UsersService.Common.Models;
using UsersService.Queries.User.GetUserData;

namespace UsersService.Queries.User.GetAllUsersData;

public class GetUsersDataQuery : IRequest<List<UserDataDto>>
{
}