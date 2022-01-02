
namespace HLMS
{
    partial class DiagonsisForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagId = new System.Windows.Forms.TextBox();
            this.PatientidTb = new System.Windows.Forms.ComboBox();
            this.PatientTb = new System.Windows.Forms.TextBox();
            this.SymptomsTb = new System.Windows.Forms.TextBox();
            this.DiagnosisTb = new System.Windows.Forms.TextBox();
            this.MedicineTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DiagnosisLbl = new System.Windows.Forms.Label();
            this.MedicinesLbl = new System.Windows.Forms.Label();
            this.SymptomsLbl = new System.Windows.Forms.Label();
            this.PatientNameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiagnosisGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 83);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(879, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 37);
            this.label10.TabIndex = 30;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(374, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Diagonsis)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(280, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Management System";
            // 
            // DiagId
            // 
            this.DiagId.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DiagId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagId.ForeColor = System.Drawing.Color.Purple;
            this.DiagId.Location = new System.Drawing.Point(12, 125);
            this.DiagId.Name = "DiagId";
            this.DiagId.Size = new System.Drawing.Size(106, 29);
            this.DiagId.TabIndex = 6;
            this.DiagId.Text = "DiagonsisId";
            this.DiagId.TextChanged += new System.EventHandler(this.DiagId_TextChanged);
            // 
            // PatientidTb
            // 
            this.PatientidTb.BackColor = System.Drawing.Color.Purple;
            this.PatientidTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientidTb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PatientidTb.FormattingEnabled = true;
            this.PatientidTb.Location = new System.Drawing.Point(12, 178);
            this.PatientidTb.Name = "PatientidTb";
            this.PatientidTb.Size = new System.Drawing.Size(136, 29);
            this.PatientidTb.TabIndex = 11;
            this.PatientidTb.Text = "Patientid";
            this.PatientidTb.SelectionChangeCommitted += new System.EventHandler(this.PatientidTb_SelectionChangeCommitted);
            // 
            // PatientTb
            // 
            this.PatientTb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PatientTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientTb.ForeColor = System.Drawing.Color.Purple;
            this.PatientTb.Location = new System.Drawing.Point(12, 229);
            this.PatientTb.Name = "PatientTb";
            this.PatientTb.Size = new System.Drawing.Size(119, 29);
            this.PatientTb.TabIndex = 12;
            this.PatientTb.Text = "PatientName";
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SymptomsTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymptomsTb.ForeColor = System.Drawing.Color.Purple;
            this.SymptomsTb.Location = new System.Drawing.Point(190, 125);
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.Size = new System.Drawing.Size(106, 29);
            this.SymptomsTb.TabIndex = 13;
            this.SymptomsTb.Text = "Symptoms";
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DiagnosisTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisTb.ForeColor = System.Drawing.Color.Purple;
            this.DiagnosisTb.Location = new System.Drawing.Point(190, 177);
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(106, 29);
            this.DiagnosisTb.TabIndex = 14;
            this.DiagnosisTb.Text = "Diagonsis";
            // 
            // MedicineTb
            // 
            this.MedicineTb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MedicineTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineTb.ForeColor = System.Drawing.Color.Purple;
            this.MedicineTb.Location = new System.Drawing.Point(190, 229);
            this.MedicineTb.Name = "MedicineTb";
            this.MedicineTb.Size = new System.Drawing.Size(106, 29);
            this.MedicineTb.TabIndex = 15;
            this.MedicineTb.Text = "Medicines";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(119, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 37);
            this.button4.TabIndex = 21;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(119, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(218, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(12, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(391, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Diagnosis List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DiagnosisLbl);
            this.panel2.Controls.Add(this.MedicinesLbl);
            this.panel2.Controls.Add(this.SymptomsLbl);
            this.panel2.Controls.Add(this.PatientNameLbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(327, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 355);
            this.panel2.TabIndex = 24;
            // 
            // DiagnosisLbl
            // 
            this.DiagnosisLbl.AutoSize = true;
            this.DiagnosisLbl.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DiagnosisLbl.Location = new System.Drawing.Point(370, 72);
            this.DiagnosisLbl.Name = "DiagnosisLbl";
            this.DiagnosisLbl.Size = new System.Drawing.Size(116, 31);
            this.DiagnosisLbl.TabIndex = 28;
            this.DiagnosisLbl.Text = "Diagnosis";
            // 
            // MedicinesLbl
            // 
            this.MedicinesLbl.AutoSize = true;
            this.MedicinesLbl.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicinesLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MedicinesLbl.Location = new System.Drawing.Point(370, 135);
            this.MedicinesLbl.Name = "MedicinesLbl";
            this.MedicinesLbl.Size = new System.Drawing.Size(121, 31);
            this.MedicinesLbl.TabIndex = 27;
            this.MedicinesLbl.Text = "Medicines";
            // 
            // SymptomsLbl
            // 
            this.SymptomsLbl.AutoSize = true;
            this.SymptomsLbl.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymptomsLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SymptomsLbl.Location = new System.Drawing.Point(126, 135);
            this.SymptomsLbl.Name = "SymptomsLbl";
            this.SymptomsLbl.Size = new System.Drawing.Size(123, 31);
            this.SymptomsLbl.TabIndex = 26;
            this.SymptomsLbl.Text = "Symptoms";
            // 
            // PatientNameLbl
            // 
            this.PatientNameLbl.AutoSize = true;
            this.PatientNameLbl.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PatientNameLbl.Location = new System.Drawing.Point(107, 83);
            this.PatientNameLbl.Name = "PatientNameLbl";
            this.PatientNameLbl.Size = new System.Drawing.Size(161, 31);
            this.PatientNameLbl.TabIndex = 25;
            this.PatientNameLbl.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(199, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Diagonsis Summary";
            // 
            // DiagnosisGV
            // 
            this.DiagnosisGV.BackgroundColor = System.Drawing.Color.White;
            this.DiagnosisGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosisGV.GridColor = System.Drawing.Color.White;
            this.DiagnosisGV.Location = new System.Drawing.Point(12, 492);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.RowTemplate.Height = 30;
            this.DiagnosisGV.Size = new System.Drawing.Size(899, 151);
            this.DiagnosisGV.TabIndex = 25;
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // DiagonsisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 663);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedicineTb);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.PatientTb);
            this.Controls.Add(this.PatientidTb);
            this.Controls.Add(this.DiagId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagonsisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagonsisForm";
            this.Load += new System.EventHandler(this.DiagonsisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiagId;
        private System.Windows.Forms.ComboBox PatientidTb;
        private System.Windows.Forms.TextBox PatientTb;
        private System.Windows.Forms.TextBox SymptomsTb;
        private System.Windows.Forms.TextBox DiagnosisTb;
        private System.Windows.Forms.TextBox MedicineTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DiagnosisLbl;
        private System.Windows.Forms.Label MedicinesLbl;
        private System.Windows.Forms.Label SymptomsLbl;
        private System.Windows.Forms.Label PatientNameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DiagnosisGV;
    }
}