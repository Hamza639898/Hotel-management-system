namespace hotel_mangment_systeam
{
    partial class rooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnd = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnsa = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.yesradio = new System.Windows.Forms.RadioButton();
            this.noradio = new System.Windows.Forms.RadioButton();
            this.data_table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(160, 262);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(254, 26);
            this.price.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(160, 147);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(254, 26);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id.Location = new System.Drawing.Point(18, 36);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(51, 20);
            this.id.TabIndex = 5;
            this.id.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room_price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room_taype";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Room_name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "room_status";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "single",
            "famele",
            "single_vip",
            "famile_vip"});
            this.comboBox1.Location = new System.Drawing.Point(160, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnd
            // 
            this.btnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnd.Location = new System.Drawing.Point(373, 409);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(119, 34);
            this.btnd.TabIndex = 11;
            this.btnd.Text = "Delete";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // btnup
            // 
            this.btnup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnup.Location = new System.Drawing.Point(190, 409);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(134, 34);
            this.btnup.TabIndex = 12;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsa
            // 
            this.btnsa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsa.Location = new System.Drawing.Point(12, 409);
            this.btnsa.Name = "btnsa";
            this.btnsa.Size = new System.Drawing.Size(128, 34);
            this.btnsa.TabIndex = 13;
            this.btnsa.Text = "Insert";
            this.btnsa.UseVisualStyleBackColor = true;
            this.btnsa.Click += new System.EventHandler(this.button3_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(717, 80);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(249, 26);
            this.search.TabIndex = 15;
            this.search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // yesradio
            // 
            this.yesradio.AutoSize = true;
            this.yesradio.Location = new System.Drawing.Point(190, 327);
            this.yesradio.Name = "yesradio";
            this.yesradio.Size = new System.Drawing.Size(58, 24);
            this.yesradio.TabIndex = 16;
            this.yesradio.TabStop = true;
            this.yesradio.Text = "yes";
            this.yesradio.UseVisualStyleBackColor = true;
            // 
            // noradio
            // 
            this.noradio.AutoSize = true;
            this.noradio.Location = new System.Drawing.Point(285, 327);
            this.noradio.Name = "noradio";
            this.noradio.Size = new System.Drawing.Size(52, 24);
            this.noradio.TabIndex = 17;
            this.noradio.TabStop = true;
            this.noradio.Text = "no";
            this.noradio.UseVisualStyleBackColor = true;
            // 
            // data_table
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_table.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_table.Location = new System.Drawing.Point(466, 122);
            this.data_table.Name = "data_table";
            this.data_table.RowTemplate.Height = 28;
            this.data_table.Size = new System.Drawing.Size(730, 285);
            this.data_table.TabIndex = 18;
            this.data_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_data_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "welcome to form Rooms";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1196, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_table);
            this.Controls.Add(this.noradio);
            this.Controls.Add(this.yesradio);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnsa);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.price);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "rooms";
            this.Text = "rooms";
            this.Load += new System.EventHandler(this.rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnsa;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.RadioButton yesradio;
        private System.Windows.Forms.RadioButton noradio;
        private System.Windows.Forms.DataGridView data_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}