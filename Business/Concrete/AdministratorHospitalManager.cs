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
        IHospitalIsActiveService _hospitalIsActiveService;
        public AdministratorHospitalManager(IAdministratorHospitalDal administratorHospitalDal, IHospitalIsActiveService hospitalIsActiveService)
        {
            _administratorHospitalDal = administratorHospitalDal;
            _hospitalIsActiveService = hospitalIsActiveService;
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

        public IResult HospitalAdd(HospitalIsActive hospitalIsActive)
        {
            _hospitalIsActiveService.Add(hospitalIsActive);
            return new SuccessResult("eklendi");
        }

        public IResult HospitalUpdate(HospitalIsActive hospitalIsActive)
        {
            _hospitalIsActiveService.Update(hospitalIsActive);
            return new SuccessResult("Hastane Güncellendi");
        }

        public IResult Update(AdministratorHospital administratorHospital)
        {
            _administratorHospitalDal.Update(administratorHospital);
            return new SuccessResult("Güncellendi");
        }

    }
}
