using System.Data.Entity;
using Practicing_Programmer.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Practicing_Programmer.DAL
{
    public class PracticingProgrammerDbContext : IdentityDbContext
    {
        public PracticingProgrammerDbContext()
            : base("DefaultConnection")
        {
        }

        public static PracticingProgrammerDbContext Create()
        {
            return new PracticingProgrammerDbContext();
        }

        public DbSet<Kata> Katas { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}