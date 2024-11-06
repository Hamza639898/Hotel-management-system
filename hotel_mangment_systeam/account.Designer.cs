namespace hotel_mangment_systeam
{
    partial class account
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsa = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.table_data = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_data)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 26);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "account_instation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "account_name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "balance";
            // 
            // btnsa
            // 
            this.btnsa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsa.Location = new System.Drawing.Point(12, 333);
            this.btnsa.Name = "btnsa";
            this.btnsa.Size = new System.Drawing.Size(114, 42);
            this.btnsa.TabIndex = 6;
            this.btnsa.Text = "inseart";
            this.btnsa.UseVisualStyleBackColor = true;
            this.btnsa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnup
            // 
            this.btnup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnup.Location = new System.Drawing.Point(172, 333);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(120, 42);
            this.btnup.TabIndex = 7;
            this.btnup.Text = "update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnd
            // 
            this.btnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnd.Location = new System.Drawing.Point(342, 333);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(127, 42);
            this.btnd.TabIndex = 8;
            this.btnd.Text = "Delete";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.button3_Click);
            // 
            // table_data
            // 
            this.table_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_data.Location = new System.Drawing.Point(537, 183);
            this.table_data.Name = "table_data";
            this.table_data.RowTemplate.Height = 28;
            this.table_data.Size = new System.Drawing.Size(652, 389);
            this.table_data.TabIndex = 9;
            this.table_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(639, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(249, 26);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(129, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(334, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 46);
            this.label7.TabIndex = 23;
            this.label7.Text = "Home / Account";
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1201, 576);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.table_data);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnsa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "account";
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsa;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.DataGridView table_data;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}