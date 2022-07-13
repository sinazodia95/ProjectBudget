using System;
using System.Data.SqlClient;

namespace AccessBu
{
    public class Access
    {
        public static void AddExpense(int rent, int food, int toilet, int gym, int trans, int inter, int clothes, int family, int Electricity, int tot, string connectionString)
        {
            //sqlconnection con = new sqlconnection();
            var RowsAffected = 0;
            
            {
                // Create SQL connection object in using block for automatic closing and disposing
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    // Create command object in using block for automatic disposal
                    using (SqlCommand cmd = new SqlCommand("Masterinsertupdatedelete", cnn))
                    {



                        cmd.Parameters.Add(new SqlParameter("@rent", rent));
                        cmd.Parameters.Add(new SqlParameter("@food", food));
                        cmd.Parameters.Add(new SqlParameter("@toilet", toilet));
                        cmd.Parameters.Add(new SqlParameter("@gym", gym));
                        cmd.Parameters.Add(new SqlParameter("@trans", trans));
                        cmd.Parameters.Add(new SqlParameter("@Inter", inter));
                        cmd.Parameters.Add(new SqlParameter("@clothes", clothes));
                        cmd.Parameters.Add(new SqlParameter("@family", family));
                        cmd.Parameters.Add(new SqlParameter("@Electricity", Electricity));
                        cmd.Parameters.Add(new SqlParameter("@Total", tot));
                        cmd.Parameters.Add(new SqlParameter("@StatementType", "insert"));
                        
                        // Set CommandType
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        // Open the connection
                        cnn.Open();

                        // Execute the INSERT statement
                        cmd.ExecuteNonQuery();




                      var  ResultText = "Rows Affected: " + RowsAffected.ToString();
                    }
                }
               
            }

        }
    }
}
