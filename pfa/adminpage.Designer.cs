namespace pfa
{
    partial class adminpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.qt = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.id_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_list = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_add.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(247, 537);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(158, 45);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add product";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(668, 537);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(172, 45);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete product";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modif
            // 
            this.btn_modif.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_modif.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif.Location = new System.Drawing.Point(470, 537);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(159, 45);
            this.btn_modif.TabIndex = 2;
            this.btn_modif.Text = "Mofify product";
            this.btn_modif.UseVisualStyleBackColor = false;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(76, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(72, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "product_picture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(72, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product_Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(76, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(76, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(72, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Description";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(247, 112);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(136, 22);
            this.id.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(247, 179);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(136, 22);
            this.name.TabIndex = 7;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(247, 245);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(136, 22);
            this.description.TabIndex = 8;
            // 
            // qt
            // 
            this.qt.Location = new System.Drawing.Point(247, 317);
            this.qt.Name = "qt";
            this.qt.Size = new System.Drawing.Size(136, 22);
            this.qt.TabIndex = 9;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(247, 377);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(136, 22);
            this.price.TabIndex = 10;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(247, 442);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(136, 22);
            this.picture.TabIndex = 11;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_p,
            this.nom_p,
            this.Des,
            this.Quantité,
            this.prix,
            this.img});
            this.dataGrid.Location = new System.Drawing.Point(389, 112);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(747, 352);
            this.dataGrid.TabIndex = 12;
            // 
            // id_p
            // 
            this.id_p.HeaderText = "ip_p";
            this.id_p.MinimumWidth = 6;
            this.id_p.Name = "id_p";
            this.id_p.ReadOnly = true;
            this.id_p.Width = 125;
            // 
            // nom_p
            // 
            this.nom_p.HeaderText = "nom_p";
            this.nom_p.MinimumWidth = 6;
            this.nom_p.Name = "nom_p";
            this.nom_p.ReadOnly = true;
            this.nom_p.Width = 125;
            // 
            // Des
            // 
            this.Des.HeaderText = "description";
            this.Des.MinimumWidth = 6;
            this.Des.Name = "Des";
            this.Des.ReadOnly = true;
            this.Des.Width = 125;
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.MinimumWidth = 6;
            this.Quantité.Name = "Quantité";
            this.Quantité.ReadOnly = true;
            this.Quantité.Width = 125;
            // 
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.MinimumWidth = 6;
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            this.prix.Width = 125;
            // 
            // img
            // 
            this.img.HeaderText = "img";
            this.img.MinimumWidth = 6;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Width = 125;
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_list.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_list.FlatAppearance.BorderSize = 0;
            this.btn_list.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_list.Location = new System.Drawing.Point(873, 537);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(156, 45);
            this.btn_list.TabIndex = 13;
            this.btn_list.Text = "LIST product";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // adminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = global::pfa.Properties.Resources.republic_of_gamers_asus_rog_cityscape_neon_1280x720_129;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 620);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.price);
            this.Controls.Add(this.qt);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Name = "adminpage";
            this.Text = "adminpage";
            this.Load += new System.EventHandler(this.adminpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox qt;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox picture;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
        private System.Windows.Forms.Button btn_list;
    }
}