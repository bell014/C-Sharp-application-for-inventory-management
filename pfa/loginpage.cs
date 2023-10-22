using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace pfa
{
    public partial class page1 : Form
    {

        MySqlConnection connexion;


        public page1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {





        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            email.Text = "";
            password.Text = "";

        }

        private void btn_login_Click(object sender, EventArgs e)
        {


            try
            {
                bd db = new bd();

                String mail = email.Text;
                String pass = password.Text;

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `admin` WHERE `nom_admin` = @user and `mdp_admin` = @pass;", db.getConnection());

                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = mail;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

                adapter.SelectCommand = command;

                adapter.Fill(table);
                if (mail.Trim().Equals("") || mail.Trim().Equals("Pseudo ou Email"))
                {
                    MessageBox.Show("Entrez le pseudo ou l'email SVP!!!", "Pseudo Vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass.Trim().Equals("") || pass.Trim().Equals("Mot de passe"))
                {
                    MessageBox.Show("Entrez le mot de passe SVP!!!", "Mot de passe Vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // check if the user exists or not
                    if (table.Rows.Count > 0)
                    {

                        this.Hide();
                        adminpage admin = new adminpage();
                        admin.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalide Pseudo/Email Ou Password", "Données invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de la base de données: " + ex.Message, "Données invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
    }

