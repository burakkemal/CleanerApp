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
    public class EfHospitalIsActiveDal : EfEntityRepositoryBase<HospitalIsActive, CleanerAppContext>, IHospitalIsActiveDal
    {
        public EfHospitalIsActiveDal(CleanerAppContext context) : base(context)
        {

        }
    }
}
