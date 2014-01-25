using System.Data.OleDb;
using System.Data;
using System;

namespace ConsoleApplication1
{
    public class XLSCitanje
    {

        private DataTable GetDataTable(string sql, string connectionString)
        {
            DataTable dt = new DataTable();
            
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        dt.Load(rdr);
                        return dt;
                    }
                }
                
            }
        }
        public void GetExcel()
        {
            string fullPathToExcel = @"F:\Porezi,Prijave i ostalo\ppppd septembar-konacno-2014-simpo.xls"; //ie C:\Temp\YourExcel.xls
            string connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=yes'", fullPathToExcel);
            DataTable dt = GetDataTable("SELECT * from [test$]", connString);
            OleDbDataAdapter kutice = new OleDbDataAdapter("SELECT * from [test$]",connString);
            DataSet uff = new DataSet();
            kutice.Fill(uff, "nesto");
            Console.ReadLine();
           /* foreach (DataRow dr in dt.Rows)
            {
                foreach(DataColumn column in dt.Columns)
                {
                    Console.WriteLine(column.DefaultValue);
                }
                
            }*/
        }
    }
}
    

