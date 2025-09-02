using API.DTO;
using API.Interfaces;
using API.Models;

namespace API.Extensions
{
    public static class AppUserExtensions
    {
        public static UserDto ToDto(this AppUser user, ITokenService tokenService)
        {
            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                DisplayName = user.DisplayName,
                ImageUrl = user.ImageUrl,
                Token = tokenService.CreateToken(user),
            };
        }
    }
}