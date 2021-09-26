using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Polygons.Business_Logics.Database
{
    class SaveToDatabase
    {
        private SqlConnection connection;
        private static SaveToDatabase database;

        private SaveToDatabase()
        {
        }

        public static SaveToDatabase getInstance()
        {
            if (database == null)
            {
                database = new SaveToDatabase();
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
                String conn = @"Server=(localdb)\MSSQLLocalDB;Database=Polygon";
                connection = new SqlConnection(conn);
                connection.Open();
            }
            catch (Exception)
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

        public void saveToDatabase(int numberOfVerticesOfPolygon, int district)
        {
            SqlCommand com = new SqlCommand(createSqlQuqery(numberOfVerticesOfPolygon, district), connection);
            com.ExecuteReader();
        }

        protected String createSqlQuqery(int numberOfVerticesOfPolygon, int district)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("INSERT INTO Polygon (NumberOfVerticesOfPolygon, District ) VALUES('");
            stringBuilder.Append(numberOfVerticesOfPolygon);
            stringBuilder.Append("', '");
            stringBuilder.Append(district);
            stringBuilder.Append("')");
            return stringBuilder.ToString();
        }
    }
}
