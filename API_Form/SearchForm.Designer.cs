namespace API_Form
{
    partial class SearchForm
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
            comboBox_Search_Criteria = new ComboBox();
            button_Search = new Button();
            textBox_SearchText = new TextBox();
            listView = new ListView();
            ID = new ColumnHeader();
            name = new ColumnHeader();
            nameStreet = new ColumnHeader();
            place = new ColumnHeader();
            street = new ColumnHeader();
            city = new ColumnHeader();
            zip = new ColumnHeader();
            country = new ColumnHeader();
            wheelchairAccessible = new ColumnHeader();
            latitude = new ColumnHeader();
            longitude = new ColumnHeader();
            url = new ColumnHeader();
            dressingRoom = new ColumnHeader();
            claimAssistant = new ColumnHeader();
            packetConsignment = new ColumnHeader();
            maxWeight = new ColumnHeader();
            labelRouting = new ColumnHeader();
            labelName = new ColumnHeader();
            SuspendLayout();
            // 
            // comboBox_Search_Criteria
            // 
            comboBox_Search_Criteria.FormattingEnabled = true;
            comboBox_Search_Criteria.Location = new Point(12, 12);
            comboBox_Search_Criteria.Name = "comboBox_Search_Criteria";
            comboBox_Search_Criteria.Size = new Size(173, 23);
            comboBox_Search_Criteria.TabIndex = 0;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(568, 12);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(76, 23);
            button_Search.TabIndex = 1;
            button_Search.Text = "Vyhledej";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // textBox_SearchText
            // 
            textBox_SearchText.Location = new Point(191, 11);
            textBox_SearchText.Name = "textBox_SearchText";
            textBox_SearchText.Size = new Size(371, 23);
            textBox_SearchText.TabIndex = 2;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { ID, name, nameStreet, place, street, city, zip, country, wheelchairAccessible, latitude, longitude, url, dressingRoom, claimAssistant, packetConsignment, maxWeight, labelRouting, labelName });
            listView.Font = new Font("Segoe UI", 11F);
            listView.Location = new Point(12, 41);
            listView.Name = "listView";
            listView.Size = new Size(1381, 897);
            listView.TabIndex = 3;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.DoubleClick += listView_DoubleClick;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // name
            // 
            name.Text = "name";
            name.Width = 130;
            // 
            // nameStreet
            // 
            nameStreet.Text = "nameStreet";
            nameStreet.Width = 120;
            // 
            // place
            // 
            place.Text = "place";
            // 
            // street
            // 
            street.Text = "street";
            street.Width = 130;
            // 
            // city
            // 
            city.Text = "city";
            city.Width = 100;
            // 
            // zip
            // 
            zip.Text = "zip";
            // 
            // country
            // 
            country.Text = "country";
            country.Width = 70;
            // 
            // wheelchairAccessible
            // 
            wheelchairAccessible.Text = "wheelchairAccessible";
            // 
            // latitude
            // 
            latitude.Text = "latitude";
            latitude.Width = 80;
            // 
            // longitude
            // 
            longitude.Text = "longitude";
            longitude.Width = 80;
            // 
            // url
            // 
            url.Text = "url";
            // 
            // dressingRoom
            // 
            dressingRoom.Text = "dressingRoom";
            // 
            // claimAssistant
            // 
            claimAssistant.Text = "claimAssistant";
            // 
            // packetConsignment
            // 
            packetConsignment.Text = "packetConsignment";
            // 
            // maxWeight
            // 
            maxWeight.Text = "maxWeight";
            // 
            // labelRouting
            // 
            labelRouting.Text = "labelRouting";
            // 
            // labelName
            // 
            labelName.Text = "labelName";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 950);
            Controls.Add(listView);
            Controls.Add(textBox_SearchText);
            Controls.Add(button_Search);
            Controls.Add(comboBox_Search_Criteria);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Search_Criteria;
        private Button button_Search;
        private TextBox textBox_SearchText;
        private ListView listView;
        private ColumnHeader ID;
        private ColumnHeader name;
        private ColumnHeader nameStreet;
        private ColumnHeader place;
        private ColumnHeader street;
        private ColumnHeader city;
        private ColumnHeader zip;
        private ColumnHeader country;
        private ColumnHeader wheelchairAccessible;
        private ColumnHeader latitude;
        private ColumnHeader longitude;
        private ColumnHeader url;
        private ColumnHeader dressingRoom;
        private ColumnHeader claimAssistant;
        private ColumnHeader packetConsignment;
        private ColumnHeader maxWeight;
        private ColumnHeader labelRouting;
        private ColumnHeader labelName;
    }
}