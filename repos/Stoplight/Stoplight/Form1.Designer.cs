namespace Stoplight
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            redStopLight = new PictureBox();
            yellowStopLight = new PictureBox();
            greenStopLight = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            btnStop = new Button();
            car = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)redStopLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellowStopLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenStopLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            SuspendLayout();
            // 
            // redStopLight
            // 
            redStopLight.Image = Properties.Resources.png_clipart_traffic_light_red_prognosis_s_light_fixture_color_removebg_preview;
            redStopLight.Location = new Point(206, 12);
            redStopLight.Name = "redStopLight";
            redStopLight.Size = new Size(380, 464);
            redStopLight.SizeMode = PictureBoxSizeMode.CenterImage;
            redStopLight.TabIndex = 0;
            redStopLight.TabStop = false;
            redStopLight.Click += pictureBox1_Click;
            // 
            // yellowStopLight
            // 
            yellowStopLight.Image = Properties.Resources.Traffic_light_yellow_766495_removebg_preview;
            yellowStopLight.Location = new Point(206, 12);
            yellowStopLight.Name = "yellowStopLight";
            yellowStopLight.Size = new Size(380, 464);
            yellowStopLight.SizeMode = PictureBoxSizeMode.CenterImage;
            yellowStopLight.TabIndex = 1;
            yellowStopLight.TabStop = false;
            yellowStopLight.Click += yellowStopLight_Click;
            // 
            // greenStopLight
            // 
            greenStopLight.Image = Properties.Resources.Traffic_light_green_removebg_preview__1_;
            greenStopLight.Location = new Point(206, 12);
            greenStopLight.Name = "greenStopLight";
            greenStopLight.Size = new Size(380, 464);
            greenStopLight.SizeMode = PictureBoxSizeMode.CenterImage;
            greenStopLight.TabIndex = 2;
            greenStopLight.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(692, 64);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(99, 33);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(692, 131);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(99, 34);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // car
            // 
            car.Image = Properties.Resources.Red_Lamborghini_Car_PNG_Transparent_Image_removebg_preview1;
            car.Location = new Point(12, 558);
            car.Name = "car";
            car.Size = new Size(333, 97);
            car.SizeMode = PictureBoxSizeMode.AutoSize;
            car.TabIndex = 5;
            car.TabStop = false;
            car.Click += pictureBox1_Click_1;
            // 
            // timer2
            // 
            timer2.Interval = 500;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 812);
            Controls.Add(car);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(greenStopLight);
            Controls.Add(yellowStopLight);
            Controls.Add(redStopLight);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)redStopLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellowStopLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenStopLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox redStopLight;
        private PictureBox yellowStopLight;
        private PictureBox greenStopLight;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private Button btnStop;
        private PictureBox car;
        private System.Windows.Forms.Timer timer2;
    }
}