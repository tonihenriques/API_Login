using API_Treinamento_Auth.Entidades;
using Microsoft.EntityFrameworkCore;


namespace API_Treinamento_Auth.Context
{
    public class LoginContext : DbContext
    {

        public LoginContext() { }
        public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }
    }
}
