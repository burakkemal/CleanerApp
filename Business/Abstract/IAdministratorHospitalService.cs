using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdministratorHospitalService
    {
        IDataResult<List<AdministratorHospital>> GetAll();

        IResult Add(AdministratorHospital administratorHospital);

        IResult Update(AdministratorHospital administratorHospital);
    }
}
