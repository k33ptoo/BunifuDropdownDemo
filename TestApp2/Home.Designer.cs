namespace TestApp2
{
    partial class Home
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_db = new System.Windows.Forms.Button();
            this.btn_array = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_dictionary = new System.Windows.Forms.Button();
            this.btn_model = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuDropdown1.BorderRadius = 1;
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = false;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Purple;
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.Purple;
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.Purple;
            this.bunifuDropdown1.ItemHeight = 30;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.LightSlateGray;
            this.bunifuDropdown1.Location = new System.Drawing.Point(40, 106);
            this.bunifuDropdown1.MinimumSize = new System.Drawing.Size(48, 0);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(300, 36);
            this.bunifuDropdown1.TabIndex = 0;
            this.bunifuDropdown1.Text = null;
            // 
            // btn_db
            // 
            this.btn_db.Location = new System.Drawing.Point(12, 34);
            this.btn_db.Name = "btn_db";
            this.btn_db.Size = new System.Drawing.Size(75, 23);
            this.btn_db.TabIndex = 1;
            this.btn_db.Text = "db";
            this.btn_db.UseVisualStyleBackColor = true;
            this.btn_db.Click += new System.EventHandler(this.btn_db_Click);
            // 
            // btn_array
            // 
            this.btn_array.Location = new System.Drawing.Point(12, 78);
            this.btn_array.Name = "btn_array";
            this.btn_array.Size = new System.Drawing.Size(75, 23);
            this.btn_array.TabIndex = 2;
            this.btn_array.Text = "array";
            this.btn_array.UseVisualStyleBackColor = true;
            this.btn_array.Click += new System.EventHandler(this.btn_array_Click);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(128, 34);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(75, 23);
            this.btn_list.TabIndex = 3;
            this.btn_list.Text = "list";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_dictionary
            // 
            this.btn_dictionary.Location = new System.Drawing.Point(128, 78);
            this.btn_dictionary.Name = "btn_dictionary";
            this.btn_dictionary.Size = new System.Drawing.Size(75, 23);
            this.btn_dictionary.TabIndex = 4;
            this.btn_dictionary.Text = "dictionary";
            this.btn_dictionary.UseVisualStyleBackColor = true;
            this.btn_dictionary.Click += new System.EventHandler(this.btn_dictionary_Click);
            // 
            // btn_model
            // 
            this.btn_model.Location = new System.Drawing.Point(237, 34);
            this.btn_model.Name = "btn_model";
            this.btn_model.Size = new System.Drawing.Size(75, 23);
            this.btn_model.TabIndex = 5;
            this.btn_model.Text = "model";
            this.btn_model.UseVisualStyleBackColor = true;
            this.btn_model.Click += new System.EventHandler(this.btn_model_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "BunifuDropdown Demo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 75);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_model);
            this.groupBox1.Controls.Add(this.btn_dictionary);
            this.groupBox1.Controls.Add(this.btn_list);
            this.groupBox1.Controls.Add(this.btn_array);
            this.groupBox1.Controls.Add(this.btn_db);
            this.groupBox1.Location = new System.Drawing.Point(28, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuDropdown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.Text = "Bunifu Tests";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Button btn_db;
        private System.Windows.Forms.Button btn_array;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_dictionary;
        private System.Windows.Forms.Button btn_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

