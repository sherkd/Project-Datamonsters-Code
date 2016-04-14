using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Parcer_
{
    class SqlConnectionDemo
    {
        static void Main() // Databases moeten nog gemaakt worden, daarna parcer opnieuw instellen!
        {
            //Parcer_Straatroven parcer = new Parcer_Straatroven();
            //parcer.Straatroven();
            Parcer_Fietsdiefstal parcer_2 = new Parcer_Fietsdiefstal();
            parcer_2.fietsdiefstal();
            //CommentTest
        }
    }
}
    