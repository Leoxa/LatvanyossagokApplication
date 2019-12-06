using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        private String nev;
        private String leir;
        private int ar;
        private int id;

        public Form2(int id, String nev, String leir, int ar )
        {
            InitializeComponent();

            this.id = id;
            this.nev = nev;
            this.leir = leir;
            this.ar = ar;

            conn = new MySqlConnection("server=localhost;Port=3307;Database=latvanyossagokdb;UId=root;Pwd=;");
            conn.Open();
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE latvanyossagok
                                SET
                                    nev = @lnev,
                                    ar = @ar,
                                    leiras = @leir
                                WHERE 
                                    id = @id;";

            cmd.Parameters.AddWithValue("@lnev", lnev.Text);
            cmd.Parameters.AddWithValue("@ar", lar.Text);
            cmd.Parameters.AddWithValue("@leir", lleir.Text);

            cmd.Parameters.AddWithValue("@id", this.id);

            cmd.ExecuteNonQuery();

        }

    }
}
