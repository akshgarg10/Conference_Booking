namespace WinFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mybox = new System.Windows.Forms.ComboBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.book1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.load_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "SLOT BOOKING";
            // 
            // mybox
            // 
            this.mybox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mybox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mybox.FormattingEnabled = true;
            this.mybox.Location = new System.Drawing.Point(56, 71);
            this.mybox.Name = "mybox";
            this.mybox.Size = new System.Drawing.Size(153, 23);
            this.mybox.TabIndex = 2;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "MM/dd/yyyy hh:mm:tt";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp1.Location = new System.Drawing.Point(116, 118);
            this.dtp1.MaxDate = new System.DateTime(2030, 1, 15, 0, 0, 0, 0);
            this.dtp1.MinDate = new System.DateTime(2020, 1, 15, 0, 0, 0, 0);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(216, 23);
            this.dtp1.TabIndex = 3;
            this.dtp1.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            this.dtp1.Visible = false;
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "MM/dd/yyyy hh:mm:tt";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(116, 159);
            this.dtp2.MaxDate = new System.DateTime(2030, 1, 15, 0, 0, 0, 0);
            this.dtp2.MinDate = new System.DateTime(2020, 1, 15, 0, 0, 0, 0);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(216, 23);
            this.dtp2.TabIndex = 4;
            this.dtp2.Value = new System.DateTime(2023, 7, 15, 0, 0, 0, 0);
            this.dtp2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Date";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Date";
            this.label3.Visible = false;
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.show.Location = new System.Drawing.Point(242, 188);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(90, 27);
            this.show.TabIndex = 7;
            this.show.Text = "Check";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // book1
            // 
            this.book1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.book1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.book1.Location = new System.Drawing.Point(242, 221);
            this.book1.Name = "book1";
            this.book1.Size = new System.Drawing.Size(91, 42);
            this.book1.TabIndex = 8;
            this.book1.Text = "Book";
            this.book1.UseVisualStyleBackColor = false;
            this.book1.Click += new System.EventHandler(this.book1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(318, 220);
            this.dataGridView1.TabIndex = 9;
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.load_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.load_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.load_btn.FlatAppearance.BorderSize = 2;
            this.load_btn.Location = new System.Drawing.Point(357, 23);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(108, 28);
            this.load_btn.TabIndex = 10;
            this.load_btn.Text = "Load Table";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.Actions_application_exit_icon;
            this.pictureBox1.Location = new System.Drawing.Point(642, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Location = new System.Drawing.Point(520, 30);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(57, 15);
            this.timer_lbl.TabIndex = 12;
            this.timer_lbl.Text = "DateTime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(471, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 298);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.book1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.mybox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SLOTS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox mybox;
        private DateTimePicker dtp1;
        private DateTimePicker dtp2;
        private Label label2;
        private Label label3;
        private Button show;
        private Button book1;
        private DataGridView dataGridView1;
        private Button load_btn;
        private PictureBox pictureBox1;
        private Label timer_lbl;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
    }
}