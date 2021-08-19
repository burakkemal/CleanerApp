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
    public class HospitalIsActiveManager : IHospitalIsActiveService
    {
        IHospitalIsActiveDal _hospitalIsActiveDal;

        public HospitalIsActiveManager(IHospitalIsActiveDal hospitalIsActiveDal)
        {
            _hospitalIsActiveDal = hospitalIsActiveDal;
        }

        public IResult Add(HospitalIsActive hospitalIsActive)
        {
            _hospitalIsActiveDal.Add(hospitalIsActive);
            return new SuccessResult();
        }

        public IDataResult<List<HospitalIsActive>> GetAll()
        {
            return new SuccessDataResult<List<HospitalIsActive>>(_hospitalIsActiveDal.GetAll());
        }

        public IResult Update(HospitalIsActive hospitalIsActive)
        {
            _hospitalIsActiveDal.Update(hospitalIsActive);
            return new SuccessResult();
        }
    }
}
