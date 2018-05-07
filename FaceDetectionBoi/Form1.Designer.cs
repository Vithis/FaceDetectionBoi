namespace FaceDetectionBoi
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.faceXY = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.turretXY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(640, 480);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // port
            // 
            this.port.PortName = "COM7";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(646, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(368, 75);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start turret";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(646, 93);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(368, 75);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop turret";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(646, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Face coordinates";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // faceXY
            // 
            this.faceXY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.faceXY.FlatAppearance.BorderSize = 0;
            this.faceXY.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.faceXY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.faceXY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.faceXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faceXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceXY.Location = new System.Drawing.Point(646, 255);
            this.faceXY.Name = "faceXY";
            this.faceXY.Size = new System.Drawing.Size(368, 75);
            this.faceXY.TabIndex = 3;
            this.faceXY.Text = "X: Y:";
            this.faceXY.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(646, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "Turret coordinates";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(646, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(368, 75);
            this.button4.TabIndex = 3;
            this.button4.Text = "Face coordinates";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // turretXY
            // 
            this.turretXY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.turretXY.FlatAppearance.BorderSize = 0;
            this.turretXY.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.turretXY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.turretXY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.turretXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turretXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turretXY.Location = new System.Drawing.Point(646, 417);
            this.turretXY.Name = "turretXY";
            this.turretXY.Size = new System.Drawing.Size(368, 75);
            this.turretXY.TabIndex = 3;
            this.turretXY.Text = "X: Y:";
            this.turretXY.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 613);
            this.Controls.Add(this.turretXY);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.faceXY);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button faceXY;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button turretXY;
    }
}

