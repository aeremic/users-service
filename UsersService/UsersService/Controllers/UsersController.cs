﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UsersService.Common.Models;
using UsersService.Queries.User.GetAllUsersData;
using UsersService.Queries.User.GetUserData;

namespace UsersService.Controllers;

[Route("api/[controller]")]
[Authorize]
[ApiController]
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

    /// <summary>
    /// Method for retrieving users data.
    /// </summary>
    /// <returns>Users data as a list.</returns>
    [HttpGet("[action]")]
    public async Task<ActionResult<List<UserDataDto>>> GetUsersData()
    {
        return await _mediator.Send(new GetUsersDataQuery());
    }

    #endregion
}