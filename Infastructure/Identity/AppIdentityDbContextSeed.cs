using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "MG",
                    Email = "g.mezei87@gmail.com",
                    UserName = "mezeigabor",
                    Address = new Address
                    {
                        FirstName = "Mezei",
                        LastName = "Gábor",
                        Street = "Szegedi út 4.",
                        City = "Budapest",
                        State = "Pest",
                        Zipcode = "1139"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}