using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Mappings
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            ToTable("TAB_PRODUTO");
            HasKey(p => p.IdProduto);
            Property(p => p.IdProduto).HasColumnName("CODIGO_PRODUTO");
            Property(p => p.RefProduto).HasColumnName("REFERENCIA_PRODUTO");
            Property(p => p.NomeProduto).HasColumnName("NOME_PRODUTO");
            Property(p => p.Descricao);
            Property(p => p.Fabricante);
            Property(p => p.ValorProduto).HasColumnName("VALOR_PRODUTO");

        }
    }
}