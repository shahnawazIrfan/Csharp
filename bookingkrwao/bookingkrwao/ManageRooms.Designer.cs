namespace bookingkrwao
{
    partial class ManageRooms
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
            this.roomnames = new System.Windows.Forms.ListBox();
            this.btn_clearfield = new System.Windows.Forms.Button();
            this.btn_removeroom = new System.Windows.Forms.Button();
            this.btn_editroom = new System.Windows.Forms.Button();
            this.btn_addroom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ManageClientgroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ManageClientgroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomnames
            // 
            this.roomnames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.roomnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomnames.ForeColor = System.Drawing.Color.White;
            this.roomnames.FormattingEnabled = true;
            this.roomnames.ItemHeight = 25;
            this.roomnames.Location = new System.Drawing.Point(12, 88);
            this.roomnames.Name = "roomnames";
            this.roomnames.Size = new System.Drawing.Size(192, 329);
            this.roomnames.TabIndex = 25;
            this.roomnames.Click += new System.EventHandler(this.roomnames_Click);
            // 
            // btn_clearfield
            // 
            this.btn_clearfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_clearfield.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clearfield.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearfield.ForeColor = System.Drawing.Color.White;
            this.btn_clearfield.Location = new System.Drawing.Point(565, 438);
            this.btn_clearfield.Name = "btn_clearfield";
            this.btn_clearfield.Size = new System.Drawing.Size(170, 40);
            this.btn_clearfield.TabIndex = 24;
            this.btn_clearfield.Text = "Clear Fields";
            this.btn_clearfield.UseVisualStyleBackColor = false;
            this.btn_clearfield.Click += new System.EventHandler(this.btn_clearfield_Click);
            // 
            // btn_removeroom
            // 
            this.btn_removeroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_removeroom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_removeroom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removeroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeroom.ForeColor = System.Drawing.Color.White;
            this.btn_removeroom.Location = new System.Drawing.Point(344, 438);
            this.btn_removeroom.Name = "btn_removeroom";
            this.btn_removeroom.Size = new System.Drawing.Size(170, 40);
            this.btn_removeroom.TabIndex = 23;
            this.btn_removeroom.Text = "Remove";
            this.btn_removeroom.UseVisualStyleBackColor = false;
            this.btn_removeroom.Click += new System.EventHandler(this.btn_removeroom_Click);
            // 
            // btn_editroom
            // 
            this.btn_editroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_editroom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editroom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editroom.ForeColor = System.Drawing.Color.White;
            this.btn_editroom.Location = new System.Drawing.Point(192, 438);
            this.btn_editroom.Name = "btn_editroom";
            this.btn_editroom.Size = new System.Drawing.Size(104, 40);
            this.btn_editroom.TabIndex = 22;
            this.btn_editroom.Text = "Edit";
            this.btn_editroom.UseVisualStyleBackColor = false;
            this.btn_editroom.Click += new System.EventHandler(this.btn_editroom_Click);
            // 
            // btn_addroom
            // 
            this.btn_addroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(42)))));
            this.btn_addroom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addroom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addroom.ForeColor = System.Drawing.Color.White;
            this.btn_addroom.Location = new System.Drawing.Point(12, 438);
            this.btn_addroom.Name = "btn_addroom";
            this.btn_addroom.Size = new System.Drawing.Size(140, 40);
            this.btn_addroom.TabIndex = 21;
            this.btn_addroom.Text = "Add New";
            this.btn_addroom.UseVisualStyleBackColor = false;
            this.btn_addroom.Click += new System.EventHandler(this.btn_addroom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(812, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 403);
            this.dataGridView1.TabIndex = 20;
            // 
            // ManageClientgroupBox
            // 
            this.ManageClientgroupBox.Controls.Add(this.radioNo);
            this.ManageClientgroupBox.Controls.Add(this.radioYes);
            this.ManageClientgroupBox.Controls.Add(this.comboBox1);
            this.ManageClientgroupBox.Controls.Add(this.textBox1);
            this.ManageClientgroupBox.Controls.Add(this.label2);
            this.ManageClientgroupBox.Controls.Add(this.label5);
            this.ManageClientgroupBox.Controls.Add(this.label3);
            this.ManageClientgroupBox.Controls.Add(this.textBox3);
            this.ManageClientgroupBox.Controls.Add(this.label4);
            this.ManageClientgroupBox.Location = new System.Drawing.Point(210, 84);
            this.ManageClientgroupBox.Name = "ManageClientgroupBox";
            this.ManageClientgroupBox.Size = new System.Drawing.Size(596, 333);
            this.ManageClientgroupBox.TabIndex = 19;
            this.ManageClientgroupBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 33);
            this.comboBox1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(177, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 31);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Free";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room Type";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(177, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(299, 31);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 68);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Rooms";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYes.ForeColor = System.Drawing.Color.White;
            this.radioYes.Location = new System.Drawing.Point(177, 210);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(68, 29);
            this.radioYes.TabIndex = 12;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNo.ForeColor = System.Drawing.Color.White;
            this.radioNo.Location = new System.Drawing.Point(340, 210);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(57, 29);
            this.radioNo.TabIndex = 13;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(170)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1254, 496);
            this.Controls.Add(this.roomnames);
            this.Controls.Add(this.btn_clearfield);
            this.Controls.Add(this.btn_removeroom);
            this.Controls.Add(this.btn_editroom);
            this.Controls.Add(this.btn_addroom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ManageClientgroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRooms";
            this.Text = "ManageRooms";
            this.Load += new System.EventHandler(this.ManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ManageClientgroupBox.ResumeLayout(false);
            this.ManageClientgroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox roomnames;
        private System.Windows.Forms.Button btn_clearfield;
        private System.Windows.Forms.Button btn_removeroom;
        private System.Windows.Forms.Button btn_editroom;
        private System.Windows.Forms.Button btn_addroom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ManageClientgroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioYes;
    }
}