using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public class BusinessManager
    {
        private BaseDal baseDal;
        private MemberCheckService memberCheckService;
        private DuesPlanCheckService duesPlanCheckService;
        private DuesPaymentsCheckService duesPaymentsCheckService;

        public BusinessManager(BaseDal baseDal,
            MemberCheckService memberCheckService,
            DuesPlanCheckService duesPlanCheckService,
            DuesPaymentsCheckService duesPaymentsCheckService )
        {
            this.baseDal = baseDal;
            this.memberCheckService = memberCheckService;
            this.duesPlanCheckService = duesPlanCheckService;
            this.duesPaymentsCheckService = duesPaymentsCheckService;
        }

        public Boolean member_add(String member_firstname,
            String member_lastname,
            String tc,
            String blood_group,
            String gender,
            String phone,
            String email,
            String address,
            String city_id,
            String date_of_registration)
        {
            if (memberCheckService.checkMember(baseDal,tc))
            {
                return true;
            }
            else
            {
                baseDal.member_add( member_firstname,
                    member_lastname,
                    tc,  blood_group,  gender,  phone,  email,  address,  city_id,  date_of_registration);
                return false;
            }

        }

        public DataSet member_list()
        {
            return baseDal.member_list();
        }


        public Boolean member_update(int member_id,
            String member_firstname, String member_lastname, String tc, String blood_group,
            String gender, String phone, String email, String address, String city_id,String status)
        {
                         
                baseDal.member_update(member_id,member_firstname, member_lastname, tc, blood_group, gender,
                    phone, email, address, city_id,status);
                return false;
            

        }


        public void member_delete(int member_id)//verilen id'ye gore silme yapilir.  
        {
            
        }

        public DataSet member_list(String filterColumnName,String filter)
        {
            return baseDal.member_list(filterColumnName,filter);
        }


        public DataSet dues_plan_list()
        {
            return baseDal.dues_plan_list();
        }

        public Boolean dues_plan_add(String dues_month, String dues_year, String dues_amount)
        {
            if (duesPlanCheckService.checkDues(baseDal, dues_month, dues_year))
            {
                return true;
            }
            else
            {
                baseDal.dues_plan_add(dues_month, dues_year, dues_amount);
                return false;
            }

        }


        public DataSet dues_payments_list()
        {
            return baseDal.dues_payments_list();
        }


        public DataSet list_active_members()
        {
            return baseDal.list_active_members();
        }

        public Boolean dues_payment_add(int member_id, int dues_plan_id, String paid_amount,String payment_date)
        {
            if (duesPaymentsCheckService.checkDues(baseDal, member_id, dues_plan_id))
            {
                return true;
            }
            else
            {
                baseDal.dues_payment_add(member_id, dues_plan_id, paid_amount, payment_date);
                return false;
            }

        }


        public DataSet debts_list()
        {
            return baseDal.debts_list();
        }

        public DataSet get_member_city()
        {
            return baseDal.get_member_city();
        }

        

        public DataSet get_monthly_and_yearly_income_data()
        {
            return baseDal.get_monthly_and_yearly_income_data();
        }


        public DataSet list_paid_members(String startMonth, int startYear, String endMonth, int endYear)
        {
            return baseDal.list_paid_members( startMonth, startYear, endMonth, endYear);
        }

    }
}
