using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdministratorService
    {
        IDataResult<List<Administrator>> GetAll();
        IResult Add(Administrator administrator);
        IResult Update(Administrator administrator);

        IResult UserIsActiveAdd(UserIsActive userIsActive);
        IResult UserIsActiveUpdate(UserIsActive userIsActive);
    }
}
