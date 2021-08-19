using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IObjectService
    {
        IDataResult<List<Entities.Concrete.Object>> GetAll();
        IResult Add(Entities.Concrete.Object @object);

        IResult Update(Entities.Concrete.Object @object);
    }
}
