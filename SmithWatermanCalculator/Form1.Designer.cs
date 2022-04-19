
namespace NeedlemanWunschCalculator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMatch = new System.Windows.Forms.TextBox();
            this.txtMissmatch = new System.Windows.Forms.TextBox();
            this.txtGap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKelimeKlasor = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblCalismaZamani = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtKelime1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKelime2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(76, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(376, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtMatch
            // 
            this.txtMatch.Location = new System.Drawing.Point(117, 73);
            this.txtMatch.Name = "txtMatch";
            this.txtMatch.Size = new System.Drawing.Size(110, 27);
            this.txtMatch.TabIndex = 1;
            this.txtMatch.Text = "1";
            // 
            // txtMissmatch
            // 
            this.txtMissmatch.Location = new System.Drawing.Point(117, 106);
            this.txtMissmatch.Name = "txtMissmatch";
            this.txtMissmatch.Size = new System.Drawing.Size(110, 27);
            this.txtMissmatch.TabIndex = 1;
            this.txtMissmatch.Text = "-1";
            // 
            // txtGap
            // 
            this.txtGap.Location = new System.Drawing.Point(117, 139);
            this.txtGap.Name = "txtGap";
            this.txtGap.Size = new System.Drawing.Size(110, 27);
            this.txtGap.TabIndex = 1;
            this.txtGap.Text = "-2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Match:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "MissMatch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gap:";
            // 
            // btnKelimeKlasor
            // 
            this.btnKelimeKlasor.BackColor = System.Drawing.Color.BlueViolet;
            this.btnKelimeKlasor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKelimeKlasor.ForeColor = System.Drawing.Color.White;
            this.btnKelimeKlasor.Location = new System.Drawing.Point(251, 137);
            this.btnKelimeKlasor.Name = "btnKelimeKlasor";
            this.btnKelimeKlasor.Size = new System.Drawing.Size(201, 29);
            this.btnKelimeKlasor.TabIndex = 3;
            this.btnKelimeKlasor.Text = "KELİME KLASÖRÜ";
            this.btnKelimeKlasor.UseVisualStyleBackColor = false;
            this.btnKelimeKlasor.Click += new System.EventHandler(this.btnKelimeKlasor_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.BlueViolet;
            this.btnHesapla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(36, 183);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(202, 56);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblCalismaZamani
            // 
            this.lblCalismaZamani.AutoSize = true;
            this.lblCalismaZamani.Location = new System.Drawing.Point(139, 578);
            this.lblCalismaZamani.Name = "lblCalismaZamani";
            this.lblCalismaZamani.Size = new System.Drawing.Size(128, 20);
            this.lblCalismaZamani.TabIndex = 6;
            this.lblCalismaZamani.Text = "lblCalismaZamani";
            this.lblCalismaZamani.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(36, 245);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(43, 330);
            this.dataGridView2.TabIndex = 0;
            // 
            // txtKelime1
            // 
            this.txtKelime1.Location = new System.Drawing.Point(327, 69);
            this.txtKelime1.Name = "txtKelime1";
            this.txtKelime1.ReadOnly = true;
            this.txtKelime1.Size = new System.Drawing.Size(125, 27);
            this.txtKelime1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kelime 1:";
            // 
            // txtKelime2
            // 
            this.txtKelime2.Location = new System.Drawing.Point(327, 102);
            this.txtKelime2.Name = "txtKelime2";
            this.txtKelime2.ReadOnly = true;
            this.txtKelime2.Size = new System.Drawing.Size(125, 27);
            this.txtKelime2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kelime 2:";
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(327, 201);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.ReadOnly = true;
            this.txtPuan.Size = new System.Drawing.Size(125, 27);
            this.txtPuan.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Puan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(36, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "SMITH WATERMAN CALCULATOR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Çalışma Süresi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 620);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCalismaZamani);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnKelimeKlasor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.txtKelime2);
            this.Controls.Add(this.txtKelime1);
            this.Controls.Add(this.txtGap);
            this.Controls.Add(this.txtMissmatch);
            this.Controls.Add(this.txtMatch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smith Waterman Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMatch;
        private System.Windows.Forms.TextBox txtMissmatch;
        private System.Windows.Forms.TextBox txtGap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKelimeKlasor;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblCalismaZamani;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtKelime1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKelime2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}

