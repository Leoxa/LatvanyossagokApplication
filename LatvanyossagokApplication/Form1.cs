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
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            conn = new MySqlConnection("server=localhost;Port=3306;Database=latvanyossagokdb;UId=root;Pwd=;");
            conn.Open();


            var cmd = conn.CreateCommand();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS varosok 
                                (
                                    id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
                                    nev varchar(255) NOT NULL,
                                    lakossag int NOT NULL
                                );
                                CREATE TABLE IF NOT EXISTS latvanyossagok
                                (
                                    id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
                                    nev varchar(255) NOT NULL,
                                    leiras varchar(255) NOT NULL,
                                    ar int NOT NULL,
                                    varos_id int NOT NULL,
                                    FOREIGN KEY (varos_id) REFERENCES varosok(id)
                                );";
            cmd.ExecuteNonQuery();

            Adatoklistazas();

        }
        
        private void Adatoklistazas()
        {
            varosLista.Items.Clear();
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT nev, lakossag, id FROM varosok";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    var id = reader.GetInt32("id");

                    var v = new Varos(nev, lakossag, id);
                    
                    varosLista.Items.Add(v);
                }
            }
        }
               
       private void varosLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            latvanyossagok.Items.Clear();

            var command = conn.CreateCommand();
            command.CommandText = @"SELECT nev, leiras, ar, varos_id 
                                FROM latvanyossagok
                                WHERE varos_id = @id";

            var varos = (Varos)varosLista.SelectedItem;

            command.Parameters.AddWithValue("@id", varos.Id);

            using (var reader = command.ExecuteReader())

            {
                while (reader.Read())
                {

                    var nev = reader.GetString("nev");
                    var leiras = reader.GetString("leiras");
                    var ar = reader.GetInt32("ar");
                    var id = reader.GetInt32("id");

                    var latvanyossag = new Latvanyossagok(nev, leiras, ar, id);
                    latvanyossagok.Items.Add(latvanyossag);
                }
            }
        }

        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO varosok (nev, lakossag)
                                VALUES (@nev,@lakossag);";
            cmd.Parameters.AddWithValue("@nev", tbVarosNev.Text);
            cmd.Parameters.AddWithValue("@lakossag", ndLakossagSzama.Text);

            cmd.ExecuteNonQuery();

            varosLista.Items.Clear();
            Adatoklistazas();
        }

        private void btnLatvanyossagFelv_Click(object sender, EventArgs e)
        {
            if (varosLista.SelectedItem == null || tbLatvanyossagNev.Text=="" || tbLeiras.Text =="")
            {
                MessageBox.Show("Hiba! Minden mezőt kötelező kitölteni!");
            }
            else
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO latvanyossagok
                                    (nev, leiras, ar, varos_id)
                                  VALUES 
                                    (
                                     @nev,@leiras,@ar,
                                     (SELECT id FROM varosok WHERE nev = @vnev)
                                    );";

                cmd.Parameters.AddWithValue("@nev", tbLatvanyossagNev.Text);
                cmd.Parameters.AddWithValue("@leiras", tbLeiras.Text);
                cmd.Parameters.AddWithValue("@ar", nudAr.Text);

                var n = (Varos)varosLista.SelectedItem;

                cmd.Parameters.AddWithValue("@vnev", n.Nev);

                cmd.ExecuteNonQuery();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE FROM varosok WHERE id = @id;
                                DELETE FROM latvanyossagok WHERE varos_id = @id";

            var varos = (Varos)varosLista.SelectedItem;
            cmd.Parameters.AddWithValue("@id", varos.Id);

            cmd.ExecuteNonQuery();

            varosLista.Items.Clear();
            Adatoklistazas();
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

            var latv = (Latvanyossagok)latvanyossagok.SelectedItem;
            cmd.Parameters.AddWithValue("@id", latv.Id);

            cmd.ExecuteNonQuery();

            latvanyossagok.Items.Clear();
            Adatoklistazas();
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

            var varos = (Varos)varosLista.SelectedItem;
            cmd.Parameters.AddWithValue("@vid", varos.Id);

            cmd.ExecuteNonQuery();

            varosLista.Items.Clear();
            Adatoklistazas();
        }

    }
}
