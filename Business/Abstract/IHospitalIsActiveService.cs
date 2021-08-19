using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHospitalIsActiveService
    {
        IDataResult<List<HospitalIsActive>> GetAll();
        IResult Add(HospitalIsActive hospitalIsActive);
        IResult Update(HospitalIsActive hospitalIsActive);
    }
}
