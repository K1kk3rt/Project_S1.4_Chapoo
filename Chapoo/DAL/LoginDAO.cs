using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MODEL;

namespace DAL
{
    public class LoginDAO
    {
        public int GetPersoonId(Login user)
        {
            string query = "SELECT werknemerID FROM Werknemers WHERE voornaam = '@naam' AND wachtwoord = '@hash'";
            query = query.Replace("@naam", user.Username);
            query = query.Replace("@hash", user.Password);

            //SqlConnection conn = DALConnection.GetConnectionByName("Writer");
            

            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var command = new SqlCommand(query, conn);
                return (int)command.ExecuteScalar();
            }

        }
    }
}
