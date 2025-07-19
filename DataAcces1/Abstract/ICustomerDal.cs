using Core.DataAcces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Persistence.Repositories;

namespace DataAcces1.Abstract
{
    public interface ICustomerDal: IEntityRepository<Customer>
    {
    }
}
//Code Refactoring