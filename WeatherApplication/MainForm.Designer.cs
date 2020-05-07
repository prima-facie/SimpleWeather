namespace WeatherApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.TxtTemperature = new System.Windows.Forms.TextBox();
            this.TxtWind = new System.Windows.Forms.TextBox();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.TxtHumidity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnGet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryBox
            // 
            this.CountryBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.CountryBox.Location = new System.Drawing.Point(12, 29);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(221, 25);
            this.CountryBox.TabIndex = 0;
            // 
            // TxtCity
            // 
            this.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCity.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCity.Location = new System.Drawing.Point(12, 84);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(221, 25);
            this.TxtCity.TabIndex = 1;
            this.TxtCity.Text = "London";
            // 
            // ImageBox
            // 
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBox.Location = new System.Drawing.Point(12, 169);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(78, 64);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageBox.TabIndex = 2;
            this.ImageBox.TabStop = false;
            // 
            // TxtTemperature
            // 
            this.TxtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTemperature.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTemperature.Location = new System.Drawing.Point(12, 239);
            this.TxtTemperature.Name = "TxtTemperature";
            this.TxtTemperature.Size = new System.Drawing.Size(221, 25);
            this.TxtTemperature.TabIndex = 3;
            // 
            // TxtWind
            // 
            this.TxtWind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWind.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWind.Location = new System.Drawing.Point(12, 270);
            this.TxtWind.Name = "TxtWind";
            this.TxtWind.Size = new System.Drawing.Size(221, 25);
            this.TxtWind.TabIndex = 4;
            // 
            // TxtStatus
            // 
            this.TxtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStatus.Location = new System.Drawing.Point(12, 301);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(221, 25);
            this.TxtStatus.TabIndex = 5;
            // 
            // TxtHumidity
            // 
            this.TxtHumidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHumidity.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHumidity.Location = new System.Drawing.Point(12, 332);
            this.TxtHumidity.Name = "TxtHumidity";
            this.TxtHumidity.Size = new System.Drawing.Size(221, 25);
            this.TxtHumidity.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter city";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-8, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 1);
            this.panel1.TabIndex = 9;
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(96, 187);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(137, 25);
            this.txtArea.TabIndex = 10;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(12, 363);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(221, 39);
            this.BtnRefresh.TabIndex = 11;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnGet
            // 
            this.BtnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGet.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGet.Location = new System.Drawing.Point(12, 115);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(221, 41);
            this.BtnGet.TabIndex = 12;
            this.BtnGet.Text = "Get Weather Information";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(245, 416);
            this.Controls.Add(this.BtnGet);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtHumidity);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.TxtWind);
            this.Controls.Add(this.TxtTemperature);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.CountryBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.TextBox TxtTemperature;
        private System.Windows.Forms.TextBox TxtWind;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.TextBox TxtHumidity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnGet;
    }
}

