using Business.Abstract;
using Core.Aspects.Logging;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        

        public ProductManager(IProductDal productDal)
        {
            
            _productDal = productDal;
        }

        [LogAspect]
        public List<Product> GetAll()
        {
            
            return _productDal.GetAll();
        }
    }
}
