namespace bookingkrwao
{
    partial class ManageClients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ManageClientgroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addclient = new System.Windows.Forms.Button();
            this.btn_editclient = new System.Windows.Forms.Button();
            this.btn_removeclient = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.clientnames = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.ManageClientgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Clients";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(163, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 31);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(163, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 31);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Firstname";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(163, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(325, 31);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lastname";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(163, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(325, 31);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // ManageClientgroupBox
            // 
            this.ManageClientgroupBox.Controls.Add(this.textBox1);
            this.ManageClientgroupBox.Controls.Add(this.textBox4);
            this.ManageClientgroupBox.Controls.Add(this.label2);
            this.ManageClientgroupBox.Controls.Add(this.label5);
            this.ManageClientgroupBox.Controls.Add(this.label3);
            this.ManageClientgroupBox.Controls.Add(this.textBox3);
            this.ManageClientgroupBox.Controls.Add(this.textBox2);
            this.ManageClientgroupBox.Controls.Add(this.label4);
            this.ManageClientgroupBox.Location = new System.Drawing.Point(234, 75);
            this.ManageClientgroupBox.Name = "ManageClientgroupBox";
            this.ManageClientgroupBox.Size = new System.Drawing.Size(572, 333);
            this.ManageClientgroupBox.TabIndex = 11;
            this.ManageClientgroupBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(812, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 403);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_addclient
            // 
            this.btn_addclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_addclient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addclient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addclient.ForeColor = System.Drawing.Color.White;
            this.btn_addclient.Location = new System.Drawing.Point(12, 429);
            this.btn_addclient.Name = "btn_addclient";
            this.btn_addclient.Size = new System.Drawing.Size(140, 40);
            this.btn_addclient.TabIndex = 13;
            this.btn_addclient.Text = "Add New";
            this.btn_addclient.UseVisualStyleBackColor = false;
            this.btn_addclient.Click += new System.EventHandler(this.btn_addclient_Click);
            // 
            // btn_editclient
            // 
            this.btn_editclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_editclient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editclient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editclient.ForeColor = System.Drawing.Color.White;
            this.btn_editclient.Location = new System.Drawing.Point(192, 429);
            this.btn_editclient.Name = "btn_editclient";
            this.btn_editclient.Size = new System.Drawing.Size(104, 40);
            this.btn_editclient.TabIndex = 14;
            this.btn_editclient.Text = "Edit";
            this.btn_editclient.UseVisualStyleBackColor = false;
            this.btn_editclient.Click += new System.EventHandler(this.btn_editclient_Click);
            // 
            // btn_removeclient
            // 
            this.btn_removeclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_removeclient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_removeclient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removeclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeclient.ForeColor = System.Drawing.Color.White;
            this.btn_removeclient.Location = new System.Drawing.Point(344, 429);
            this.btn_removeclient.Name = "btn_removeclient";
            this.btn_removeclient.Size = new System.Drawing.Size(170, 40);
            this.btn_removeclient.TabIndex = 15;
            this.btn_removeclient.Text = "Remove";
            this.btn_removeclient.UseVisualStyleBackColor = false;
            this.btn_removeclient.Click += new System.EventHandler(this.btn_removeclient_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(565, 429);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(170, 40);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear Fields";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // clientnames
            // 
            this.clientnames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.clientnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnames.ForeColor = System.Drawing.Color.White;
            this.clientnames.FormattingEnabled = true;
            this.clientnames.ItemHeight = 25;
            this.clientnames.Location = new System.Drawing.Point(12, 79);
            this.clientnames.Name = "clientnames";
            this.clientnames.Size = new System.Drawing.Size(216, 329);
            this.clientnames.TabIndex = 17;
            this.clientnames.Click += new System.EventHandler(this.clientnames_Click);
            // 
            // ManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1252, 498);
            this.Controls.Add(this.clientnames);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_removeclient);
            this.Controls.Add(this.btn_editclient);
            this.Controls.Add(this.btn_addclient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ManageClientgroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "ManageClients";
            this.Text = "ManageClients";
            this.Load += new System.EventHandler(this.ManageClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ManageClientgroupBox.ResumeLayout(false);
            this.ManageClientgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox ManageClientgroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addclient;
        private System.Windows.Forms.Button btn_editclient;
        private System.Windows.Forms.Button btn_removeclient;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox clientnames;
    }
}