using MediatR;

namespace UsersService.Commands.Auth.ExternalLogin;

public class ExternalLoginCommand : IRequest<ExternalLoginDto>
{
    public string? IdToken { get; set; }
    public string? Email { get; set; }
    public string? Provider { get; set; }
}