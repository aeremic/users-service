using MediatR;

namespace UsersService.Queries.User.GetUserData;

public class GetUserDataQuery : IRequest<UserDataDto>
{
    public long Id { get; set; }
}