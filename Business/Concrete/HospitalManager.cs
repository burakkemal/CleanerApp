using Business.Abstract;
using Business.Constants;
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
    public class HospitalManager : IHospitalService
    {
        IHospitalDal _hospitalDal;

        public HospitalManager(IHospitalDal hospitalDal)
        {
            _hospitalDal = hospitalDal;
        }

        public IResult Add(Hospital hospital)
        {
            _hospitalDal.Add(hospital);
            return new SuccessResult(Messages.HospitalAdded);
        }

        public IDataResult<List<Hospital>> GetAll()
        {
            return new SuccessDataResult<List<Hospital>>(_hospitalDal.GetAll());
        }

        public IResult Update(Hospital hospital)
        {
            _hospitalDal.Update(hospital);
            return new SuccessResult(Messages.HospitalUpdated);
        }
    }
}
