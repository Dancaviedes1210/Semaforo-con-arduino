
namespace GCD_Practica10
{
    partial class Frm1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.numUPV1 = new System.Windows.Forms.NumericUpDown();
            this.numUPV2 = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.picTrafficL = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numUPV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPV2)).BeginInit();
            this.grpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrafficL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(58, 58);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(44, 18);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // numUPV1
            // 
            this.numUPV1.Location = new System.Drawing.Point(71, 59);
            this.numUPV1.Name = "numUPV1";
            this.numUPV1.Size = new System.Drawing.Size(75, 21);
            this.numUPV1.TabIndex = 1;
            // 
            // numUPV2
            // 
            this.numUPV2.Location = new System.Drawing.Point(71, 102);
            this.numUPV2.Name = "numUPV2";
            this.numUPV2.Size = new System.Drawing.Size(77, 21);
            this.numUPV2.TabIndex = 2;
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.lbl3);
            this.grpControls.Controls.Add(this.lbl2);
            this.grpControls.Controls.Add(this.lbl1);
            this.grpControls.Controls.Add(this.lblSeconds);
            this.grpControls.Controls.Add(this.lblMinutes);
            this.grpControls.Controls.Add(this.btnStop);
            this.grpControls.Controls.Add(this.btnStart);
            this.grpControls.Controls.Add(this.numUPV2);
            this.grpControls.Controls.Add(this.numUPV1);
            this.grpControls.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpControls.Location = new System.Drawing.Point(28, 101);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(253, 232);
            this.grpControls.TabIndex = 3;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Yellow;
            this.lbl3.Location = new System.Drawing.Point(30, 109);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(37, 13);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "label3";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(30, 72);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(37, 13);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "label2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl1.Location = new System.Drawing.Point(30, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(34, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "label1";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(169, 104);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(47, 13);
            this.lblSeconds.TabIndex = 6;
            this.lblSeconds.Text = "Seconds";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(169, 61);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(45, 13);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "Minutes";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.Location = new System.Drawing.Point(53, 191);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 24);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Finish process";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(51, 153);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start process";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // tmr2
            // 
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // picTrafficL
            // 
            this.picTrafficL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTrafficL.Image = global::GCD_Practica10.Properties.Resources.OFF;
            this.picTrafficL.Location = new System.Drawing.Point(297, 69);
            this.picTrafficL.Name = "picTrafficL";
            this.picTrafficL.Size = new System.Drawing.Size(251, 315);
            this.picTrafficL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrafficL.TabIndex = 4;
            this.picTrafficL.TabStop = false;
            this.picTrafficL.UseWaitCursor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(99, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.PortName = "COM3";
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picTrafficL);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.lblMessage);
            this.Name = "Frm1";
            this.Text = "GCD-Practica14";
            this.Load += new System.EventHandler(this.Frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUPV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPV2)).EndInit();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrafficL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.NumericUpDown numUPV1;
        private System.Windows.Forms.NumericUpDown numUPV2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picTrafficL;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnExit;
        private System.IO.Ports.SerialPort serialPortArduino;
    }
}

