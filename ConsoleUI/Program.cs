using Business.Abstract;
using Business.Concrete;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using DataAccess.Concrete.EntityFramework;

IProductService productService = new ProductManager(new EfProductDal());

foreach(var product in productService.GetAll())
{
    Console.WriteLine(product.Name);
}