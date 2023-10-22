using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pfa
{
    public partial class adminpage : Form
    {


        public adminpage()
        {
            InitializeComponent();
        }

        int position = -1, Id;
        bool check = false;

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_list_Click(sender, e);

            {
                try
                {
                    if (check == true)
                        return;

                    if (id.Text.Trim().Equals("") || name.Text.Trim().Equals("") || description.Text.Trim().Equals("") || qt.Text.Trim().Equals("") || price.Text.Trim().Equals("") || picture.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("veuillez saisir tous les champs informations sur le nouveau produit ", " error", MessageBoxButtons.OK);
                        return;
                    }

                    bd db = new bd();
                    string query = "INSERT INTO produit  VALUES (@id,@nom,@description,@Quantité,@prix,@img)";
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());


                    cmd.Parameters.AddWithValue("@id", this.id.Text.Trim());
                    cmd.Parameters.AddWithValue("@nom", this.name.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", this.description.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quantité", this.qt.Text.Trim());
                    cmd.Parameters.AddWithValue("@prix", this.price.Text.Trim());
                    cmd.Parameters.AddWithValue("@img", this.picture.Text.Trim());

                    if (db.GetConnection().State == ConnectionState.Open)

                        db.GetConnection().Close();
                    db.GetConnection().Open();
                    int a = cmd.ExecuteNonQuery();
                    this.dataGrid.Rows.Add(this.id.Text.Trim(), this.name.Text.Trim(), this.description.Text.Trim(), this.qt.Text.Trim(), this.price.Text.Trim(), this.picture.Text.Trim());
                    MessageBox.Show(a + "ligne(s) affectée ");
                    db.GetConnection().Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }












        }

        private void adminpage_Load(object sender, EventArgs e)
        {
            btn_list_Click(sender,e);

            bd db = new bd();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string Query = "SELECT*FROM produit ORDER BY id_p;";

            db.GetConnection().Open();

            MySqlCommand cmd = new MySqlCommand(Query, db.GetConnection());

            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows == true)
            {
                this.dataGrid.Rows.Clear();
                while (rd.Read())
                {
                    this.dataGrid.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);
                }
                adapter.SelectCommand = cmd;
                rd.Close();
                db.GetConnection().Close();
            }
            else
            {
                MessageBox.Show("le table product est vide!!");
            }

        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            btn_list_Click(sender, e);

            if (id.Text.Trim().Equals("") || name.Text.Trim().Equals("") || description.Text.Trim().Equals("") || qt.Text.Trim().Equals("") || price.Text.Trim().Equals("") || picture.Text.Trim().Equals(""))
            {
                MessageBox.Show("veuillez saisir tous les champs informations sur le nouveau produit ", " error", MessageBoxButtons.OK);
                return;
            }

            bd db = new bd();


            string query = "UPDATE produit SET  id_p=@id ,nom_p=@nom,description=@description,Quantité=@Quantité,prix=@prix,img=@img where id_p=@id1";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@id", this.id.Text.Trim());
            cmd.Parameters.AddWithValue("@nom", this.name.Text.Trim());
            cmd.Parameters.AddWithValue("@description", this.description.Text.Trim());
            cmd.Parameters.AddWithValue("@Quantité", this.qt.Text.Trim());
            cmd.Parameters.AddWithValue("@prix", this.price.Text.Trim());
            cmd.Parameters.AddWithValue("@img", this.picture.Text.Trim());
            cmd.Parameters.AddWithValue("@id1", this.id.Text.Trim());

            db.GetConnection().Open();
            cmd.ExecuteNonQuery();
            db.GetConnection().Close();


            MessageBox.Show("le produit est bien modifié", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_list_Click(object sender, EventArgs e)
        {


            using (MySqlConnection connection = new MySqlConnection("host=localhost;port=3306;user=root;password=;database=pfa"))
            {
                string query = "SELECT * FROM produit; ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    this.dataGrid.Rows.Clear();
                    while (rd.Read())
                    {
                        this.dataGrid.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);

                    }
                    connection.Close();
                }
                else MessageBox.Show("le table vide");

            }








        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            string x = id.Text;

           

           
            bd db = new bd();

            DialogResult dialog = MessageBox.Show("étez-vous sure supprimez", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return ;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = db.GetConnection();
            cmd.CommandText = "delete from produit where id_p = @id";
            cmd.Parameters.AddWithValue("@id", x);

            

            db.GetConnection().Open();
            cmd.ExecuteNonQuery();
            if (this.dataGrid.CurrentRow != null)
            {
                int position = this.dataGrid.CurrentRow.Index;
                this.dataGrid.Rows.RemoveAt(position);
            }

            MessageBox.Show("le produit a été bien supprimez", "suppresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.GetConnection().Close();
        }


    }
    }

    


