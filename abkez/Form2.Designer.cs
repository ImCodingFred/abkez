namespace abkez
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
            DGV = new DataGridView();
            srsz = new DataGridViewTextBoxColumn();
            rsz = new DataGridViewTextBoxColumn();
            tip = new DataGridViewTextBoxColumn();
            tulaj = new DataGridViewTextBoxColumn();
            ar = new DataGridViewTextBoxColumn();
            tb_tulkeres = new TextBox();
            label1 = new Label();
            tb_rszam = new TextBox();
            label2 = new Label();
            tb_tipus = new TextBox();
            label3 = new Label();
            tb_tulaj = new TextBox();
            label4 = new Label();
            tb_ar = new TextBox();
            label5 = new Label();
            btn_ment = new Button();
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
            DGV.Location = new Point(12, 12);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(479, 415);
            DGV.TabIndex = 1;
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
            // tb_tulkeres
            // 
            tb_tulkeres.Location = new Point(619, 71);
            tb_tulkeres.Name = "tb_tulkeres";
            tb_tulkeres.Size = new Size(129, 23);
            tb_tulkeres.TabIndex = 2;
            tb_tulkeres.TextChanged += tb_tulkeres_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 77);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Tulajdonos";
            // 
            // tb_rszam
            // 
            tb_rszam.Location = new Point(619, 138);
            tb_rszam.Name = "tb_rszam";
            tb_rszam.Size = new Size(129, 23);
            tb_rszam.TabIndex = 2;
            tb_rszam.TextChanged += tb_tulkeres_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 144);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "rendszám";
            // 
            // tb_tipus
            // 
            tb_tipus.Location = new Point(619, 167);
            tb_tipus.Name = "tb_tipus";
            tb_tipus.Size = new Size(129, 23);
            tb_tipus.TabIndex = 2;
            tb_tipus.TextChanged += tb_tulkeres_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 173);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "tipus";
            // 
            // tb_tulaj
            // 
            tb_tulaj.Location = new Point(619, 196);
            tb_tulaj.Name = "tb_tulaj";
            tb_tulaj.Size = new Size(129, 23);
            tb_tulaj.TabIndex = 2;
            tb_tulaj.TextChanged += tb_tulkeres_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 202);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Tulajdonos";
            // 
            // tb_ar
            // 
            tb_ar.Location = new Point(619, 225);
            tb_ar.Name = "tb_ar";
            tb_ar.Size = new Size(129, 23);
            tb_ar.TabIndex = 2;
            tb_ar.TextChanged += tb_tulkeres_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 231);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 3;
            label5.Text = "ár";
            // 
            // btn_ment
            // 
            btn_ment.Location = new Point(567, 289);
            btn_ment.Name = "btn_ment";
            btn_ment.Size = new Size(75, 23);
            btn_ment.TabIndex = 4;
            btn_ment.Text = "ment";
            btn_ment.UseVisualStyleBackColor = true;
            btn_ment.Click += btn_ment_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ment);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_ar);
            Controls.Add(tb_tulaj);
            Controls.Add(tb_tipus);
            Controls.Add(tb_rszam);
            Controls.Add(tb_tulkeres);
            Controls.Add(DGV);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
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
        private TextBox tb_tulkeres;
        private Label label1;
        private TextBox tb_rszam;
        private Label label2;
        private TextBox tb_tipus;
        private Label label3;
        private TextBox tb_tulaj;
        private Label label4;
        private TextBox tb_ar;
        private Label label5;
        private Button btn_ment;
    }
}