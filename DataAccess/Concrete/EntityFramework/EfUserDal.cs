using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, PersonalWebSiteDbContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (PersonalWebSiteDbContext context = new PersonalWebSiteDbContext())
            {
                var claims = (from oc in context.OperationClaims
                              join uoc in context.UserOperationClaims on oc.Id equals uoc.OperationClaimId
                              where uoc.UserId == user.Id
                              select new OperationClaim
                              {
                                  Id = oc.Id,
                                  Name = oc.Name
                              }).ToList();
                return claims;
            }
        }
    }
}
