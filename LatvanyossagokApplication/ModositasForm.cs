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
    public partial class ModositasForm : Form
    {
        MySqlConnection conn;
        private int id;
        private String nev;
        private int lakossag;

        public ModositasForm(int id, String nev, int lakossag)
        {
            InitializeComponent();

            this.id = id;
            this.nev = nev;
            this.lakossag = lakossag;
            
            conn = new MySqlConnection("server=localhost;Port=3307;Database=latvanyossagokdb;UId=root;Pwd=;");
            conn.Open();

        }
        private void btnChangeVaros_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE varosok
                                SET
                                    nev = @vnev, 
                                    lakossag = @lakossag
                                WHERE 
                                    id = @vid;";

            cmd.Parameters.AddWithValue("@vnev", vnev.Text);
            cmd.Parameters.AddWithValue("@lakossag", nudujlakossag.Text);

            cmd.Parameters.AddWithValue("@vid", this.id);

            cmd.ExecuteNonQuery();

        }
    }
}
