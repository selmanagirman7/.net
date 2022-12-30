using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added below name spaces
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using DataAccess;

namespace TechBrothersIT.com_CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //the datetime and Log folder will be used for error log file in case error occured
            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string LogFolder = @"C:\Log\";
            try
            {
                //Provide the Source Folder path where excel files are present
                String FolderPath = @"C:\Source\";
                //Provide the Database Name 
                string DatabaseName = "TechbrothersIT";
                //Provide the SQL Server Name 
                string SQLServerName = "(local)";


                //Create Connection to SQL Server Database 
                Context SQLConnection = new SqlConnection();
                SQLConnection.ConnectionString = "Data Source = "
                    + SQLServerName + "; Initial Catalog ="
                    + DatabaseName + "; "
                    + "Integrated Security=true;";

                var directory = new DirectoryInfo(FolderPath);
                FileInfo[] files = directory.GetFiles();

                //Declare and initilize variables
                string fileFullPath = "";

                //Get one Book(Excel file at a time)
                foreach (FileInfo file in files)
                {
                    string filename = "";
                    fileFullPath = FolderPath + "\\" + file.Name;
                    filename = file.Name.Replace(".xlsx", "");

                    //Create Excel Connection
                    string ConStr;
                    string HDR;
                    HDR = "YES";
                    ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileFullPath
                        + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=1\"";
                    OleDbConnection cnn = new OleDbConnection(ConStr);

                    //Get Sheet Name
                    cnn.Open();
                    DataTable dtSheet = cnn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string sheetname;
                    sheetname = "";
                    foreach (DataRow drSheet in dtSheet.Rows)
                    {
                        if (drSheet["TABLE_NAME"].ToString().Contains("$"))
                        {
                            sheetname = drSheet["TABLE_NAME"].ToString();
                            //Load DataTable with Sheet Data
                            OleDbCommand oconn = new OleDbCommand("select * from [" + sheetname + "]", cnn);
                            OleDbDataAdapter adp = new OleDbDataAdapter(oconn);
                            DataTable dt = new DataTable();
                            adp.Fill(dt);


                            // Create Table if does not exists                
                            string tableDDL = "";
                            tableDDL += "IF Not EXISTS (SELECT * FROM sys.objects WHERE object_id = ";
                            tableDDL += "OBJECT_ID(N'[dbo].[" + filename + "]') AND type in (N'U'))";
                            tableDDL += "Create table [" + filename + "]";
                            tableDDL += "(";
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                if (i != dt.Columns.Count - 1)
                                    tableDDL += "[" + dt.Columns[i].ColumnName + "] " + "NVarchar(max)" + ",";
                                else
                                    tableDDL += "[" + dt.Columns[i].ColumnName + "] " + "NVarchar(max)";
                            }
                            tableDDL += ")";


                            SQLConnection.Open();
                            SqlCommand myCommand = new SqlCommand(tableDDL, SQLConnection);
                            myCommand.ExecuteNonQuery();

                            //Load the data from DataTable to SQL Server Table.
                            SqlBulkCopy blk = new SqlBulkCopy(SQLConnection);
                            blk.DestinationTableName = "[" + filename + "]";
                            blk.WriteToServer(dt);
                        }
                        SQLConnection.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                // Create Log File for Errors
                using (StreamWriter sw = File.CreateText(LogFolder
                    + "\\" + "ErrorLog_" + datetime + ".log"))
                {
                    sw.WriteLine(exception.ToString());

                }

            }

        }
    }
}