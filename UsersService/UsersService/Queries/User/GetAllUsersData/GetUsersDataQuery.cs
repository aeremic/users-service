using MediatR;

namespace UsersService.Queries.User.GetAllUsersData;

public class GetUsersDataQuery : IRequest<List<UsersDataDto>>
{
}