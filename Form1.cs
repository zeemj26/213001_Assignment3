using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;


namespace _213001_SQL1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cn = "DESKTOP-30389UE;Initial Catalog=213001_SQL;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        SqlConnection cn = new SqlConnection(cn);
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessCmdKey().CommandText = "Insert into Table Product(Name, UnitPrice, Quantity, Stock) values ('Pins', 5 , 500)";
            totalRowsAffected = ProcessCmdKey().cmd.ExecuteNonQuery();
            HttpResponseMessage.("Total rows inserted  = " + totalRowsAffected + ",br />");



        }
    } 
}
CatchBlock(Exception ex){
    Response.Write(Exception.Message);
}
finally{
    con.Close();
}
