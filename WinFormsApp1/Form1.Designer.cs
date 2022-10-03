namespace WinFormsApp1
{
    partial class FDobbelstenengenerator
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
            this.GBinstellingen = new System.Windows.Forms.GroupBox();
            this.Lsoortdobbelsteen = new System.Windows.Forms.Label();
            this.Ldobbelstenen = new System.Windows.Forms.Label();
            this.Bgooi = new System.Windows.Forms.Button();
            this.NUDogen = new System.Windows.Forms.NumericUpDown();
            this.NUDdobbelstenen = new System.Windows.Forms.NumericUpDown();
            this.GBresultaat = new System.Windows.Forms.GroupBox();
            this.Logentotaal = new System.Windows.Forms.Label();
            this.TBtotaalaantalogen = new System.Windows.Forms.TextBox();
            this.LBresultaat = new System.Windows.Forms.ListBox();
            this.GBinstellingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDogen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDdobbelstenen)).BeginInit();
            this.GBresultaat.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBinstellingen
            // 
            this.GBinstellingen.Controls.Add(this.Lsoortdobbelsteen);
            this.GBinstellingen.Controls.Add(this.Ldobbelstenen);
            this.GBinstellingen.Controls.Add(this.Bgooi);
            this.GBinstellingen.Controls.Add(this.NUDogen);
            this.GBinstellingen.Controls.Add(this.NUDdobbelstenen);
            this.GBinstellingen.Location = new System.Drawing.Point(24, 23);
            this.GBinstellingen.Name = "GBinstellingen";
            this.GBinstellingen.Size = new System.Drawing.Size(299, 354);
            this.GBinstellingen.TabIndex = 1;
            this.GBinstellingen.TabStop = false;
            this.GBinstellingen.Text = "Instellingen:";
            // 
            // Lsoortdobbelsteen
            // 
            this.Lsoortdobbelsteen.AutoSize = true;
            this.Lsoortdobbelsteen.Location = new System.Drawing.Point(122, 54);
            this.Lsoortdobbelsteen.Name = "Lsoortdobbelsteen";
            this.Lsoortdobbelsteen.Size = new System.Drawing.Size(18, 15);
            this.Lsoortdobbelsteen.TabIndex = 6;
            this.Lsoortdobbelsteen.Text = "D:";
            // 
            // Ldobbelstenen
            // 
            this.Ldobbelstenen.AutoSize = true;
            this.Ldobbelstenen.Location = new System.Drawing.Point(21, 24);
            this.Ldobbelstenen.Name = "Ldobbelstenen";
            this.Ldobbelstenen.Size = new System.Drawing.Size(119, 15);
            this.Ldobbelstenen.TabIndex = 3;
            this.Ldobbelstenen.Text = "Aantal dobbelstenen:";
            // 
            // Bgooi
            // 
            this.Bgooi.BackColor = System.Drawing.Color.Khaki;
            this.Bgooi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bgooi.Location = new System.Drawing.Point(35, 113);
            this.Bgooi.Name = "Bgooi";
            this.Bgooi.Size = new System.Drawing.Size(225, 199);
            this.Bgooi.TabIndex = 5;
            this.Bgooi.Text = "Gooi!";
            this.Bgooi.UseVisualStyleBackColor = false;
            this.Bgooi.Click += new System.EventHandler(this.Bgooi_Click);
            // 
            // NUDogen
            // 
            this.NUDogen.Location = new System.Drawing.Point(140, 52);
            this.NUDogen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDogen.Name = "NUDogen";
            this.NUDogen.Size = new System.Drawing.Size(120, 23);
            this.NUDogen.TabIndex = 4;
            // 
            // NUDdobbelstenen
            // 
            this.NUDdobbelstenen.Location = new System.Drawing.Point(140, 22);
            this.NUDdobbelstenen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDdobbelstenen.Name = "NUDdobbelstenen";
            this.NUDdobbelstenen.Size = new System.Drawing.Size(120, 23);
            this.NUDdobbelstenen.TabIndex = 3;
            // 
            // GBresultaat
            // 
            this.GBresultaat.Controls.Add(this.Logentotaal);
            this.GBresultaat.Controls.Add(this.TBtotaalaantalogen);
            this.GBresultaat.Controls.Add(this.LBresultaat);
            this.GBresultaat.Location = new System.Drawing.Point(353, 23);
            this.GBresultaat.Name = "GBresultaat";
            this.GBresultaat.Size = new System.Drawing.Size(254, 493);
            this.GBresultaat.TabIndex = 2;
            this.GBresultaat.TabStop = false;
            this.GBresultaat.Text = "Resultaat:";
            // 
            // Logentotaal
            // 
            this.Logentotaal.AutoSize = true;
            this.Logentotaal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logentotaal.Location = new System.Drawing.Point(6, 435);
            this.Logentotaal.Name = "Logentotaal";
            this.Logentotaal.Size = new System.Drawing.Size(138, 21);
            this.Logentotaal.TabIndex = 2;
            this.Logentotaal.Text = "Totaal aantal ogen:";
            // 
            // TBtotaalaantalogen
            // 
            this.TBtotaalaantalogen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBtotaalaantalogen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBtotaalaantalogen.Location = new System.Drawing.Point(150, 432);
            this.TBtotaalaantalogen.Name = "TBtotaalaantalogen";
            this.TBtotaalaantalogen.Size = new System.Drawing.Size(98, 29);
            this.TBtotaalaantalogen.TabIndex = 1;
            this.TBtotaalaantalogen.Text = "0";
            this.TBtotaalaantalogen.TextChanged += new System.EventHandler(this.TBtotaalaantalogen_TextChanged);
            // 
            // LBresultaat
            // 
            this.LBresultaat.FormattingEnabled = true;
            this.LBresultaat.ItemHeight = 15;
            this.LBresultaat.Location = new System.Drawing.Point(6, 22);
            this.LBresultaat.Name = "LBresultaat";
            this.LBresultaat.Size = new System.Drawing.Size(242, 379);
            this.LBresultaat.TabIndex = 0;
            // 
            // FDobbelstenengenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 600);
            this.Controls.Add(this.GBresultaat);
            this.Controls.Add(this.GBinstellingen);
            this.Name = "FDobbelstenengenerator";
            this.Text = "Dobbelstenen Generator.exe";
            this.GBinstellingen.ResumeLayout(false);
            this.GBinstellingen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDogen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDdobbelstenen)).EndInit();
            this.GBresultaat.ResumeLayout(false);
            this.GBresultaat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox GBinstellingen;
        private Button Bgooi;
        private NumericUpDown NUDogen;
        private NumericUpDown NUDdobbelstenen;
        private GroupBox GBresultaat;
        private TextBox TBtotaalaantalogen;
        private ListBox LBresultaat;
        private Label Lsoortdobbelsteen;
        private Label Ldobbelstenen;
        private Label Logentotaal;
    }
}