using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;


namespace SecondFloorWebApp.Mappings
{
    public class AnuncianteConfiguration : EntityTypeConfiguration<Anunciante>
    {
        public AnuncianteConfiguration()
        {
            ToTable("TAB_ANUNCIANTE");
            HasKey(a => a.IdUsuario);
            Property(a => a.IdUsuario).HasColumnName("CODIGO_ANUNCIANTE");
            Property(a => a.Nome);
            Property(a => a.Sobrenome);
            Property(a => a.Email);
            Property(a => a.Cnpj).HasColumnName("CNPJ");
            Property(a => a.RazaoSocial).HasColumnName("RAZAO_SOCIAL");
            Property(a => a.TipoUsuario).HasColumnName("TIPO_USUARIO");
           
            HasMany(a => a.Enderecos).WithRequired(a => a.Vendedor)
                .Map(x => x.MapKey("AnuncianteId").ToTable("TAB_ENDERECO"));

            HasMany(a => a.Produtos).WithRequired(a => a.Anunciante)
                .Map(x => x.MapKey("AnuncianteId").ToTable("TAB_PRODUTO"));

        }
    }
}