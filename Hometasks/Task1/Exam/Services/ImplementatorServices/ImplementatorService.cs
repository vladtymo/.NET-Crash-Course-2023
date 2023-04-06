using Exam.Common;
using Exam.Database.Enitites;
using Exam.Database.Enums;
using Exam.Services.CheckServices;
using Exam.Services.GoodsServices;
using Exam.Services.OpenAIServices;
using Exam.Services.ProductServices;
using Exam.Services.Response;
using Exam.Services.SupermarketServices;
using static Exam.Common.ImplementationValues;

namespace Exam.Services.ImplementatorServices
{
    public class ImplementatorService : IImplementatorService
    {
        private readonly ICheckService _checkService;
        private readonly IGoodsService _goodsService;
        private readonly IProductService _productService;
        private readonly ISupermarketService _supermarketService;
        private readonly IGPTService _gpt;

        public ImplementatorService(ICheckService checkService,
            IGoodsService goodsService,
            IProductService productService,
            ISupermarketService supermarketService,
            IGPTService gpt)
        {
            _checkService = checkService;
            _goodsService = goodsService;
            _productService = productService;
            _supermarketService = supermarketService;
            _gpt = gpt;
        }

        public Task<ResponseService<ICollection<CheckEntity>>> ImplementChecks(long supermarketId, bool append = false)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseService<ICollection<GoodsEntity>>> ImplementGoods(int count, long supermarketId, bool append = false)
        {
            Random random = new Random();
            string[] names = Enum.GetNames(typeof(GoodsName));
            string[] categories = Enum.GetNames(typeof(GoodsCategory));

            List<GoodsEntity> goods = new List<GoodsEntity>(count);

            for (int i = 0; i < count; i++)
            {
                GoodsEntity dbRecord = new GoodsEntity()
                {
                    Category = (GoodsCategory)(random.Next(1, categories.Length)),
                    Count = random.Next(0, 1000),
                    Name = names[random.Next(0, names.Length)],
                    Price = (float)(Math.Round(random.NextDouble() * 1000, 2)),
                    SupermarketFK = supermarketId,
                    CreatedOn = DateTime.Now,
                };

                var response = await _gpt.Request($"{Prompts.GENERATE_DESCRIPTION} {dbRecord.Name}");
                if (response.IsError)
                {
                    return ResponseService<ICollection<GoodsEntity>>.Error(response.ErrorMessage);
                }

                string description = response.Value.First().Trim('\n');
                dbRecord.Description = description;

                if (append)
                {
                    var createResult = await _goodsService.Create(dbRecord);
                    if (createResult.IsError)
                    {
                        return ResponseService<ICollection<GoodsEntity>>.Error(createResult.ErrorMessage);
                    }
                }

                goods.Add(dbRecord);
            }

            return ResponseService<ICollection<GoodsEntity>>.Ok(goods);
        }

        public async Task<ResponseService<ICollection<ProductEntity>>> ImplementProduct(int count, long supermarketId, bool append = false)
        {
            Random random = new Random();
            string[] names = Enum.GetNames(typeof(ProductName));
            string[] categories = Enum.GetNames(typeof(ProductCategory));

            List<ProductEntity> products = new List<ProductEntity>(count);

            for (int i = 0; i < count; i++)
            {
                ProductEntity dbRecord = new ProductEntity()
                {
                    Category = (ProductCategory)(random.Next(1, categories.Length)),
                    Count = random.Next(0, 1000),
                    Name = names[random.Next(0, names.Length)],
                    Price = (float)(Math.Round(random.NextDouble() * 1000, 2)),
                    SupermarketFK = supermarketId,
                    CreatedOn = DateTime.Now,
                };

                var response = await _gpt.Request($"{Prompts.GENERATE_DESCRIPTION} {dbRecord.Name}");
                if (response.IsError)
                {
                    return ResponseService<ICollection<ProductEntity>>.Error(response.ErrorMessage);
                }

                string description = response.Value.First().Trim('\n');
                dbRecord.Description = description;
                dbRecord.ExpirationDate = DateTime.Now.AddDays(random.Next(3, 90));

                if (append)
                {
                    var createResult = await _productService.Create(dbRecord);
                    if (createResult.IsError)
                    {
                        return ResponseService<ICollection<ProductEntity>>.Error(createResult.ErrorMessage);
                    }
                }

                products.Add(dbRecord);
            }

            return ResponseService<ICollection<ProductEntity>>.Ok(products);
        }

        public async Task<ResponseService<ICollection<SupermarketEntity>>> ImplementSupermarkets(int count, bool append = false)
        {
            Random random = new Random();
            string[] supermarketNames = Enum.GetNames(typeof(SupermarketName));
            List<SupermarketEntity> supermarkets = new List<SupermarketEntity>(count);

            for (int i = 0; i < count; i++)
            {
                supermarkets.Add(new SupermarketEntity()
                {
                    CreatedOn = DateTime.Now,
                    Name = supermarketNames[random.Next(0, supermarketNames.Length)],
                });

                if (append)
                {
                    var result = await _supermarketService.Create(supermarkets[i]);
                    if (result.IsError)
                    {
                        return ResponseService<ICollection<SupermarketEntity>>.Error(result.ErrorMessage);
                    }    
                }
            }

            return ResponseService<ICollection<SupermarketEntity>>.Ok(supermarkets);
        }
    }
}