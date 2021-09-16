using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
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
        IDataResult<List<CleanersDetailDto>> GetCleanerDetail();
        IResult Add(Cleaner cleaner);
        IResult Update(Cleaner cleaner);

    }
}
