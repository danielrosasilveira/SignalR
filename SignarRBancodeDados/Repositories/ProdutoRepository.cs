using Microsoft.EntityFrameworkCore;
using SignarRBancodeDados.Models;
using System.Data;

namespace SignarRBancodeDados.Repositories
{
    public class ProdutoRepository
    {
        private readonly SignarRBancodeDados.Context.AppContext _context;
        
        public ProdutoRepository(Context.AppContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> GetProductDetailsFromDb()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return produtos;
        }
    }
}
