namespace TriangleUI
{
    partial class TriangleForm
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
            this.One_Txt = new System.Windows.Forms.TextBox();
            this.Two_Txt = new System.Windows.Forms.TextBox();
            this.Three_Txt = new System.Windows.Forms.TextBox();
            this.Hyp_Btn = new System.Windows.Forms.Button();
            this.Area_Btn = new System.Windows.Forms.Button();
            this.Angle_Btn = new System.Windows.Forms.Button();
            this.One_Lbl = new System.Windows.Forms.Label();
            this.Two_Lbl = new System.Windows.Forms.Label();
            this.Three_Lbl = new System.Windows.Forms.Label();
            this.Instruc_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // One_Txt
            // 
            this.One_Txt.Location = new System.Drawing.Point(129, 60);
            this.One_Txt.Name = "One_Txt";
            this.One_Txt.Size = new System.Drawing.Size(100, 20);
            this.One_Txt.TabIndex = 0;
            // 
            // Two_Txt
            // 
            this.Two_Txt.Location = new System.Drawing.Point(248, 60);
            this.Two_Txt.Name = "Two_Txt";
            this.Two_Txt.Size = new System.Drawing.Size(100, 20);
            this.Two_Txt.TabIndex = 1;
            // 
            // Three_Txt
            // 
            this.Three_Txt.Location = new System.Drawing.Point(112, 171);
            this.Three_Txt.Name = "Three_Txt";
            this.Three_Txt.Size = new System.Drawing.Size(260, 20);
            this.Three_Txt.TabIndex = 2;
            // 
            // Hyp_Btn
            // 
            this.Hyp_Btn.Location = new System.Drawing.Point(93, 108);
            this.Hyp_Btn.Name = "Hyp_Btn";
            this.Hyp_Btn.Size = new System.Drawing.Size(102, 23);
            this.Hyp_Btn.TabIndex = 3;
            this.Hyp_Btn.Text = "Find Hypotenuse";
            this.Hyp_Btn.UseVisualStyleBackColor = true;
            this.Hyp_Btn.Click += new System.EventHandler(this.Hyp_Btn_Click);
            // 
            // Area_Btn
            // 
            this.Area_Btn.Location = new System.Drawing.Point(201, 108);
            this.Area_Btn.Name = "Area_Btn";
            this.Area_Btn.Size = new System.Drawing.Size(75, 23);
            this.Area_Btn.TabIndex = 4;
            this.Area_Btn.Text = "Find Area";
            this.Area_Btn.UseVisualStyleBackColor = true;
            this.Area_Btn.Click += new System.EventHandler(this.Area_Btn_Click);
            // 
            // Angle_Btn
            // 
            this.Angle_Btn.Location = new System.Drawing.Point(283, 107);
            this.Angle_Btn.Name = "Angle_Btn";
            this.Angle_Btn.Size = new System.Drawing.Size(89, 23);
            this.Angle_Btn.TabIndex = 5;
            this.Angle_Btn.Text = "Find Angle";
            this.Angle_Btn.UseVisualStyleBackColor = true;
            this.Angle_Btn.Click += new System.EventHandler(this.Angle_Btn_Click);
            // 
            // One_Lbl
            // 
            this.One_Lbl.AutoSize = true;
            this.One_Lbl.BackColor = System.Drawing.SystemColors.Control;
            this.One_Lbl.Location = new System.Drawing.Point(150, 44);
            this.One_Lbl.Name = "One_Lbl";
            this.One_Lbl.Size = new System.Drawing.Size(57, 13);
            this.One_Lbl.TabIndex = 6;
            this.One_Lbl.Text = "Value One";
            this.One_Lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Two_Lbl
            // 
            this.Two_Lbl.AutoSize = true;
            this.Two_Lbl.Location = new System.Drawing.Point(268, 44);
            this.Two_Lbl.Name = "Two_Lbl";
            this.Two_Lbl.Size = new System.Drawing.Size(58, 13);
            this.Two_Lbl.TabIndex = 7;
            this.Two_Lbl.Text = "Value Two";
            // 
            // Three_Lbl
            // 
            this.Three_Lbl.AutoSize = true;
            this.Three_Lbl.Location = new System.Drawing.Point(204, 155);
            this.Three_Lbl.Name = "Three_Lbl";
            this.Three_Lbl.Size = new System.Drawing.Size(65, 13);
            this.Three_Lbl.TabIndex = 8;
            this.Three_Lbl.Text = "Value Three";
            // 
            // Instruc_Lbl
            // 
            this.Instruc_Lbl.AutoSize = true;
            this.Instruc_Lbl.Location = new System.Drawing.Point(13, 13);
            this.Instruc_Lbl.Name = "Instruc_Lbl";
            this.Instruc_Lbl.Size = new System.Drawing.Size(424, 13);
            this.Instruc_Lbl.TabIndex = 9;
            this.Instruc_Lbl.Text = "Enter value one, value two, then press the button to find the measurement of valu" +
    "e three";
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 212);
            this.Controls.Add(this.Instruc_Lbl);
            this.Controls.Add(this.Three_Lbl);
            this.Controls.Add(this.Two_Lbl);
            this.Controls.Add(this.One_Lbl);
            this.Controls.Add(this.Angle_Btn);
            this.Controls.Add(this.Area_Btn);
            this.Controls.Add(this.Hyp_Btn);
            this.Controls.Add(this.Three_Txt);
            this.Controls.Add(this.Two_Txt);
            this.Controls.Add(this.One_Txt);
            this.Name = "TriangleForm";
            this.Text = "Triangle Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox One_Txt;
        private System.Windows.Forms.TextBox Two_Txt;
        private System.Windows.Forms.TextBox Three_Txt;
        private System.Windows.Forms.Button Hyp_Btn;
        private System.Windows.Forms.Button Area_Btn;
        private System.Windows.Forms.Button Angle_Btn;
        private System.Windows.Forms.Label One_Lbl;
        private System.Windows.Forms.Label Two_Lbl;
        private System.Windows.Forms.Label Three_Lbl;
        private System.Windows.Forms.Label Instruc_Lbl;
    }
}