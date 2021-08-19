using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationObjectService
    {
        IDataResult<List<LocationObject>> GetAll();
        IResult Add(LocationObject locationObject);
        IResult Update(LocationObject locationObject);
    }
}
