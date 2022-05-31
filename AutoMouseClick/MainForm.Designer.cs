namespace AutoMouseClick
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.cpbProgress = new AutoMouseClick.CircularProgressBar();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMouseInactiveTimeoutMin = new System.Windows.Forms.Label();
            this.ncMouseActivityTimeout = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.ncCountDown = new System.Windows.Forms.NumericUpDown();
            this.tmrCountDownMouseMovTimeout = new System.Windows.Forms.Timer(this.components);
            this.lblSystemMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncMouseActivityTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncCountDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(18, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(240, 79);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(18, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(240, 79);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cpbProgress
            // 
            this.cpbProgress.BackColor = System.Drawing.SystemColors.Control;
            this.cpbProgress.BarColor1 = System.Drawing.Color.SeaShell;
            this.cpbProgress.BarColor2 = System.Drawing.Color.OliveDrab;
            this.cpbProgress.BarWidth = 25F;
            this.cpbProgress.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpbProgress.ForeColor = System.Drawing.Color.DimGray;
            this.cpbProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cpbProgress.LineColor = System.Drawing.Color.Transparent;
            this.cpbProgress.LineWidth = 1;
            this.cpbProgress.Location = new System.Drawing.Point(295, 37);
            this.cpbProgress.Maximum = ((long)(300));
            this.cpbProgress.MinimumSize = new System.Drawing.Size(100, 100);
            this.cpbProgress.Name = "cpbProgress";
            this.cpbProgress.ProgressShape = AutoMouseClick.CircularProgressBar._ProgressShape.Flat;
            this.cpbProgress.Size = new System.Drawing.Size(176, 176);
            this.cpbProgress.TabIndex = 2;
            this.cpbProgress.Text = "300";
            this.cpbProgress.TextMode = AutoMouseClick.CircularProgressBar._TextMode.Value;
            this.cpbProgress.Value = ((long)(300));
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Click Interval (s):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpbProgress);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 237);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMouseInactiveTimeoutMin);
            this.groupBox2.Controls.Add(this.ncMouseActivityTimeout);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblMinutes);
            this.groupBox2.Controls.Add(this.ncCountDown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // lblMouseInactiveTimeoutMin
            // 
            this.lblMouseInactiveTimeoutMin.AutoSize = true;
            this.lblMouseInactiveTimeoutMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMouseInactiveTimeoutMin.Location = new System.Drawing.Point(371, 103);
            this.lblMouseInactiveTimeoutMin.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblMouseInactiveTimeoutMin.Name = "lblMouseInactiveTimeoutMin";
            this.lblMouseInactiveTimeoutMin.Size = new System.Drawing.Size(100, 25);
            this.lblMouseInactiveTimeoutMin.TabIndex = 5;
            this.lblMouseInactiveTimeoutMin.Text = "(5 min)";
            // 
            // ncMouseActivityTimeout
            // 
            this.ncMouseActivityTimeout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ncMouseActivityTimeout.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ncMouseActivityTimeout.Location = new System.Drawing.Point(252, 96);
            this.ncMouseActivityTimeout.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.ncMouseActivityTimeout.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ncMouseActivityTimeout.Name = "ncMouseActivityTimeout";
            this.ncMouseActivityTimeout.ReadOnly = true;
            this.ncMouseActivityTimeout.Size = new System.Drawing.Size(113, 39);
            this.ncMouseActivityTimeout.TabIndex = 4;
            this.ncMouseActivityTimeout.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ncMouseActivityTimeout.ValueChanged += new System.EventHandler(this.ncMouseActivityTimeout_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mouse Activity Timeout (s):";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinutes.Location = new System.Drawing.Point(372, 47);
            this.lblMinutes.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(100, 25);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "(5 min)";
            // 
            // ncCountDown
            // 
            this.ncCountDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ncCountDown.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ncCountDown.Location = new System.Drawing.Point(253, 40);
            this.ncCountDown.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.ncCountDown.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ncCountDown.Name = "ncCountDown";
            this.ncCountDown.ReadOnly = true;
            this.ncCountDown.Size = new System.Drawing.Size(113, 39);
            this.ncCountDown.TabIndex = 1;
            this.ncCountDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ncCountDown.ValueChanged += new System.EventHandler(this.ncCountDown_ValueChanged);
            // 
            // tmrCountDownMouseMovTimeout
            // 
            this.tmrCountDownMouseMovTimeout.Interval = 15000;
            this.tmrCountDownMouseMovTimeout.Tick += new System.EventHandler(this.tmrCountDownMouseMovTimeout_Tick);
            // 
            // lblSystemMsg
            // 
            this.lblSystemMsg.AutoSize = true;
            this.lblSystemMsg.Location = new System.Drawing.Point(12, 444);
            this.lblSystemMsg.MinimumSize = new System.Drawing.Size(400, 0);
            this.lblSystemMsg.Name = "lblSystemMsg";
            this.lblSystemMsg.Size = new System.Drawing.Size(400, 25);
            this.lblSystemMsg.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 478);
            this.Controls.Add(this.lblSystemMsg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Mouse Magic";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncMouseActivityTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncCountDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnStart;
        private Button btnStop;
        private CircularProgressBar cpbProgress;
        private System.Windows.Forms.Timer tmrCountDown;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown ncCountDown;
        private Label lblMinutes;
        private System.Windows.Forms.Timer tmrCountDownMouseMovTimeout;
        private Label lblMouseInactiveTimeoutMin;
        private NumericUpDown ncMouseActivityTimeout;
        private Label label3;
        private Label lblSystemMsg;
    }
}