using SecondFloorWebApp.Mappings;
using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.DataAccess
{
    public class SecondFloorContext : DbContext
    {
        public DbSet<Anunciante> Anunciantes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public SecondFloorContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Anunciante>().ToTable("TAB_USUARIO");
            modelBuilder.Configurations.Add(new AnuncianteConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new LoginConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());

        }
    }
}