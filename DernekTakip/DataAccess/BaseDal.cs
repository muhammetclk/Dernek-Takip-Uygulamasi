using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BaseDal
    {
        private String connectionString; // bağlantı stringimiz için değişken oluşturduk
        public BaseDal(String connectionString)
        {
            this.connectionString = connectionString; // bağlantı stringimizi constructor yardımıyla alıyoruz.
        }


        public virtual void member_add(String member_firstname, String member_lastname, String tc, String blood_group, String gender, String phone, String email,String address, String city_id,String date_of_registration) // ekleme metodumuz
        {

        }
        
        public virtual void member_delete(int member_id)
        {

        }
        
        public virtual void member_update(int member_id,String member_firstname, String member_lastname, String tc, String blood_group, String gender, String phone, String email, String address, String city_id,String status)
        {

        }
        


        public virtual  Boolean checkMemberByTc(string tc)
        {
            return true;
        }

        public virtual DataSet member_list() {
            return null;
        }

        public virtual DataSet member_list(String filterColumnName,String filter)
        {
            return null;
        }

        public virtual DataSet dues_plan_list()
        {
            return null;
        }

        public virtual void dues_plan_add(String dues_month, String dues_year, String dues_amount) // ekleme metodumuz
        {

        }

        public virtual Boolean checkDuesPlanByMonthAndYear(String dues_month, String dues_year)
        {
            return true;
        }
        public virtual Boolean checkDuesPaymentsByMemberIdAndDuesPlanId(int member_id, int dues_plan_id)
        {
            return true;
        }


        public virtual DataSet dues_payments_list()
        {
            return null;
        }

        public virtual DataSet list_active_members()
        {
            return null;
        }


        public virtual void dues_payment_add(int member_id,int dues_plan_id,String paid_amount,String payment_date) // ekleme metodumuz
        {

        }



        public virtual DataSet debts_list()
        {
            return null;
        }

        public virtual DataSet get_member_city()
        {
            return null;
        }

       
        public virtual DataSet get_monthly_and_yearly_income_data()
        {
            return null;
        }


        public virtual DataSet list_paid_members(String startMonth, int startYear, String endMonth, int endYear)
        {
            return null;
        }

    }
}
