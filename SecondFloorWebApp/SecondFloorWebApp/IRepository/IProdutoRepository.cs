using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFloorWebApp.IRepository
{
    public interface IProdutoRepository : IRepository<Produto,int>
    {
        Produto FindByName(string nomeProduto);
        Produto FindByRef(string codigoProduto);
        ICollection<Produto> ListarProdutos(int codigoAnunciante);
    }
}
