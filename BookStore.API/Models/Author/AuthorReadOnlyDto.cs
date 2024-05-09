using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models.Author;

public class AuthorReadOnlyDto : BaseDto
{
    [StringLength(50)]
    public required string FirstName { get; set; }
    [StringLength(50)]
    public required string LastName { get; set; }

    [StringLength(250)]
    public string? Bio { get; set; }
}