
namespace hardwareInfo
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
            this.pRam = new System.Diagnostics.PerformanceCounter();
            this.pCpu = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.lbcpu = new MetroFramework.Controls.MetroLabel();
            this.lbram = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // pRam
            // 
            this.pRam.CategoryName = "Memory";
            this.pRam.CounterName = "% committed Bytes In Use";
            // 
            // pCpu
            // 
            this.pCpu.CategoryName = "Prosecor";
            this.pCpu.CounterName = "%Prosecor Time";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(40, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU :";
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(114, 65);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(391, 23);
            this.metroProgressBarCPU.TabIndex = 1;
            // 
            // lbcpu
            // 
            this.lbcpu.AutoSize = true;
            this.lbcpu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbcpu.Location = new System.Drawing.Point(541, 63);
            this.lbcpu.Name = "lbcpu";
            this.lbcpu.Size = new System.Drawing.Size(35, 25);
            this.lbcpu.TabIndex = 2;
            this.lbcpu.Text = "0%";
            // 
            // lbram
            // 
            this.lbram.AutoSize = true;
            this.lbram.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbram.Location = new System.Drawing.Point(541, 114);
            this.lbram.Name = "lbram";
            this.lbram.Size = new System.Drawing.Size(35, 25);
            this.lbram.TabIndex = 5;
            this.lbram.Text = "0%";
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(114, 116);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(391, 23);
            this.metroProgressBarRAM.TabIndex = 4;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(40, 115);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "RAM :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbram);
            this.Controls.Add(this.metroProgressBarRAM);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lbcpu);
            this.Controls.Add(this.metroProgressBarCPU);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Cpu And Ram";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRam;
        private System.Diagnostics.PerformanceCounter pCpu;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroLabel lbcpu;
        private MetroFramework.Controls.MetroLabel lbram;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

