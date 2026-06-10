namespace HastaTakipSistem
{
    partial class frmIstatistik
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamHasta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYasOrt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErkekHasta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKadınhasta = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblExHasta = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.42735F));
            this.tableLayoutPanel1.Controls.Add(this.lblExHasta, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblKadınhasta, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblErkekHasta, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYasOrt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblToplamHasta, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1488, 643);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1488, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1482, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA TAKİP SİSTEMİ V01 - iSTATISTIK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 128);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Kayıtlı Hasta Sayısı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToplamHasta
            // 
            this.lblToplamHasta.AutoSize = true;
            this.lblToplamHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplamHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamHasta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToplamHasta.Location = new System.Drawing.Point(740, 0);
            this.lblToplamHasta.Name = "lblToplamHasta";
            this.lblToplamHasta.Size = new System.Drawing.Size(745, 128);
            this.lblToplamHasta.TabIndex = 2;
            this.lblToplamHasta.Text = "00";
            this.lblToplamHasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(731, 128);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yas ortalaması ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYasOrt
            // 
            this.lblYasOrt.AutoSize = true;
            this.lblYasOrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYasOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYasOrt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYasOrt.Location = new System.Drawing.Point(740, 128);
            this.lblYasOrt.Name = "lblYasOrt";
            this.lblYasOrt.Size = new System.Drawing.Size(745, 128);
            this.lblYasOrt.TabIndex = 4;
            this.lblYasOrt.Text = "00";
            this.lblYasOrt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(731, 128);
            this.label6.TabIndex = 5;
            this.label6.Text = "Erkek Hasta Sayısı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErkekHasta
            // 
            this.lblErkekHasta.AutoSize = true;
            this.lblErkekHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErkekHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErkekHasta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErkekHasta.Location = new System.Drawing.Point(740, 256);
            this.lblErkekHasta.Name = "lblErkekHasta";
            this.lblErkekHasta.Size = new System.Drawing.Size(745, 128);
            this.lblErkekHasta.TabIndex = 6;
            this.lblErkekHasta.Text = "00";
            this.lblErkekHasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(3, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(731, 128);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kadın Hasta Sayısı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKadınhasta
            // 
            this.lblKadınhasta.AutoSize = true;
            this.lblKadınhasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKadınhasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKadınhasta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKadınhasta.Location = new System.Drawing.Point(740, 384);
            this.lblKadınhasta.Name = "lblKadınhasta";
            this.lblKadınhasta.Size = new System.Drawing.Size(745, 128);
            this.lblKadınhasta.TabIndex = 8;
            this.lblKadınhasta.Text = "00";
            this.lblKadınhasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(3, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(731, 131);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ex Hasta Sayısı";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExHasta
            // 
            this.lblExHasta.AutoSize = true;
            this.lblExHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExHasta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExHasta.Location = new System.Drawing.Point(740, 512);
            this.lblExHasta.Name = "lblExHasta";
            this.lblExHasta.Size = new System.Drawing.Size(745, 131);
            this.lblExHasta.TabIndex = 10;
            this.lblExHasta.Text = "00";
            this.lblExHasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1488, 705);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximumSize = new System.Drawing.Size(1506, 752);
            this.Name = "frmIstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIstatistik";
            this.Load += new System.EventHandler(this.frmIstatistik_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYasOrt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExHasta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblKadınhasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblErkekHasta;
        private System.Windows.Forms.Label label6;
    }
}