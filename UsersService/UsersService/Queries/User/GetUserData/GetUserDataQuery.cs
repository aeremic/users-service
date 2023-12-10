using MediatR;
using UsersService.Common.Models;

namespace UsersService.Queries.User.GetUserData;

public class GetUserDataQuery : IRequest<UserDataDto>
{
    public long Id { get; set; }
}