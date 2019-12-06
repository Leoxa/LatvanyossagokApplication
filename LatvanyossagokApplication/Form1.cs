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

            conn = new MySqlConnection("server=localhost;Port=3307;Database=latvanyossagokdb;UId=root;Pwd=;");
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
            command.CommandText = @"SELECT nev, leiras, ar, id, varos_id 
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
                    var vid = reader.GetInt32("varos_id");

                    var latvanyossag = new Latvanyossagok(nev, leiras, ar, id, vid);
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
            cmd.CommandText = @"DELETE FROM latvanyossagok WHERE varos_id = @id;";

            var varos = (Varos)varosLista.SelectedItem;
            cmd.Parameters.AddWithValue("@id", varos.Id);

            cmd.ExecuteNonQuery();

            varosLista.Items.Clear();
            Adatoklistazas();
        }


        private void btnDelVaros_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM varosok WHERE id = @id;";

                var varos = (Varos)varosLista.SelectedItem;
                cmd.Parameters.AddWithValue("@id", varos.Id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem lehet törölni! A városhoz tartozik látványosság!");
            }

            varosLista.Items.Clear();
            Adatoklistazas();
        }

        private void btnvarosvalzotatas_Click(object sender, EventArgs e)
        {
            if(varosLista.SelectedItem != null) { 
            var varos = (Varos)varosLista.SelectedItem;
            ModositasForm f3 = new ModositasForm(varos.Id, varos.Nev, varos.Lakossag);
            f3.ShowDialog();}
        }

        private void btnlatvvaltoztatas_Click(object sender, EventArgs e)
        {
            if (latvanyossagok.SelectedItem !=null)
            {
                Latvanyossagok lat = (Latvanyossagok)latvanyossagok.SelectedItem;
                Form2 f2 = new Form2(lat.Id, lat.Nev, lat.Leir, lat.Ar);
                f2.ShowDialog();
            }
            
        }
    }
}
