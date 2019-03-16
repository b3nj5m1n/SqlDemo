namespace SqlDemo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_Add = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UID = new System.Windows.Forms.TextBox();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grp_Edit = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_ID_1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_UID_1 = new System.Windows.Forms.TextBox();
            this.txt_Adress_1 = new System.Windows.Forms.TextBox();
            this.txt_LastName_1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_FirstName_1 = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_CreateBackup = new System.Windows.Forms.Button();
            this.btn_LoadBackup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ExecuteCmd = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grp_Add.SuspendLayout();
            this.grp_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Add
            // 
            this.grp_Add.Controls.Add(this.label5);
            this.grp_Add.Controls.Add(this.label4);
            this.grp_Add.Controls.Add(this.label2);
            this.grp_Add.Controls.Add(this.txt_UID);
            this.grp_Add.Controls.Add(this.txt_Adress);
            this.grp_Add.Controls.Add(this.txt_LastName);
            this.grp_Add.Controls.Add(this.label1);
            this.grp_Add.Controls.Add(this.txt_FirstName);
            this.grp_Add.Controls.Add(this.btn_Add);
            this.grp_Add.ForeColor = System.Drawing.Color.White;
            this.grp_Add.Location = new System.Drawing.Point(6, 8);
            this.grp_Add.Name = "grp_Add";
            this.grp_Add.Size = new System.Drawing.Size(316, 250);
            this.grp_Add.TabIndex = 0;
            this.grp_Add.TabStop = false;
            this.grp_Add.Text = "Add Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "RFID";
            // 
            // txt_UID
            // 
            this.txt_UID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_UID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UID.ForeColor = System.Drawing.Color.White;
            this.txt_UID.Location = new System.Drawing.Point(85, 149);
            this.txt_UID.Name = "txt_UID";
            this.txt_UID.Size = new System.Drawing.Size(225, 20);
            this.txt_UID.TabIndex = 6;
            // 
            // txt_Adress
            // 
            this.txt_Adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_Adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Adress.ForeColor = System.Drawing.Color.White;
            this.txt_Adress.Location = new System.Drawing.Point(85, 123);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(225, 20);
            this.txt_Adress.TabIndex = 5;
            // 
            // txt_LastName
            // 
            this.txt_LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LastName.ForeColor = System.Drawing.Color.White;
            this.txt_LastName.Location = new System.Drawing.Point(85, 97);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(225, 20);
            this.txt_LastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FirstName.ForeColor = System.Drawing.Color.White;
            this.txt_FirstName.Location = new System.Drawing.Point(85, 71);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(225, 20);
            this.txt_FirstName.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(3, 224);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(310, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // grp_Edit
            // 
            this.grp_Edit.Controls.Add(this.btn_Delete);
            this.grp_Edit.Controls.Add(this.btn_Refresh);
            this.grp_Edit.Controls.Add(this.comboBox1);
            this.grp_Edit.Controls.Add(this.txt_ID_1);
            this.grp_Edit.Controls.Add(this.label6);
            this.grp_Edit.Controls.Add(this.label7);
            this.grp_Edit.Controls.Add(this.label8);
            this.grp_Edit.Controls.Add(this.label9);
            this.grp_Edit.Controls.Add(this.txt_UID_1);
            this.grp_Edit.Controls.Add(this.txt_Adress_1);
            this.grp_Edit.Controls.Add(this.txt_LastName_1);
            this.grp_Edit.Controls.Add(this.label10);
            this.grp_Edit.Controls.Add(this.txt_FirstName_1);
            this.grp_Edit.Controls.Add(this.btn_Update);
            this.grp_Edit.ForeColor = System.Drawing.Color.White;
            this.grp_Edit.Location = new System.Drawing.Point(6, 264);
            this.grp_Edit.Name = "grp_Edit";
            this.grp_Edit.Size = new System.Drawing.Size(316, 250);
            this.grp_Edit.TabIndex = 12;
            this.grp_Edit.TabStop = false;
            this.grp_Edit.Text = "Edit, Delete";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(3, 201);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(310, 23);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(252, 26);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(58, 23);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_ID_1
            // 
            this.txt_ID_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_ID_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID_1.ForeColor = System.Drawing.Color.White;
            this.txt_ID_1.Location = new System.Drawing.Point(85, 64);
            this.txt_ID_1.Name = "txt_ID_1";
            this.txt_ID_1.Size = new System.Drawing.Size(68, 20);
            this.txt_ID_1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Adress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "index";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "RFID";
            // 
            // txt_UID_1
            // 
            this.txt_UID_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_UID_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UID_1.ForeColor = System.Drawing.Color.White;
            this.txt_UID_1.Location = new System.Drawing.Point(85, 175);
            this.txt_UID_1.Name = "txt_UID_1";
            this.txt_UID_1.Size = new System.Drawing.Size(225, 20);
            this.txt_UID_1.TabIndex = 6;
            // 
            // txt_Adress_1
            // 
            this.txt_Adress_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_Adress_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Adress_1.ForeColor = System.Drawing.Color.White;
            this.txt_Adress_1.Location = new System.Drawing.Point(85, 149);
            this.txt_Adress_1.Name = "txt_Adress_1";
            this.txt_Adress_1.Size = new System.Drawing.Size(225, 20);
            this.txt_Adress_1.TabIndex = 5;
            // 
            // txt_LastName_1
            // 
            this.txt_LastName_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_LastName_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LastName_1.ForeColor = System.Drawing.Color.White;
            this.txt_LastName_1.Location = new System.Drawing.Point(85, 123);
            this.txt_LastName_1.Name = "txt_LastName_1";
            this.txt_LastName_1.Size = new System.Drawing.Size(225, 20);
            this.txt_LastName_1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "First Name";
            // 
            // txt_FirstName_1
            // 
            this.txt_FirstName_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_FirstName_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FirstName_1.ForeColor = System.Drawing.Color.White;
            this.txt_FirstName_1.Location = new System.Drawing.Point(85, 97);
            this.txt_FirstName_1.Name = "txt_FirstName_1";
            this.txt_FirstName_1.Size = new System.Drawing.Size(225, 20);
            this.txt_FirstName_1.TabIndex = 1;
            // 
            // btn_Update
            // 
            this.btn_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(3, 224);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(310, 23);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(395, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(537, 715);
            this.dataGridView.TabIndex = 13;
            // 
            // btn_CreateBackup
            // 
            this.btn_CreateBackup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CreateBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateBackup.ForeColor = System.Drawing.Color.White;
            this.btn_CreateBackup.Location = new System.Drawing.Point(0, 692);
            this.btn_CreateBackup.Name = "btn_CreateBackup";
            this.btn_CreateBackup.Size = new System.Drawing.Size(395, 23);
            this.btn_CreateBackup.TabIndex = 15;
            this.btn_CreateBackup.Text = "Create Backup";
            this.btn_CreateBackup.UseVisualStyleBackColor = true;
            this.btn_CreateBackup.Click += new System.EventHandler(this.btn_CreateBackup_Click);
            // 
            // btn_LoadBackup
            // 
            this.btn_LoadBackup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_LoadBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadBackup.ForeColor = System.Drawing.Color.White;
            this.btn_LoadBackup.Location = new System.Drawing.Point(0, 669);
            this.btn_LoadBackup.Name = "btn_LoadBackup";
            this.btn_LoadBackup.Size = new System.Drawing.Size(395, 23);
            this.btn_LoadBackup.TabIndex = 16;
            this.btn_LoadBackup.Text = "Load Backup";
            this.btn_LoadBackup.UseVisualStyleBackColor = true;
            this.btn_LoadBackup.Click += new System.EventHandler(this.btn_LoadBackup_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "ExecuteCommand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ExecuteCmd
            // 
            this.txt_ExecuteCmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_ExecuteCmd.ForeColor = System.Drawing.Color.White;
            this.txt_ExecuteCmd.Location = new System.Drawing.Point(0, 520);
            this.txt_ExecuteCmd.Name = "txt_ExecuteCmd";
            this.txt_ExecuteCmd.Size = new System.Drawing.Size(389, 96);
            this.txt_ExecuteCmd.TabIndex = 18;
            this.txt_ExecuteCmd.Text = "";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(395, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Drop Database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(932, 715);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_ExecuteCmd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_LoadBackup);
            this.Controls.Add(this.btn_CreateBackup);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.grp_Edit);
            this.Controls.Add(this.grp_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_Add.ResumeLayout(false);
            this.grp_Add.PerformLayout();
            this.grp_Edit.ResumeLayout(false);
            this.grp_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UID;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox grp_Edit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_ID_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_UID_1;
        private System.Windows.Forms.TextBox txt_Adress_1;
        private System.Windows.Forms.TextBox txt_LastName_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_FirstName_1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_CreateBackup;
        private System.Windows.Forms.Button btn_LoadBackup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txt_ExecuteCmd;
        private System.Windows.Forms.Button button2;
    }
}

