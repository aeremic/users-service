using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UsersService.Infrastructure;

namespace UsersService.Queries.User.GetAllUsersData;

public class GetUsersDataQueryHandler : IRequestHandler<GetUsersDataQuery, List<UsersDataDto>>
{
    #region Properties

    private readonly Repository _repository;
    private readonly IMapper _mapper;

    #endregion

    #region Constructors

    public GetUsersDataQueryHandler(Repository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    #endregion

    #region Methods

    public async Task<List<UsersDataDto>> Handle(GetUsersDataQuery request, CancellationToken cancellationToken)
    {
        var users = await _repository.Users.ToListAsync(cancellationToken);

        return _mapper.Map<List<Domain.User>, List<UsersDataDto>>(users);
    }

    #endregion
}