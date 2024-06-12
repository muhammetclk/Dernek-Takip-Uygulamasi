using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public class DuesPlanCheckService
    {

        public virtual Boolean checkDues(BaseDal baseDal, String dues_month, String dues_year)
        {
            return baseDal.checkDuesPlanByMonthAndYear(dues_month, dues_year);
        }
    }
}
