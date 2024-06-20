using System.Collections.Generic;

namespace OSK5
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        Registers registers;
        Queue<char> code = new Queue<char>();
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.codeBox = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.step = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.ahBox = new System.Windows.Forms.TextBox();
            this.alBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.blBox = new System.Windows.Forms.TextBox();
            this.bhBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.clBox = new System.Windows.Forms.TextBox();
            this.chBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dlBox = new System.Windows.Forms.TextBox();
            this.dhBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(497, 99);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(590, 1033);
            this.codeBox.TabIndex = 0;
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(904, 46);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 31);
            this.run.TabIndex = 1;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // step
            // 
            this.step.Location = new System.Drawing.Point(1012, 46);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(75, 31);
            this.step.TabIndex = 2;
            this.step.Text = "Step";
            this.step.UseVisualStyleBackColor = true;
            this.step.Click += new System.EventHandler(this.step_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(1012, 1138);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 31);
            this.load.TabIndex = 4;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(904, 1138);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 31);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ahBox
            // 
            this.ahBox.BackColor = System.Drawing.SystemColors.Control;
            this.ahBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ahBox.Enabled = false;
            this.ahBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ahBox.HideSelection = false;
            this.ahBox.Location = new System.Drawing.Point(18, 118);
            this.ahBox.Name = "ahBox";
            this.ahBox.Size = new System.Drawing.Size(151, 44);
            this.ahBox.TabIndex = 5;
            this.ahBox.Text = "00000000";
            // 
            // alBox
            // 
            this.alBox.BackColor = System.Drawing.SystemColors.Control;
            this.alBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alBox.Enabled = false;
            this.alBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alBox.HideSelection = false;
            this.alBox.Location = new System.Drawing.Point(175, 118);
            this.alBox.Name = "alBox";
            this.alBox.Size = new System.Drawing.Size(151, 44);
            this.alBox.TabIndex = 6;
            this.alBox.Text = "00000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "AH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(175, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "AL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "AX";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.alBox);
            this.panel1.Controls.Add(this.ahBox);
            this.panel1.Location = new System.Drawing.Point(49, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 181);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.blBox);
            this.panel3.Controls.Add(this.bhBox);
            this.panel3.Location = new System.Drawing.Point(49, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 181);
            this.panel3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(18, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "BX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(175, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "BL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(18, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 31);
            this.label9.TabIndex = 7;
            this.label9.Text = "BH";
            // 
            // blBox
            // 
            this.blBox.BackColor = System.Drawing.SystemColors.Control;
            this.blBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.blBox.Enabled = false;
            this.blBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blBox.HideSelection = false;
            this.blBox.Location = new System.Drawing.Point(175, 118);
            this.blBox.Name = "blBox";
            this.blBox.Size = new System.Drawing.Size(151, 44);
            this.blBox.TabIndex = 6;
            this.blBox.Text = "00000000";
            // 
            // bhBox
            // 
            this.bhBox.BackColor = System.Drawing.SystemColors.Control;
            this.bhBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bhBox.Enabled = false;
            this.bhBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bhBox.HideSelection = false;
            this.bhBox.Location = new System.Drawing.Point(18, 118);
            this.bhBox.Name = "bhBox";
            this.bhBox.Size = new System.Drawing.Size(151, 44);
            this.bhBox.TabIndex = 5;
            this.bhBox.Text = "00000000";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.clBox);
            this.panel4.Controls.Add(this.chBox);
            this.panel4.Location = new System.Drawing.Point(49, 652);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 181);
            this.panel4.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(18, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 39);
            this.label10.TabIndex = 9;
            this.label10.Text = "CX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(175, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 31);
            this.label11.TabIndex = 8;
            this.label11.Text = "CL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(18, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 31);
            this.label12.TabIndex = 7;
            this.label12.Text = "CH";
            // 
            // clBox
            // 
            this.clBox.BackColor = System.Drawing.SystemColors.Control;
            this.clBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.clBox.Enabled = false;
            this.clBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clBox.HideSelection = false;
            this.clBox.Location = new System.Drawing.Point(175, 118);
            this.clBox.Name = "clBox";
            this.clBox.Size = new System.Drawing.Size(151, 44);
            this.clBox.TabIndex = 6;
            this.clBox.Text = "00000000";
            // 
            // chBox
            // 
            this.chBox.BackColor = System.Drawing.SystemColors.Control;
            this.chBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chBox.Enabled = false;
            this.chBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBox.HideSelection = false;
            this.chBox.Location = new System.Drawing.Point(18, 118);
            this.chBox.Name = "chBox";
            this.chBox.Size = new System.Drawing.Size(151, 44);
            this.chBox.TabIndex = 5;
            this.chBox.Text = "00000000";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.dlBox);
            this.panel5.Controls.Add(this.dhBox);
            this.panel5.Location = new System.Drawing.Point(49, 951);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 181);
            this.panel5.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(18, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 39);
            this.label13.TabIndex = 9;
            this.label13.Text = "DX";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(175, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 31);
            this.label14.TabIndex = 8;
            this.label14.Text = "DL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(18, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 31);
            this.label15.TabIndex = 7;
            this.label15.Text = "DH";
            // 
            // dlBox
            // 
            this.dlBox.BackColor = System.Drawing.SystemColors.Control;
            this.dlBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dlBox.Enabled = false;
            this.dlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlBox.HideSelection = false;
            this.dlBox.Location = new System.Drawing.Point(175, 118);
            this.dlBox.Name = "dlBox";
            this.dlBox.Size = new System.Drawing.Size(151, 44);
            this.dlBox.TabIndex = 6;
            this.dlBox.Text = "00000000";
            // 
            // dhBox
            // 
            this.dhBox.BackColor = System.Drawing.SystemColors.Control;
            this.dhBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dhBox.Enabled = false;
            this.dhBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dhBox.HideSelection = false;
            this.dhBox.Location = new System.Drawing.Point(18, 118);
            this.dhBox.Name = "dhBox";
            this.dhBox.Size = new System.Drawing.Size(151, 44);
            this.dhBox.TabIndex = 5;
            this.dhBox.Text = "00000000";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 1231);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.step);
            this.Controls.Add(this.run);
            this.Controls.Add(this.codeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button step;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox ahBox;
        private System.Windows.Forms.TextBox alBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox blBox;
        private System.Windows.Forms.TextBox bhBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox clBox;
        private System.Windows.Forms.TextBox chBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox dlBox;
        private System.Windows.Forms.TextBox dhBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

