namespace abkez
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV = new DataGridView();
            srsz = new DataGridViewTextBoxColumn();
            rsz = new DataGridViewTextBoxColumn();
            tip = new DataGridViewTextBoxColumn();
            tulaj = new DataGridViewTextBoxColumn();
            ar = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            atlag = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { srsz, rsz, tip, tulaj, ar });
            DGV.Location = new Point(23, 12);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(479, 415);
            DGV.TabIndex = 0;
            // 
            // srsz
            // 
            srsz.HeaderText = "Sorszám";
            srsz.Name = "srsz";
            srsz.ReadOnly = true;
            // 
            // rsz
            // 
            rsz.HeaderText = "Rendszám";
            rsz.Name = "rsz";
            rsz.ReadOnly = true;
            // 
            // tip
            // 
            tip.HeaderText = "tipus";
            tip.Name = "tip";
            tip.ReadOnly = true;
            // 
            // tulaj
            // 
            tulaj.HeaderText = "tulajdonos";
            tulaj.Name = "tulaj";
            tulaj.ReadOnly = true;
            // 
            // ar
            // 
            ar.HeaderText = "ár";
            ar.Name = "ar";
            ar.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(567, 117);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 194);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 2;
            label1.Text = "Az autók átlag ára:";
            // 
            // atlag
            // 
            atlag.AutoSize = true;
            atlag.Location = new Point(685, 194);
            atlag.Name = "atlag";
            atlag.Size = new Size(13, 15);
            atlag.TabIndex = 3;
            atlag.Text = "0";
            // 
            // button2
            // 
            button2.Location = new Point(593, 278);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(atlag);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(DGV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private DataGridViewTextBoxColumn srsz;
        private DataGridViewTextBoxColumn rsz;
        private DataGridViewTextBoxColumn tip;
        private DataGridViewTextBoxColumn tulaj;
        private DataGridViewTextBoxColumn ar;
        private Button button1;
        private Label label1;
        private Label atlag;
        private Button button2;
    }
}
