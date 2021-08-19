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
    public class LocationObjectManager : ILocationObjectService
    {
        ILocationObjectDal _locationObjectDal;
        public LocationObjectManager(ILocationObjectDal locationObjectDal)
        {
            _locationObjectDal = locationObjectDal;
        }

        public IResult Add(LocationObject locationObject)
        {
            _locationObjectDal.Add(locationObject);
            return new SuccessResult();
        }

        public IDataResult<List<LocationObject>> GetAll()
        {
            return new SuccessDataResult<List<LocationObject>>(_locationObjectDal.GetAll());
        }

        public IResult Update(LocationObject locationObject)
        {
            _locationObjectDal.Update(locationObject);
            return new SuccessResult();
        }
    }
}
