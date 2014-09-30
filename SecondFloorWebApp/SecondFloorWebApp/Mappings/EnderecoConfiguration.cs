using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Mappings
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            ToTable("TAB_ENDERECO");
            HasKey(e => e.IdEndereco);
            Property(e => e.IdEndereco).HasColumnName("CODIGO_ENDERECO");
            Property(e => e.TipoEndereco).HasColumnName("TIPO_ENDERECO");
            Property(e => e.Logradouro);
            Property(e => e.Numero);
            Property(e => e.Complemento);
            Property(e => e.Bairro);
            Property(e => e.Cidade);
            Property(e => e.Estado);
                        
        }
    }
}