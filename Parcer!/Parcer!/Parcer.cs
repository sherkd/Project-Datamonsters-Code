using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;


namespace Parcer_
{
    class Parcer
    {
        public void Straatroven()
        {
            int j = 0;
            List<string[]> members = new List<string[]>();
            try
            {
                using (StreamReader parser = new StreamReader("D:/Github_zooi/Project3_ DataMonsters/Code/Versie 0.1/Straatroven.csv"))
                {
                    string line;
                    while (!parser.EndOfStream)
                    {
                        line = parser.ReadLine();
                        string[] split_Value = line.Split(',');                        
                        j++;
                        string Voorval_nr = Convert.ToString(split_Value[0]);
                        string dagdeel = Convert.ToString(split_Value[7]);
                        DateTime begindatum = Convert.ToDateTime(split_Value[9]);
                        DateTime einddatum = Convert.ToDateTime(split_Value[11]);
                        string plaats = Convert.ToString(split_Value[15]);
                        string buurt = Convert.ToString(split_Value[18]);

                        if (j == 0 || j == 7 || j == 9 || j == 11|| j == 15 || j == 18)
                        {
                            members.Add(split_Value);
                        }


                        Console.WriteLine(split_Value[14]);
                        Console.ReadLine();
                        // commentaar hebben we hier liever niet                   
                    }
                }
            }
            catch
            {

            }
        }
    }
}
