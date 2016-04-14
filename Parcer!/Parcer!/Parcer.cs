using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Npgsql;


namespace Parcer_
{
    class Parcer_Straatroven
    {
        public void Straatroven()        {
            
            List<string[]> members = new List<string[]>();
            try
            {

                using (StreamReader parser = new StreamReader("D:/Github_zooi/Project3_ DataMonsters/Code/Versie 0.1/Straatroven.csv"))

                {
                    string line;
                    NpgsqlConnection conn = new NpgsqlConnection("Host=127.0.0.1;Username=postgres;Password=sqltestingdata;Database=TestingParcer");
                       
                        conn.Open();
                    while (!parser.EndOfStream)                    
                    {
                        line = parser.ReadLine();                        
                        string[] split_Value = line.Split(',');
                        
                        string Voorval_nr = Convert.ToString(split_Value[0]);
                        //Voorval_nr.Replace("\"", "");
                        if (Voorval_nr[0] == '"')
                        {
                            Voorval_nr = Voorval_nr.Remove(0,1);
                        }
                        string Dagdeel = Convert.ToString(split_Value[6]);
                        Console.WriteLine(split_Value[8]);
                        DateTime begindatum = Convert.ToDateTime(split_Value[8]);
                        //DateTime begindatum = startdatum.Day + startdatum.DayOfWeek + startdatum.DayOfYear;
                        //DateTime einddatum = Convert.ToDateTime(split_Value[11]);
                        DateTime einddatum = Convert.ToDateTime(split_Value[10]);
                        string plaats = Convert.ToString(split_Value[14]);
                        Console.WriteLine(plaats);                       
                        string buurt = Convert.ToString(split_Value[17]);               


                        

                        //string insertString = "INSERT INTO Straatroven(voorval_nr)values (@Voorval_nr)";
                        
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        if (plaats == "ROTTERDAM")
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO Straatroven (voorval_nr,dagdeel,buurt,begindatum,einddatum) VALUES ('" + Voorval_nr + "','" + Dagdeel + "','" + buurt + "','" + begindatum + "','" + einddatum + "')";

                            //SqlCommand cmd = new SqlCommand(insertString, conn);
                            Console.WriteLine(cmd.CommandText);
                            //cmd.Parameters.AddWithValue("@Voorval_nr", Voorval_nr);
                            cmd.ExecuteNonQuery();
                            //cmd.ExecuteScalar();
                        }

                        //Console.WriteLine(split_Value[14]);
                        //Console.ReadLine();
                        //// commentaar hebben we hier liever niet                   
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }        
    }
}
