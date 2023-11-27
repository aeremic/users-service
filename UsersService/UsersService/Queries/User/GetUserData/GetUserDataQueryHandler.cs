using MediatR;

namespace UsersService.Queries.User.GetUserData;

public class GetUserDataQueryHandler : IRequestHandler<GetUserDataQuery, UserDataDto>
{
    public Task<UserDataDto> Handle(GetUserDataQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}