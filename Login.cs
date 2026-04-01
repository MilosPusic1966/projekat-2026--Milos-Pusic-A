using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projekat_2026__Milos_Pusic_A
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Milos Pusic
            // drugi red
            comboBox1.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Morate uneti email i lozinku!");
            }
            else
            {
                string lokacija = comboBox1.SelectedItem.ToString();
                SqlConnection veza = konekcija.Connect(lokacija);
                DataTable podaci = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM korisnik WHERE email='"+txtName.Text+"'", veza);
                adapter.Fill(podaci);
                int count = podaci.Rows.Count;
                if (count == 0)
                {
                    MessageBox.Show("Email ne postoji");
                }
                else 
                {
                    /*
                    string prvi = podaci.Rows[0]["pass"].ToString();
                    string drugi = txtPass.Text;
                    bool isti = prvi.Equals(drugi);
                    bool jednaki = String.Equals(prvi, drugi);
                    int poredak = String.Compare(prvi, drugi);
                    */

                    if (podaci.Rows[0]["pass"].ToString()==txtPass.Text)
                    {
                        MessageBox.Show("Uspesno ste se ulogovali");
                        this.Hide();
                        Glavna forma = new Glavna();
                        forma.Show();
                    }
                    else
                    {
                        MessageBox.Show("Pogresna lozinka");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.user = comboBox1.SelectedItem.ToString();
            this.Hide();
            SignUp nova = new SignUp();
            nova.Show();
            this.Show();
        }
    }
}
