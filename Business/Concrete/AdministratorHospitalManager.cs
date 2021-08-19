using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdministratorHospitalManager : IAdministratorHospitalService
    {
        IAdministratorHospitalDal _administratorHospitalDal;

        public AdministratorHospitalManager(IAdministratorHospitalDal administratorHospitalDal)
        {
            _administratorHospitalDal = administratorHospitalDal;
        }

        public IResult Add(AdministratorHospital administratorHospital)
        {
            _administratorHospitalDal.Add(administratorHospital);
            return new SuccessResult();
        }

        public IDataResult<List<AdministratorHospital>> GetAll()
        {
            return new SuccessDataResult<List<AdministratorHospital>>(_administratorHospitalDal.GetAll());
        }

        public IResult Update(AdministratorHospital administratorHospital)
        {
            _administratorHospitalDal.Update(administratorHospital);
            return new SuccessResult("Güncellendi");
        }
    }
}
