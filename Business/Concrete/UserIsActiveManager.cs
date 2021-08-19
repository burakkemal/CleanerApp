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
    public class UserIsActiveManager : IUserIsActiveService
    {
        IUserIsActiveDal _userIsActiveDal;

        public UserIsActiveManager(IUserIsActiveDal userIsActiveDal)
        {
            _userIsActiveDal = userIsActiveDal;
        }

        public IResult Add(UserIsActive userIsActive)
        {
            _userIsActiveDal.Add(userIsActive);
            return new SuccessResult();
        }

        public IDataResult<List<UserIsActive>> GetAll()
        {
            return new SuccessDataResult<List<UserIsActive>>(_userIsActiveDal.GetAll());
        }

        public IResult Update(UserIsActive userIsActive)
        {
            _userIsActiveDal.Update(userIsActive);
            return new SuccessResult();
        }
    }
}
