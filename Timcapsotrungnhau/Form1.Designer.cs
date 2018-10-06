namespace Timcapsotrungnhau
{
    partial class Form1
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
            this.timer_run = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.timer_wait = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_run
            // 
            this.timer_run.Tick += new System.EventHandler(this.timer_run_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "THỜI GIAN:";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbltime.Location = new System.Drawing.Point(154, 14);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(38, 25);
            this.lbltime.TabIndex = 27;
            this.lbltime.Text = "60";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(224, 12);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(92, 29);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Bắt đầu";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnpause
            // 
            this.btnpause.Location = new System.Drawing.Point(339, 12);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(92, 29);
            this.btnpause.TabIndex = 1;
            this.btnpause.Text = "Tạm dừng";
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(448, 12);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(92, 29);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Nghỉ chơi :))";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // timer_wait
            // 
            this.timer_wait.Tick += new System.EventHandler(this.timer_wait_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnstart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 303);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẶP SỐ GIỐNG NHAU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Timer timer_wait;
    }
}

