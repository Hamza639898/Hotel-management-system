namespace hotel_mangment_systeam
{
    partial class booking
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.total = new System.Windows.Forms.TextBox();
            this.btnsa = new System.Windows.Forms.Button();
            this.btans = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.datein = new System.Windows.Forms.DateTimePicker();
            this.dateout = new System.Windows.Forms.DateTimePicker();
            this.data_table = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bid = new System.Windows.Forms.Label();
            this.la1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "guest";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "cheack out Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cheac in Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Guest";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 28);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "room";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(152, 341);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(238, 26);
            this.total.TabIndex = 7;
            // 
            // btnsa
            // 
            this.btnsa.Location = new System.Drawing.Point(12, 422);
            this.btnsa.Name = "btnsa";
            this.btnsa.Size = new System.Drawing.Size(90, 36);
            this.btnsa.TabIndex = 8;
            this.btnsa.Text = "Insert";
            this.btnsa.UseVisualStyleBackColor = true;
            this.btnsa.Click += new System.EventHandler(this.btns_Click);
            // 
            // btans
            // 
            this.btans.Location = new System.Drawing.Point(152, 422);
            this.btans.Name = "btans";
            this.btans.Size = new System.Drawing.Size(96, 36);
            this.btans.TabIndex = 9;
            this.btans.Text = "Update";
            this.btans.UseVisualStyleBackColor = true;
            this.btans.Click += new System.EventHandler(this.btans_Click);
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(300, 422);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(90, 36);
            this.btnd.TabIndex = 10;
            this.btnd.Text = "Delete";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(20, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "price";
            // 
            // datein
            // 
            this.datein.Location = new System.Drawing.Point(156, 231);
            this.datein.Name = "datein";
            this.datein.Size = new System.Drawing.Size(225, 26);
            this.datein.TabIndex = 15;
            this.datein.ValueChanged += new System.EventHandler(this.datein_ValueChanged);
            // 
            // dateout
            // 
            this.dateout.Location = new System.Drawing.Point(173, 282);
            this.dateout.Name = "dateout";
            this.dateout.Size = new System.Drawing.Size(217, 26);
            this.dateout.TabIndex = 16;
            // 
            // data_table
            // 
            this.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_table.Location = new System.Drawing.Point(486, 155);
            this.data_table.Name = "data_table";
            this.data_table.RowTemplate.Height = 28;
            this.data_table.Size = new System.Drawing.Size(787, 425);
            this.data_table.TabIndex = 17;
            this.data_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_table_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(524, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 40);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search";
            // 
            // bid
            // 
            this.bid.AutoSize = true;
            this.bid.Location = new System.Drawing.Point(339, 9);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(51, 20);
            this.bid.TabIndex = 20;
            this.bid.Text = "label7";
            this.bid.Click += new System.EventHandler(this.bid_Click);
            // 
            // la1
            // 
            this.la1.AutoSize = true;
            this.la1.Location = new System.Drawing.Point(468, 30);
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(51, 20);
            this.la1.TabIndex = 21;
            this.la1.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(431, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 46);
            this.label7.TabIndex = 22;
            this.label7.Text = "Home / Bookin";
            // 
            // booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1275, 573);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.la1);
            this.Controls.Add(this.bid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.data_table);
            this.Controls.Add(this.dateout);
            this.Controls.Add(this.datein);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btans);
            this.Controls.Add(this.btnsa);
            this.Controls.Add(this.total);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "booking";
            this.Text = "booking";
            this.Load += new System.EventHandler(this.booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button btnsa;
        private System.Windows.Forms.Button btans;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datein;
        private System.Windows.Forms.DateTimePicker dateout;
        private System.Windows.Forms.DataGridView data_table;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bid;
        private System.Windows.Forms.Label la1;
        private System.Windows.Forms.Label label7;
    }
}