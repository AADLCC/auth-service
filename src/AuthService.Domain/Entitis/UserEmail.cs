using System.ComponentModel.DataAnnotations;
namespace AuthService.Domain.Entities

public class UserEmail
{
    [Key]
    [MaxLength(16)]
    public string Id { get; set; } = string.Empty;

    [Required]
    [MaxLength(16)]
    public string UserId { get; set; } = string.Empty;

    [Required]
    public bool EmailVerified { get; set; } = false;

    [MaxLength(256)]
    public string EmailVerifiedToken { get; set; }

    public DateTime? EmailVerifiedTokenExpiry { get; set; }

    public User User { get; set; } = null!;
}