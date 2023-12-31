namespace UMS.Authentication.Application.Dtos.AuthDtos;

public class AuthLoginDto
{
    /// <example>ObiWanKenobi</example>
    public required string Username { get; set; }

    /// <example>TheNegotiator</example>
    public required string Password { get; set; }
}