using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public class DuesPaymentsCheckService
    {
        public virtual Boolean checkDues(BaseDal baseDal, int member_id, int dues_plan_id)
        {
            return baseDal.checkDuesPaymentsByMemberIdAndDuesPlanId(member_id, dues_plan_id);
        }
    }
}
