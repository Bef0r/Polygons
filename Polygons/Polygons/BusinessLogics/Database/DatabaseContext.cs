using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Polygons.Business_Logics.Database
{
    class DatabaseContext
    {
        private SqlConnection connection;
        private static DatabaseContext database;

        private DatabaseContext()
        {
        }

        public static DatabaseContext getInstance()
        {
            if (database == null)
            {
                database = new DatabaseContext();
            }
            return database;
        }

        public bool isConnected()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool connectToDataBase()
        {
            try
            {
                String local = Path.Combine(Environment.CurrentDirectory);
                String conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + local + @"\Database.mdf;Integrated Security=True;";
                connection = new SqlConnection(conn);
                connection.Open();
            }
            catch (Exception exception)
            {
                return false;
            }
            return true;

        }

        public bool disconnectFromoDataBase()
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

        public void saveToDatabase(int numberOfVerticesOfPolygon, double district)
        {
            SqlCommand com = new SqlCommand(createSqlQuqery(numberOfVerticesOfPolygon, district), connection);
            SqlDataReader rdr = com.ExecuteReader();
            rdr.Close();
        }

        protected String createSqlQuqery(int numberOfVerticesOfPolygon, double district)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("INSERT INTO Polygon (NumberOfVerticesOfPolygon, District ) VALUES (");
            stringBuilder.Append(numberOfVerticesOfPolygon);
            stringBuilder.Append(", ");
            String districtInStringForm = district.ToString();
            stringBuilder.Append(districtInStringForm.Replace(',', '.'));
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }
    }
}
