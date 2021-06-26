using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Station
{
    class LoginClass
    {
        
        public int Label1 { get; set; }
        public String Label2 { get; set; }
        public String Label3 { get; set; }
        public String Label4 { get; set; }
        public int Label5 { get; set; }
        public String Label6 { get; set; }
        public int Label7 { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * from Vehicle_tbl";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert (contactClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String SQL = "INSERT INTO Vehicle_tbl (VehicleModel,CompanyName,OwnerName,ContactNo,Amount,ServiceType) VALUES (@VehicleModel,@CompanyName,@OwnerName,@ContactNo,@Amount,@ServiceType)";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@VehicleModel", c.VehicleModel);
                cmd.Parameters.AddWithValue("@CompanyName", c.CompanyName);
                cmd.Parameters.AddWithValue("@Owner'sName",c.OwnerName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Amount", c.Amount);
                cmd.Parameters.AddWithValue("@Service Type", c.ServiceType);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
         public bool Update(contactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE Vehicle_tbl SET VehicleModel=@VehicleModel,CompanyName=@CompanyName,OwnerName=@OwnerName,ContactNo=@ContactNo,Amount=@Amount,ServiceType=@ServiceType WHERE VehicleNo=@VehicleNo";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@VehicleModel", c.VehicleModel);
                cmd.Parameters.AddWithValue("@CompanyName", c.CompanyName);
                cmd.Parameters.AddWithValue("@Owner'sName", c.OwnerName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Amount", c.Amount);
                cmd.Parameters.AddWithValue("@Service Type", c.ServiceType);
                cmd.Parameters.AddWithValue("@VehicleNo", c.VehicleNo);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Delete(contactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM Vehicle_tbl WHERE VehicleNo=@VehicleNo";

                SqlCommand cmd = new SqlCommand(sql.conn);
                cmd.Parameters.AddWithValue("@VehicleNo", c.VehicleNo);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
