using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccessDatabaseDal:BaseDal
    {


        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter adapter;
        OleDbDataReader dataReader;


        
        public AccessDatabaseDal(String connectionString) : base(connectionString)
        {
            baglanti = new OleDbConnection(connectionString);
        }


        
        public override void member_add(String member_firstname, String member_lastname, String tc, String blood_group, String gender, String phone, String email, String address, String city_id, String date_of_registration) // override edilmiş ekle metodumuz. 
        {
            baglanti.Open();
            komut = new OleDbCommand("insert into Members (member_firstname, member_lastname, tc, blood_group," +
                " gender, phone, email,address,city_id,date_of_registration) " +
                                                "values (@member_firstname, @member_lastname, @tc, @blood_group," +
                                                " @gender, @phone, @email,@address,@city_id,@date_of_registration)"
                                                , baglanti);
            komut.Parameters.AddWithValue("@member_firstname", member_firstname);
            komut.Parameters.AddWithValue("@member_lastname", member_lastname);
            komut.Parameters.AddWithValue("@tc", tc);
            komut.Parameters.AddWithValue("@blood_group", blood_group);
            komut.Parameters.AddWithValue("@gender", gender);
            komut.Parameters.AddWithValue("@phone", phone);
            komut.Parameters.AddWithValue("@email", email);
            komut.Parameters.AddWithValue("@address", address);
            komut.Parameters.AddWithValue("@city_id", city_id);
            komut.Parameters.AddWithValue("@date_of_registration", date_of_registration);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }



        public override Boolean checkMemberByTc(string tc)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select tc from Members where tc = '" + tc + "'", baglanti);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }



        public override DataSet member_list()
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("select * from Members", baglanti);
            adapter.Fill(dataSet,"Members");          
            baglanti.Close();
            return dataSet;

          
        }


        public override void member_update(int member_id,String member_firstname, String member_lastname,
            String tc, String blood_group, String gender, String phone, String email, String address,
            String city_id,String status)
        {
            baglanti.Open();
            
            komut = new OleDbCommand("update Members set member_firstname = '" + member_firstname + "'," +
                " member_lastname = '" + member_lastname + "', tc = '" + tc + "'," +
                " blood_group = '" + blood_group + "', gender = '" + gender + "'," +
                " phone = '" + phone + "', email = '" + email + "', address = '" + address + "'," +
                " city_id = '" + city_id + "', status = '" + status + "'  where member_id = @member_id", baglanti);
            komut.Parameters.AddWithValue("member_id", member_id.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        public override DataSet member_list(String filterColumnName,String filter)
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            string query = $"SELECT * FROM Members WHERE {filterColumnName} = @Filter";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, baglanti);

            // Parametreyi ekleyerek değerini belirleme
            adapter.SelectCommand.Parameters.AddWithValue("@Filter", filter);
            adapter.Fill(dataSet, "Members");
            baglanti.Close();
            return dataSet;


        }

        public override DataSet dues_plan_list()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                DataSet dataSet = new DataSet();
                adapter = new OleDbDataAdapter("SELECT * FROM DuesPlans", baglanti);
                adapter.Fill(dataSet, "DuesPlans");

                return dataSet;
            }
            catch (Exception ex)
            {
                
                return null; 
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }


        }


        public override void dues_plan_add(String dues_month, String dues_year, String dues_amount)  
        {
            try
            {
               
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                komut = new OleDbCommand("INSERT INTO DuesPlans (dues_month, dues_year, dues_amount) " +
                                        "VALUES (@dues_month, @dues_year, @dues_amount)", baglanti);
                komut.Parameters.AddWithValue("@dues_month", dues_month);
                komut.Parameters.AddWithValue("@dues_year", dues_year);
                komut.Parameters.AddWithValue("@dues_amount", dues_amount);

                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }


        public override Boolean checkDuesPlanByMonthAndYear(String dues_month,String dues_year)
        {
            baglanti.Open();
            string query = "SELECT dues_month, dues_year FROM DuesPlans WHERE dues_month = @dues_month " +
                "AND dues_year = @dues_year";
            komut = new OleDbCommand(query, baglanti);
            komut.Parameters.AddWithValue("@dues_month", dues_month);
            komut.Parameters.AddWithValue("@dues_year", dues_year);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }


        public override DataSet dues_payments_list()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                DataSet dataSet = new DataSet();
                adapter = new OleDbDataAdapter("SELECT DuesPayments.dues_payment_id,Members.member_firstname," +
                    "Members.member_lastname,Members.tc,DuesPlans.dues_month,DuesPlans.dues_year,DuesPlans.dues_amount," +
                    "DuesPayments.paid_amount" +
                    " FROM (DuesPayments Inner join Members on DuesPayments.member_id=Members.member_id) " +
                    "Inner join DuesPlans on DuesPayments.dues_plan_id=DuesPlans.dues_plan_id", baglanti);                              
                adapter.Fill(dataSet);             
                return dataSet;
            }
            catch (Exception ex)
            {                               
                return null; 
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        public override DataSet list_active_members()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                DataSet dataSet = new DataSet();
                adapter = new OleDbDataAdapter("SELECT member_id,tc,member_firstname,member_lastname,status " +
                    "from Members where status='aktif'",baglanti);        
                adapter.Fill(dataSet);              
                return dataSet;
            }
            catch (Exception ex)
            {
                
                
                return null; 
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }


        public override Boolean checkDuesPaymentsByMemberIdAndDuesPlanId(int member_id, int dues_plan_id)
        {
            baglanti.Open();
            string query = "SELECT member_id, dues_plan_id FROM DuesPayments WHERE member_id = @member_id AND" +
                " dues_plan_id = @dues_plan_id";
            komut = new OleDbCommand(query, baglanti);
            komut.Parameters.AddWithValue("@member_id", member_id);
            komut.Parameters.AddWithValue("@dues_plan_id", dues_plan_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }


        public override void dues_payment_add(int member_id, int dues_plan_id, String paid_amount, String payment_date) // override edilmiş ekle metodumuz. 
        {
            try
            {                
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new OleDbCommand("INSERT INTO DuesPayments (member_id, dues_plan_id, paid_amount,payment_date) " +
                                        "VALUES (@member_id, @dues_plan_id, @paid_amount,@payment_date)", baglanti);
                komut.Parameters.AddWithValue("@member_id", member_id);
                komut.Parameters.AddWithValue("@dues_plan_id", dues_plan_id);
                komut.Parameters.AddWithValue("@paid_amount", paid_amount);
                komut.Parameters.AddWithValue("@payment_date", payment_date);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {}
            finally
            {               
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }


        public override DataSet debts_list()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                DataSet dataSet = new DataSet();
                adapter = new OleDbDataAdapter("SELECT Members.member_firstname,Members.member_lastname,Members.tc," +
                    "DuesPlans.dues_month,DuesPlans.dues_year,DuesPlans.dues_amount,DuesPayments.paid_amount," +
                    "DuesPlans.dues_amount-DuesPayments.paid_amount as debts,Members.email" + 
                    " FROM (DuesPayments Inner join Members on DuesPayments.member_id=Members.member_id) " +
                    "Inner join DuesPlans on DuesPayments.dues_plan_id=DuesPlans.dues_plan_id "+
                    " WHERE DuesPlans.dues_amount - DuesPayments.paid_amount <> 0", baglanti);            
                adapter.Fill(dataSet);             
                return dataSet;
            }
            catch (Exception ex)
            {                             
                return null; 
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }



        public override DataSet get_member_city()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                DataSet dataSet = new DataSet();
                
                adapter = new OleDbDataAdapter("Select count(member_id) as MemberCount, city_id from Members " +
                    "group by city_id ", baglanti);          
                adapter.Fill(dataSet);              
                return dataSet;
            }
            catch (Exception ex)
            {             
                return null; 
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }



        public override DataSet get_monthly_and_yearly_income_data()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                DataSet dataSet = new DataSet();
                
                adapter = new OleDbDataAdapter("SELECT SUM(DuesPayments.paid_amount) AS PaidAmount," +
                    " DuesPlans.dues_year + '-' + DuesPlans.dues_month AS DuesDate, DuesPlans.dues_year " +
                              "FROM DuesPayments " +
                              "INNER JOIN DuesPlans ON DuesPayments.dues_plan_id = DuesPlans.dues_plan_id " +
                              "GROUP BY DuesPlans.dues_year, DuesPlans.dues_month", baglanti);     
                adapter.Fill(dataSet);             
                return dataSet;
            }
            catch (Exception ex)
            {                
                return null; 
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }



        public override DataSet list_paid_members(String startMonth, int startYear, String endMonth, int endYear)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                DataSet dataSet = new DataSet();
                adapter = new OleDbDataAdapter("SELECT DuesPayments.member_id, Members.member_firstname, Members.member_lastname, DuesPayments.payment_date" +
            " FROM (DuesPayments INNER JOIN Members ON DuesPayments.member_id = Members.member_id) INNER JOIN DuesPlans ON DuesPayments.dues_plan_id = DuesPlans.dues_plan_id" +
            " WHERE DuesPlans.dues_month BETWEEN @startMonth AND @endMonth AND DuesPlans.dues_year BETWEEN @startYear AND @endYear", baglanti);
                adapter.SelectCommand.Parameters.AddWithValue("@startMonth", startMonth);
                adapter.SelectCommand.Parameters.AddWithValue("@startYear", startYear);

                adapter.SelectCommand.Parameters.AddWithValue("@endMonth", endMonth);
                adapter.SelectCommand.Parameters.AddWithValue("@endYear", endYear);

                
                adapter.Fill(dataSet);
                

                return dataSet;
            }
            catch (Exception ex)
            {
                
                return null; 
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }


    }
}
