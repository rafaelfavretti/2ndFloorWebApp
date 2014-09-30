using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Mappings
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            ToTable("TAB_USUARIO");
            HasKey(u => u.IdUsuario);
            Property(u => u.IdUsuario).HasColumnName("CODIGO_USUARIO");
            Property(u => u.Nome);
            Property(u => u.Sobrenome);
            Property(u => u.Email);
            Property(u => u.TipoUsuario);
        }
    }
}