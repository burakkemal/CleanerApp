using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICleanerService
    {
        IDataResult<List<Cleaner>> GetAll();
        IResult Add(Cleaner cleaner);
        IResult Update(Cleaner cleaner);
    }
}
