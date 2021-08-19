using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfObjectDal : EfEntityRepositoryBase<Entities.Concrete.Object, CleanerAppContext>, IObjectDal
    {
        public EfObjectDal(CleanerAppContext context) : base(context)
        {

        }
    }
}
