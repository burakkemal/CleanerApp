using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCleanerDal : EfEntityRepositoryBase<Cleaner, CleanerAppContext>, ICleanerDal
    {
        public EfCleanerDal(CleanerAppContext context) : base(context)
        {

        }
    }
}
