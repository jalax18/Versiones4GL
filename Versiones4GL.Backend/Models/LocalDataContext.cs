
namespace Versiones4GL.Backend.Models
{
    using Domain.Models;
    public class LocalDataContext: DataContext
    {
        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.Macserver> UserTypes { get; set; }

     
    }
}