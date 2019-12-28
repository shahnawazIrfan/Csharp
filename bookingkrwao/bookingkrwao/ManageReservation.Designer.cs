namespace bookingkrwao
{
    partial class ManageReservation
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
            this.reservationslist = new System.Windows.Forms.ListBox();
            this.btn_clearfield = new System.Windows.Forms.Button();
            this.btn_removereservations = new System.Windows.Forms.Button();
            this.btn_editreservations = new System.Windows.Forms.Button();
            this.btn_addreservations = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ManageClientgroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ManageClientgroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservationslist
            // 
            this.reservationslist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.reservationslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationslist.ForeColor = System.Drawing.Color.White;
            this.reservationslist.FormattingEnabled = true;
            this.reservationslist.ItemHeight = 25;
            this.reservationslist.Location = new System.Drawing.Point(9, 80);
            this.reservationslist.Name = "reservationslist";
            this.reservationslist.Size = new System.Drawing.Size(192, 329);
            this.reservationslist.TabIndex = 33;
            this.reservationslist.Click += new System.EventHandler(this.reservationslist_Click);
            // 
            // btn_clearfield
            // 
            this.btn_clearfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_clearfield.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clearfield.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearfield.ForeColor = System.Drawing.Color.White;
            this.btn_clearfield.Location = new System.Drawing.Point(562, 429);
            this.btn_clearfield.Name = "btn_clearfield";
            this.btn_clearfield.Size = new System.Drawing.Size(170, 40);
            this.btn_clearfield.TabIndex = 32;
            this.btn_clearfield.Text = "Clear Fields";
            this.btn_clearfield.UseVisualStyleBackColor = false;
            this.btn_clearfield.Click += new System.EventHandler(this.btn_clearfield_Click);
            // 
            // btn_removereservations
            // 
            this.btn_removereservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_removereservations.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_removereservations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removereservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removereservations.ForeColor = System.Drawing.Color.White;
            this.btn_removereservations.Location = new System.Drawing.Point(341, 429);
            this.btn_removereservations.Name = "btn_removereservations";
            this.btn_removereservations.Size = new System.Drawing.Size(170, 40);
            this.btn_removereservations.TabIndex = 31;
            this.btn_removereservations.Text = "Remove";
            this.btn_removereservations.UseVisualStyleBackColor = false;
            this.btn_removereservations.Click += new System.EventHandler(this.btn_removereservations_Click);
            // 
            // btn_editreservations
            // 
            this.btn_editreservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_editreservations.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editreservations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editreservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editreservations.ForeColor = System.Drawing.Color.White;
            this.btn_editreservations.Location = new System.Drawing.Point(189, 429);
            this.btn_editreservations.Name = "btn_editreservations";
            this.btn_editreservations.Size = new System.Drawing.Size(104, 40);
            this.btn_editreservations.TabIndex = 30;
            this.btn_editreservations.Text = "Edit";
            this.btn_editreservations.UseVisualStyleBackColor = false;
            this.btn_editreservations.Click += new System.EventHandler(this.btn_editreservations_Click);
            // 
            // btn_addreservations
            // 
            this.btn_addreservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_addreservations.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addreservations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addreservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addreservations.ForeColor = System.Drawing.Color.White;
            this.btn_addreservations.Location = new System.Drawing.Point(9, 429);
            this.btn_addreservations.Name = "btn_addreservations";
            this.btn_addreservations.Size = new System.Drawing.Size(140, 40);
            this.btn_addreservations.TabIndex = 29;
            this.btn_addreservations.Text = "Add New";
            this.btn_addreservations.UseVisualStyleBackColor = false;
            this.btn_addreservations.Click += new System.EventHandler(this.btn_addroom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(758, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 403);
            this.dataGridView1.TabIndex = 28;
            // 
            // ManageClientgroupBox
            // 
            this.ManageClientgroupBox.Controls.Add(this.dateTimePicker2);
            this.ManageClientgroupBox.Controls.Add(this.dateTimePicker1);
            this.ManageClientgroupBox.Controls.Add(this.label7);
            this.ManageClientgroupBox.Controls.Add(this.label4);
            this.ManageClientgroupBox.Controls.Add(this.label2);
            this.ManageClientgroupBox.Controls.Add(this.textBox2);
            this.ManageClientgroupBox.Controls.Add(this.label6);
            this.ManageClientgroupBox.Controls.Add(this.textBox1);
            this.ManageClientgroupBox.Controls.Add(this.label5);
            this.ManageClientgroupBox.Controls.Add(this.comboBox2);
            this.ManageClientgroupBox.Controls.Add(this.comboBox1);
            this.ManageClientgroupBox.Controls.Add(this.label3);
            this.ManageClientgroupBox.Location = new System.Drawing.Point(207, 76);
            this.ManageClientgroupBox.Name = "ManageClientgroupBox";
            this.ManageClientgroupBox.Size = new System.Drawing.Size(545, 333);
            this.ManageClientgroupBox.TabIndex = 27;
            this.ManageClientgroupBox.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(226, 272);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(299, 31);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 31);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 33);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "Room Type";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(226, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 31);
            this.textBox2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "ReserveID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(226, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 31);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "ClientID";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(226, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(299, 33);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 33);
            this.comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room No";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 68);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Reservations";
            // 
            // ManageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1248, 493);
            this.Controls.Add(this.reservationslist);
            this.Controls.Add(this.btn_clearfield);
            this.Controls.Add(this.btn_removereservations);
            this.Controls.Add(this.btn_editreservations);
            this.Controls.Add(this.btn_addreservations);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ManageClientgroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservation";
            this.Text = "ManageReservation";
            this.Load += new System.EventHandler(this.ManageReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ManageClientgroupBox.ResumeLayout(false);
            this.ManageClientgroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox reservationslist;
        private System.Windows.Forms.Button btn_clearfield;
        private System.Windows.Forms.Button btn_removereservations;
        private System.Windows.Forms.Button btn_editreservations;
        private System.Windows.Forms.Button btn_addreservations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ManageClientgroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}