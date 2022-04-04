namespace praktikumweek7
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
            this.tBoxPertama = new System.Windows.Forms.TextBox();
            this.lPertama = new System.Windows.Forms.Label();
            this.lKedua = new System.Windows.Forms.Label();
            this.lKetiga = new System.Windows.Forms.Label();
            this.tBoxKedua = new System.Windows.Forms.TextBox();
            this.tBoxKetiga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lOutput = new System.Windows.Forms.Label();
            this.BtnKon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxPertama
            // 
            this.tBoxPertama.Location = new System.Drawing.Point(182, 33);
            this.tBoxPertama.Name = "tBoxPertama";
            this.tBoxPertama.Size = new System.Drawing.Size(125, 27);
            this.tBoxPertama.TabIndex = 0;
            // 
            // lPertama
            // 
            this.lPertama.AutoSize = true;
            this.lPertama.Location = new System.Drawing.Point(12, 36);
            this.lPertama.Name = "lPertama";
            this.lPertama.Size = new System.Drawing.Size(129, 20);
            this.lPertama.TabIndex = 1;
            this.lPertama.Text = "Masukkan Kalimat";
            // 
            // lKedua
            // 
            this.lKedua.AutoSize = true;
            this.lKedua.Location = new System.Drawing.Point(12, 92);
            this.lKedua.Name = "lKedua";
            this.lKedua.Size = new System.Drawing.Size(115, 20);
            this.lKedua.TabIndex = 2;
            this.lKedua.Text = "Masukkan Huruf";
            // 
            // lKetiga
            // 
            this.lKetiga.AutoSize = true;
            this.lKetiga.Location = new System.Drawing.Point(432, 92);
            this.lKetiga.Name = "lKetiga";
            this.lKetiga.Size = new System.Drawing.Size(63, 20);
            this.lKetiga.TabIndex = 3;
            this.lKetiga.Text = "Menjadi";
            // 
            // tBoxKedua
            // 
            this.tBoxKedua.Location = new System.Drawing.Point(182, 85);
            this.tBoxKedua.Name = "tBoxKedua";
            this.tBoxKedua.Size = new System.Drawing.Size(125, 27);
            this.tBoxKedua.TabIndex = 4;
            // 
            // tBoxKetiga
            // 
            this.tBoxKetiga.Location = new System.Drawing.Point(530, 85);
            this.tBoxKetiga.Name = "tBoxKetiga";
            this.tBoxKetiga.Size = new System.Drawing.Size(125, 27);
            this.tBoxKetiga.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasil:";
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(103, 180);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(0, 20);
            this.lOutput.TabIndex = 7;
            // 
            // BtnKon
            // 
            this.BtnKon.Location = new System.Drawing.Point(12, 130);
            this.BtnKon.Name = "BtnKon";
            this.BtnKon.Size = new System.Drawing.Size(643, 29);
            this.BtnKon.TabIndex = 8;
            this.BtnKon.Text = "KONVERSI";
            this.BtnKon.UseVisualStyleBackColor = true;
            this.BtnKon.Click += new System.EventHandler(this.BtnKon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 269);
            this.Controls.Add(this.BtnKon);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxKetiga);
            this.Controls.Add(this.tBoxKedua);
            this.Controls.Add(this.lKetiga);
            this.Controls.Add(this.lKedua);
            this.Controls.Add(this.lPertama);
            this.Controls.Add(this.tBoxPertama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBoxPertama;
        private Label lPertama;
        private Label lKedua;
        private Label lKetiga;
        private TextBox tBoxKedua;
        private TextBox tBoxKetiga;
        private Label label4;
        private Label lOutput;
        private Button BtnKon;
    }
}