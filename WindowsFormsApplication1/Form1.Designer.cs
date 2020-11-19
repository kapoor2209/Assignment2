namespace Car_Race
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CarTrackimage = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.Car4 = new System.Windows.Forms.PictureBox();
            this.GoRace = new System.Windows.Forms.Button();
            this.MinimumButton = new System.Windows.Forms.Label();
            this.JordenRadioButton = new System.Windows.Forms.RadioButton();
            this.BaronRadioButton = new System.Windows.Forms.RadioButton();
            this.AdomRadioButton = new System.Windows.Forms.RadioButton();
            this.BetsLabel = new System.Windows.Forms.Label();
            this.JordenButtonLabel = new System.Windows.Forms.Label();
            this.BaronButtonLabel = new System.Windows.Forms.Label();
            this.AdomButtonLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BetsButton = new System.Windows.Forms.Button();
            this.numericincreasedecrease = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericincreasedecreaseCar = new System.Windows.Forms.NumericUpDown();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarTrackimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericincreasedecrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericincreasedecreaseCar)).BeginInit();
            this.SuspendLayout();
            // 
            // CarTrackimage
            // 
            this.CarTrackimage.Image = ((System.Drawing.Image)(resources.GetObject("CarTrackimage.Image")));
            this.CarTrackimage.Location = new System.Drawing.Point(18, 13);
            this.CarTrackimage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CarTrackimage.Name = "CarTrackimage";
            this.CarTrackimage.Size = new System.Drawing.Size(1244, 309);
            this.CarTrackimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarTrackimage.TabIndex = 0;
            this.CarTrackimage.TabStop = false;
            this.CarTrackimage.Click += new System.EventHandler(this.CarTrackimage_Click);
            // 
            // Car1
            // 
            this.Car1.Image = ((System.Drawing.Image)(resources.GetObject("Car1.Image")));
            this.Car1.Location = new System.Drawing.Point(44, 37);
            this.Car1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(112, 32);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 1;
            this.Car1.TabStop = false;
            this.Car1.Click += new System.EventHandler(this.Car1_Click);
            // 
            // Car2
            // 
            this.Car2.Image = ((System.Drawing.Image)(resources.GetObject("Car2.Image")));
            this.Car2.Location = new System.Drawing.Point(44, 104);
            this.Car2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(112, 34);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 2;
            this.Car2.TabStop = false;
            this.Car2.Click += new System.EventHandler(this.Car2_Click);
            // 
            // Car3
            // 
            this.Car3.Image = ((System.Drawing.Image)(resources.GetObject("Car3.Image")));
            this.Car3.Location = new System.Drawing.Point(44, 179);
            this.Car3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(112, 37);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car3.TabIndex = 3;
            this.Car3.TabStop = false;
            this.Car3.Click += new System.EventHandler(this.Car3_Click);
            // 
            // Car4
            // 
            this.Car4.Image = ((System.Drawing.Image)(resources.GetObject("Car4.Image")));
            this.Car4.Location = new System.Drawing.Point(44, 254);
            this.Car4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(112, 37);
            this.Car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car4.TabIndex = 4;
            this.Car4.TabStop = false;
            // 
            // GoRace
            // 
            this.GoRace.Location = new System.Drawing.Point(432, 552);
            this.GoRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoRace.Name = "GoRace";
            this.GoRace.Size = new System.Drawing.Size(147, 48);
            this.GoRace.TabIndex = 5;
            this.GoRace.Text = "RacingMotors!";
            this.GoRace.UseVisualStyleBackColor = true;
            this.GoRace.Click += new System.EventHandler(this.CarRaceGo);
            // 
            // MinimumButton
            // 
            this.MinimumButton.AutoSize = true;
            this.MinimumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumButton.Location = new System.Drawing.Point(14, 371);
            this.MinimumButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinimumButton.Name = "MinimumButton";
            this.MinimumButton.Size = new System.Drawing.Size(0, 20);
            this.MinimumButton.TabIndex = 6;
            // 
            // JordenRadioButton
            // 
            this.JordenRadioButton.AutoSize = true;
            this.JordenRadioButton.Location = new System.Drawing.Point(432, 371);
            this.JordenRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JordenRadioButton.Name = "JordenRadioButton";
            this.JordenRadioButton.Size = new System.Drawing.Size(126, 24);
            this.JordenRadioButton.TabIndex = 7;
            this.JordenRadioButton.TabStop = true;
            this.JordenRadioButton.Text = "radioButton1";
            this.JordenRadioButton.UseVisualStyleBackColor = true;
            this.JordenRadioButton.CheckedChanged += new System.EventHandler(this.JordenRadioButton_CheckedChanged);
            // 
            // BaronRadioButton
            // 
            this.BaronRadioButton.AutoSize = true;
            this.BaronRadioButton.Location = new System.Drawing.Point(432, 432);
            this.BaronRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BaronRadioButton.Name = "BaronRadioButton";
            this.BaronRadioButton.Size = new System.Drawing.Size(126, 24);
            this.BaronRadioButton.TabIndex = 8;
            this.BaronRadioButton.TabStop = true;
            this.BaronRadioButton.Text = "radioButton1";
            this.BaronRadioButton.UseVisualStyleBackColor = true;
            this.BaronRadioButton.CheckedChanged += new System.EventHandler(this.BaronRadioButton_CheckedChanged_1);
            // 
            // AdomRadioButton
            // 
            this.AdomRadioButton.AutoSize = true;
            this.AdomRadioButton.Location = new System.Drawing.Point(432, 493);
            this.AdomRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdomRadioButton.Name = "AdomRadioButton";
            this.AdomRadioButton.Size = new System.Drawing.Size(126, 24);
            this.AdomRadioButton.TabIndex = 9;
            this.AdomRadioButton.TabStop = true;
            this.AdomRadioButton.Text = "radioButton2";
            this.AdomRadioButton.UseVisualStyleBackColor = true;
            this.AdomRadioButton.CheckedChanged += new System.EventHandler(this.AdomRadioButton_CheckedChanged_1);
            // 
            // BetsLabel
            // 
            this.BetsLabel.AutoSize = true;
            this.BetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetsLabel.Location = new System.Drawing.Point(428, 327);
            this.BetsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetsLabel.Name = "BetsLabel";
            this.BetsLabel.Size = new System.Drawing.Size(48, 20);
            this.BetsLabel.TabIndex = 10;
            this.BetsLabel.Text = "Bets";
            // 
            // JordenButtonLabel
            // 
            this.JordenButtonLabel.AutoSize = true;
            this.JordenButtonLabel.Location = new System.Drawing.Point(786, 371);
            this.JordenButtonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JordenButtonLabel.Name = "JordenButtonLabel";
            this.JordenButtonLabel.Size = new System.Drawing.Size(51, 20);
            this.JordenButtonLabel.TabIndex = 11;
            this.JordenButtonLabel.Text = "label1";
            // 
            // BaronButtonLabel
            // 
            this.BaronButtonLabel.AutoSize = true;
            this.BaronButtonLabel.Location = new System.Drawing.Point(786, 436);
            this.BaronButtonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BaronButtonLabel.Name = "BaronButtonLabel";
            this.BaronButtonLabel.Size = new System.Drawing.Size(51, 20);
            this.BaronButtonLabel.TabIndex = 12;
            this.BaronButtonLabel.Text = "label1";
            // 
            // AdomButtonLabel
            // 
            this.AdomButtonLabel.AutoSize = true;
            this.AdomButtonLabel.Location = new System.Drawing.Point(786, 493);
            this.AdomButtonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdomButtonLabel.Name = "AdomButtonLabel";
            this.AdomButtonLabel.Size = new System.Drawing.Size(51, 20);
            this.AdomButtonLabel.TabIndex = 13;
            this.AdomButtonLabel.Text = "label1";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(14, 552);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 20);
            this.NameLabel.TabIndex = 14;
            // 
            // BetsButton
            // 
            this.BetsButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BetsButton.Location = new System.Drawing.Point(34, 430);
            this.BetsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BetsButton.Name = "BetsButton";
            this.BetsButton.Size = new System.Drawing.Size(176, 33);
            this.BetsButton.TabIndex = 15;
            this.BetsButton.Text = "Bets";
            this.BetsButton.UseVisualStyleBackColor = false;
            this.BetsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // numericincreasedecrease
            // 
            this.numericincreasedecrease.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.numericincreasedecrease.Location = new System.Drawing.Point(247, 432);
            this.numericincreasedecrease.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericincreasedecrease.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericincreasedecrease.Name = "numericincreasedecrease";
            this.numericincreasedecrease.Size = new System.Drawing.Size(49, 26);
            this.numericincreasedecrease.TabIndex = 16;
            this.numericincreasedecrease.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericincreasedecrease.ValueChanged += new System.EventHandler(this.numericincreasedecrease_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 497);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "bucks on Motor number ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericincreasedecreaseCar
            // 
            this.numericincreasedecreaseCar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numericincreasedecreaseCar.Location = new System.Drawing.Point(247, 491);
            this.numericincreasedecreaseCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericincreasedecreaseCar.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericincreasedecreaseCar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericincreasedecreaseCar.Name = "numericincreasedecreaseCar";
            this.numericincreasedecreaseCar.Size = new System.Drawing.Size(49, 26);
            this.numericincreasedecreaseCar.TabIndex = 18;
            this.numericincreasedecreaseCar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(690, 552);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(147, 46);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1251, 631);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.numericincreasedecreaseCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericincreasedecrease);
            this.Controls.Add(this.BetsButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AdomButtonLabel);
            this.Controls.Add(this.BaronButtonLabel);
            this.Controls.Add(this.JordenButtonLabel);
            this.Controls.Add(this.BetsLabel);
            this.Controls.Add(this.AdomRadioButton);
            this.Controls.Add(this.BaronRadioButton);
            this.Controls.Add(this.JordenRadioButton);
            this.Controls.Add(this.MinimumButton);
            this.Controls.Add(this.GoRace);
            this.Controls.Add(this.Car4);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.CarTrackimage);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarTrackimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericincreasedecrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericincreasedecreaseCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CarTrackimage;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car3;
        private System.Windows.Forms.PictureBox Car4;
        private System.Windows.Forms.Button GoRace;
        private System.Windows.Forms.Label MinimumButton;
        private System.Windows.Forms.RadioButton JordenRadioButton;
        private System.Windows.Forms.RadioButton BaronRadioButton;
        private System.Windows.Forms.RadioButton AdomRadioButton;
        private System.Windows.Forms.Label BetsLabel;
        private System.Windows.Forms.Label JordenButtonLabel;
        private System.Windows.Forms.Label BaronButtonLabel;
        private System.Windows.Forms.Label AdomButtonLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button BetsButton;
        private System.Windows.Forms.NumericUpDown numericincreasedecrease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericincreasedecreaseCar;
        private System.Windows.Forms.Button ResetButton;
    }
}