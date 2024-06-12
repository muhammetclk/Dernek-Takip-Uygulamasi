using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public class MemberCheckService
    {

        
        public virtual Boolean checkMember(BaseDal baseDal, String tc)
        {
            return baseDal.checkMemberByTc(tc);
        }
    }
}
