using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCleanerDal : EfEntityRepositoryBase<Cleaner, CleanerAppContext>, ICleanerDal
    {
        public EfCleanerDal(CleanerAppContext context) : base(context)
        {
            
        }

        public List<CleanersDetailDto> GetCleanersDetails(Expression<Func<Cleaner, bool>> filter = null)
        {
            var result = from Cleaner in filter==null? Context.Cleaners : Context.Cleaners.Where(filter)
                         join User in Context.Users
                         on Cleaner.UserId equals User.Id
                         select new CleanersDetailDto
                         {
                             CleanerId = Cleaner.Id,
                             CleanerName = User.FirstName,
                             CleanerSurname = User.LastName,
                             CleanerEmail = User.Email,
                             Gsm = User.TelephoneNumber
                         };
            return result.ToList();

        }

    }
}
