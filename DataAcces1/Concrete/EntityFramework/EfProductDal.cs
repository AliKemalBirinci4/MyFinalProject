using DataAcces1.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAcces.EntityFramework;

namespace DataAcces1.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>  , IProductDal
    {
        //Disposable pattern implementation of c#
       
    }
}
