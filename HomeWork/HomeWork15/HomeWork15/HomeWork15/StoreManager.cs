using HomeWork15.Data;
using Microsoft.EntityFrameworkCore;
using HomeWork15.Data;

using HomeWork15.Entities;
using System.Diagnostics.Metrics;

namespace HomeWork15
{

    internal class StoreManager
    {
        private readonly StoreDbContext context;
        public StoreManager(StoreDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Shops>> GetShops()
        {
            return await context.Shops.ToListAsync();
        }


        public async Task<IEnumerable<Workers>> GetWorkers()
        {
            return await context.Workers.ToListAsync();

        }
        public async Task<IEnumerable<Products>> GetProducts()
        {
            return await context.Products.ToListAsync();

        }

  





    }
}
