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
    public class AdministratorManager : IAdministratorService
    {
        IAdministratorDal _administratorDal;

        public AdministratorManager(IAdministratorDal administratorDal)
        {
            _administratorDal = administratorDal;
        }

        public IResult Add(Administrator administrator)
        {
            _administratorDal.Add(administrator);
            return new SuccessResult();
        }

        public IDataResult<List<Administrator>> GetAll()
        {
            return new SuccessDataResult<List<Administrator>>(_administratorDal.GetAll());
        }

        public IResult Update(Administrator administrator)
        {
            _administratorDal.Update(administrator);
            return new SuccessResult();
        }
    }
}
