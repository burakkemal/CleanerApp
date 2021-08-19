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
        IUserIsActiveService _userIsActiveService;

        public AdministratorManager(IAdministratorDal administratorDal, IUserIsActiveService userIsActiveService)
        {
            _administratorDal = administratorDal;
            _userIsActiveService = userIsActiveService;
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

        public IResult UserIsActiveAdd(UserIsActive userIsActive)
        {
            _userIsActiveService.Add(userIsActive);
            return new SuccessResult("Eklendi");
        }

        public IResult UserIsActiveUpdate(UserIsActive userIsActive)
        {
            _userIsActiveService.Update(userIsActive);
            return new SuccessResult("Güncellendi");
        }
    }
}
