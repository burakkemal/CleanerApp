using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ObjectManager : IObjectService
    {
        IObjectDal _objectDal;

        public ObjectManager(IObjectDal objectDal)
        {
            _objectDal = objectDal;
        }

        [ValidationAspect(typeof(ObjectValidator))]
        public IResult Add(Entities.Concrete.Object @object)
        {
            _objectDal.Add(@object);
            return new SuccessResult();
        }

        public IDataResult<List<Entities.Concrete.Object>> GetAll()
        {
            return new SuccessDataResult<List<Entities.Concrete.Object>>(_objectDal.GetAll());
        }

        public IResult Update(Entities.Concrete.Object @object)
        {
            _objectDal.Update(@object);
            return new SuccessResult();
        }
    }
}
