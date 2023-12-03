using UsersService.Models;

namespace UsersService.Services.Interfaces;

public interface IJwtHandler
{
    public string GenerateToken(User user);
}