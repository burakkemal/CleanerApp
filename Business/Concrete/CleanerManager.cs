using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CleanerManager : ICleanerService
    {
        ICleanerDal _cleanerDal;
        


        public CleanerManager(ICleanerDal cleanerDal)
        {
            _cleanerDal = cleanerDal;
        }

        public IResult Add(Cleaner cleaner)
        {
            _cleanerDal.Add(cleaner);
            return new SuccessResult("Eklendi");
        }

        [SecuredOperation("admin")]
        public IDataResult<List<Cleaner>> GetAll()
        {
            return new SuccessDataResult<List<Cleaner>>(_cleanerDal.GetAll());
        }

        public IResult Update(Cleaner cleaner)
        {
            _cleanerDal.Update(cleaner);
            return new SuccessResult(Messages.CleanerUpdated);
        }
    }
}
