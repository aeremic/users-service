using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsersService.Queries.User.GetUserData;

namespace UsersService.Controllers;

public class UsersController : ControllerBase
{
    #region Properties

    private readonly IMediator _mediator;

    #endregion

    #region Constructors

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    #endregion

    #region Methods
    
    /// <summary>
    /// Method for retrieving user data. 
    /// </summary>
    /// <param name="id"></param>
    /// <returns>User data.</returns>
    [HttpGet("[action]/{id}")]
    public async Task<ActionResult<UserDataDto>> GetUserData(long id)
    {
        return await _mediator.Send(new GetUserDataQuery { Id = id });
    }

    #endregion
}