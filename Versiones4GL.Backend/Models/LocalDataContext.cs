
namespace Versiones4GL.Backend.Models
{
    using Domain.Models;
    public class LocalDataContext: DataContext
    {
        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.Macserver> UserTypes { get; set; }

        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.Xad> Xads { get; set; }

        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.Maccliente> Macclientes { get; set; }

        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.Mpecliente> Mpeclientes { get; set; }

        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.Garum> Garums { get; set; }
    }
}