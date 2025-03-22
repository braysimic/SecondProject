namespace TheSecondProject
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.grpWeatherCondition = new System.Windows.Forms.GroupBox();
            this.radSunny = new System.Windows.Forms.RadioButton();
            this.radRainy = new System.Windows.Forms.RadioButton();
            this.radWindy = new System.Windows.Forms.RadioButton();
            this.lblWeatherForecast = new System.Windows.Forms.Label();
            this.btnAddWeather = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.lblWeatherReports = new System.Windows.Forms.Label();
            this.lstWeatherReports = new System.Windows.Forms.ListBox();
            this.grpWeatherCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(197, 72);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(74, 20);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(171, 115);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(128, 20);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "Temperature (F):";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(185, 157);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(98, 20);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "Humidity(%):";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(301, 66);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 26);
            this.txtLocation.TabIndex = 4;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(301, 109);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 26);
            this.txtTemperature.TabIndex = 5;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(301, 154);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(100, 26);
            this.txtHumidity.TabIndex = 6;
            // 
            // grpWeatherCondition
            // 
            this.grpWeatherCondition.Controls.Add(this.radWindy);
            this.grpWeatherCondition.Controls.Add(this.radRainy);
            this.grpWeatherCondition.Controls.Add(this.radSunny);
            this.grpWeatherCondition.Location = new System.Drawing.Point(210, 211);
            this.grpWeatherCondition.Name = "grpWeatherCondition";
            this.grpWeatherCondition.Size = new System.Drawing.Size(200, 172);
            this.grpWeatherCondition.TabIndex = 7;
            this.grpWeatherCondition.TabStop = false;
            this.grpWeatherCondition.Text = "Weather Condition";
            // 
            // radSunny
            // 
            this.radSunny.AutoSize = true;
            this.radSunny.Location = new System.Drawing.Point(16, 40);
            this.radSunny.Name = "radSunny";
            this.radSunny.Size = new System.Drawing.Size(79, 24);
            this.radSunny.TabIndex = 0;
            this.radSunny.TabStop = true;
            this.radSunny.Text = "Sunny";
            this.radSunny.UseVisualStyleBackColor = true;
            // 
            // radRainy
            // 
            this.radRainy.AutoSize = true;
            this.radRainy.Location = new System.Drawing.Point(16, 85);
            this.radRainy.Name = "radRainy";
            this.radRainy.Size = new System.Drawing.Size(74, 24);
            this.radRainy.TabIndex = 1;
            this.radRainy.TabStop = true;
            this.radRainy.Text = "Rainy";
            this.radRainy.UseVisualStyleBackColor = true;
            // 
            // radWindy
            // 
            this.radWindy.AutoSize = true;
            this.radWindy.Location = new System.Drawing.Point(16, 129);
            this.radWindy.Name = "radWindy";
            this.radWindy.Size = new System.Drawing.Size(77, 24);
            this.radWindy.TabIndex = 2;
            this.radWindy.TabStop = true;
            this.radWindy.Text = "Windy";
            this.radWindy.UseVisualStyleBackColor = true;
            // 
            // lblWeatherForecast
            // 
            this.lblWeatherForecast.AutoSize = true;
            this.lblWeatherForecast.Location = new System.Drawing.Point(236, 9);
            this.lblWeatherForecast.Name = "lblWeatherForecast";
            this.lblWeatherForecast.Size = new System.Drawing.Size(137, 20);
            this.lblWeatherForecast.TabIndex = 8;
            this.lblWeatherForecast.Text = "Weather Forecast";
            this.lblWeatherForecast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddWeather
            // 
            this.btnAddWeather.Location = new System.Drawing.Point(147, 417);
            this.btnAddWeather.Name = "btnAddWeather";
            this.btnAddWeather.Size = new System.Drawing.Size(124, 27);
            this.btnAddWeather.TabIndex = 9;
            this.btnAddWeather.Text = "Add Weather";
            this.btnAddWeather.UseVisualStyleBackColor = true;
            this.btnAddWeather.Click += new System.EventHandler(this.btnAddWeather_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(322, 417);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(125, 27);
            this.btnViewReport.TabIndex = 10;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // lblWeatherReports
            // 
            this.lblWeatherReports.AutoSize = true;
            this.lblWeatherReports.Location = new System.Drawing.Point(236, 484);
            this.lblWeatherReports.Name = "lblWeatherReports";
            this.lblWeatherReports.Size = new System.Drawing.Size(135, 20);
            this.lblWeatherReports.TabIndex = 11;
            this.lblWeatherReports.Text = "Weather Reports:";
            // 
            // lstWeatherReports
            // 
            this.lstWeatherReports.FormattingEnabled = true;
            this.lstWeatherReports.ItemHeight = 20;
            this.lstWeatherReports.Location = new System.Drawing.Point(226, 507);
            this.lstWeatherReports.Name = "lstWeatherReports";
            this.lstWeatherReports.Size = new System.Drawing.Size(169, 124);
            this.lstWeatherReports.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 694);
            this.Controls.Add(this.lstWeatherReports);
            this.Controls.Add(this.lblWeatherReports);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnAddWeather);
            this.Controls.Add(this.lblWeatherForecast);
            this.Controls.Add(this.grpWeatherCondition);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblLocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpWeatherCondition.ResumeLayout(false);
            this.grpWeatherCondition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.GroupBox grpWeatherCondition;
        private System.Windows.Forms.RadioButton radWindy;
        private System.Windows.Forms.RadioButton radRainy;
        private System.Windows.Forms.RadioButton radSunny;
        private System.Windows.Forms.Label lblWeatherForecast;
        private System.Windows.Forms.Button btnAddWeather;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Label lblWeatherReports;
        private System.Windows.Forms.ListBox lstWeatherReports;
    }
}

