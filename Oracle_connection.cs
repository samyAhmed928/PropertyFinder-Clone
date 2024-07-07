using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace prop_finder
{
    class Oracle_connection
    {
         string ordb = "Data Source=ORCL User Id=Property_finder Password=prop_finder";
        static OracleConnection conn;

        public Oracle_connection()
        {
            conn = new OracleConnection(ordb);
        }
    }
}
