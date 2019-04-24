﻿
namespace Versiones4GL.Backend.Models
{
    using Domain.Models;
    public class LocalDataContext: DataContext
    {
        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<Versiones4GL.Common.Models.UserType> UserTypes { get; set; }

        public System.Data.Entity.DbSet<Xad> Xads { get; set; }
    }
}