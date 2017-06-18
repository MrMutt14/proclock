namespace ProcLock
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbProc = new System.Windows.Forms.ListBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.nudIdle = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrIdle = new System.Windows.Forms.Timer(this.components);
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdle)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProc
            // 
            this.lbProc.FormattingEnabled = true;
            this.lbProc.Location = new System.Drawing.Point(12, 81);
            this.lbProc.Name = "lbProc";
            this.lbProc.Size = new System.Drawing.Size(187, 147);
            this.lbProc.TabIndex = 0;
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(124, 244);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 1;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // nudIdle
            // 
            this.nudIdle.Location = new System.Drawing.Point(73, 20);
            this.nudIdle.Name = "nudIdle";
            this.nudIdle.Size = new System.Drawing.Size(126, 20);
            this.nudIdle.TabIndex = 3;
            this.nudIdle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIdle.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Idle: (secs)";
            // 
            // tmrIdle
            // 
            this.tmrIdle.Interval = 1000;
            this.tmrIdle.Tick += new System.EventHandler(this.tmrIdle_Tick);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(73, 46);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(126, 20);
            this.txtPIN.TabIndex = 5;
            this.txtPIN.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PIN:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudIdle);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lbProc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "ProcLock";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProc;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.NumericUpDown nudIdle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrIdle;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label2;
    }
}

