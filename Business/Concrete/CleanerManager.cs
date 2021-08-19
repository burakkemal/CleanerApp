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
            return new SuccessResult(Messages.CleanerAdded);
        }

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
