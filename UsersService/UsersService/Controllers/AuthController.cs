using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsersService.Commands.Auth.ExternalLogin;

namespace UsersService.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    #region Properties

    private readonly IMediator _mediator;
    
    #endregion
    
    #region  Constructors

    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    #endregion

    #region Methods   

    /// <summary>
    /// Method for login in with a external provider.
    /// </summary>
    /// <param name="externalLoginCommand"></param>
    /// <returns>Data transfer object containing access token.</returns>
    public async Task<ActionResult<ExternalLoginDto>> ExternalLogin([FromBody] ExternalLoginCommand? externalLoginCommand)
    {
        if (externalLoginCommand == null)
        {
            return BadRequest();
        }
        
        return await _mediator.Send(externalLoginCommand);
    }
    
    #endregion
}   