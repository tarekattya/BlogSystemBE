
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence.Emtities;

public class ApplicationRole : IdentityRole
{
    public bool IsDefault { get; set; }
    public bool IsDeleted { get; set; }
}
