namespace API_Form
{
    partial class DetailsForm
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
            label_id = new Label();
            button_zpet = new Button();
            textBox_PP_ID = new TextBox();
            richTextBox_name = new RichTextBox();
            button_Uloz_Zmeny = new Button();
            button_Reset = new Button();
            label_Name = new Label();
            label_nameStreet = new Label();
            label_special = new Label();
            richTextBox_nameStreet = new RichTextBox();
            richTextBox_special = new RichTextBox();
            richTextBox_directions = new RichTextBox();
            textBox_place = new TextBox();
            textBox_street = new TextBox();
            label_street = new Label();
            textBox_city = new TextBox();
            label_city = new Label();
            textBox_zip = new TextBox();
            label_zip = new Label();
            textBox_country = new TextBox();
            label_country = new Label();
            textBox_currency = new TextBox();
            label_currency = new Label();
            textBox_wheelchairAccesible = new TextBox();
            label_direction = new Label();
            label_directionCar = new Label();
            richTextBox_directionsCar = new RichTextBox();
            label_directionPublic = new Label();
            richTextBox_directionsPublic = new RichTextBox();
            label_wheelchairAccesible = new Label();
            richTextBox_url = new RichTextBox();
            label_latitude = new Label();
            textBox_latitude = new TextBox();
            label_longitude = new Label();
            textBox_longitude = new TextBox();
            label_url = new Label();
            checkBox_dressingroom = new CheckBox();
            checkBox_claimAssistant = new CheckBox();
            checkBox_packetConsignment = new CheckBox();
            label_maxWeight = new Label();
            textBox_maxWeight = new TextBox();
            label_labelRouting = new Label();
            textBox_labelRouting = new TextBox();
            label_labelName = new Label();
            label_place = new Label();
            richTextBox_labelName = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button_Show_On_Map = new Button();
            dataGridView_openingHoursExceptions = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            hour = new DataGridViewTextBoxColumn();
            dataGridView_openingHours = new DataGridView();
            dataGridViewTextBox_day = new DataGridViewTextBoxColumn();
            dataGridViewTextBox_OpeningHoursDay = new DataGridViewTextBoxColumn();
            richTextBox_compactShort = new RichTextBox();
            label_compactShort = new Label();
            richTextBox_compactLong = new RichTextBox();
            label_compactLong = new Label();
            richTextBox_tableLong = new RichTextBox();
            label_tableLong = new Label();
            dataGridView_photos = new DataGridView();
            dataGridViewTextBox_thumbnail = new DataGridViewTextBoxColumn();
            dataGridViewTextBox_normal = new DataGridViewTextBoxColumn();
            label_openingHours = new Label();
            label_openingHoursException = new Label();
            label_photos = new Label();
            label_pom_pickupPoint_ID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_openingHoursExceptions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_openingHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_photos).BeginInit();
            SuspendLayout();
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Font = new Font("Segoe UI", 13F);
            label_id.Location = new Point(12, 71);
            label_id.Name = "label_id";
            label_id.Size = new Size(30, 25);
            label_id.TabIndex = 0;
            label_id.Text = "ID";
            // 
            // button_zpet
            // 
            button_zpet.Location = new Point(12, 12);
            button_zpet.Name = "button_zpet";
            button_zpet.Size = new Size(174, 37);
            button_zpet.TabIndex = 1;
            button_zpet.Text = "Zpět";
            button_zpet.UseVisualStyleBackColor = true;
            button_zpet.Click += button_zpet_Click;
            // 
            // textBox_PP_ID
            // 
            textBox_PP_ID.Location = new Point(56, 73);
            textBox_PP_ID.Name = "textBox_PP_ID";
            textBox_PP_ID.ReadOnly = true;
            textBox_PP_ID.Size = new Size(609, 23);
            textBox_PP_ID.TabIndex = 2;
            // 
            // richTextBox_name
            // 
            richTextBox_name.Location = new Point(80, 102);
            richTextBox_name.Name = "richTextBox_name";
            richTextBox_name.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_name.Size = new Size(585, 22);
            richTextBox_name.TabIndex = 3;
            richTextBox_name.Text = "";
            // 
            // button_Uloz_Zmeny
            // 
            button_Uloz_Zmeny.Location = new Point(372, 12);
            button_Uloz_Zmeny.Name = "button_Uloz_Zmeny";
            button_Uloz_Zmeny.Size = new Size(174, 37);
            button_Uloz_Zmeny.TabIndex = 4;
            button_Uloz_Zmeny.Text = "Ulož změny";
            button_Uloz_Zmeny.UseVisualStyleBackColor = true;
            button_Uloz_Zmeny.Click += button_Uloz_Zmeny_Click;
            // 
            // button_Reset
            // 
            button_Reset.Location = new Point(192, 12);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(174, 37);
            button_Reset.TabIndex = 5;
            button_Reset.Text = "Reset";
            button_Reset.UseVisualStyleBackColor = true;
            button_Reset.Click += button_Reset_Click;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI", 13F);
            label_Name.Location = new Point(12, 99);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(59, 25);
            label_Name.TabIndex = 6;
            label_Name.Text = "Name";
            // 
            // label_nameStreet
            // 
            label_nameStreet.AutoSize = true;
            label_nameStreet.Font = new Font("Segoe UI", 13F);
            label_nameStreet.Location = new Point(12, 130);
            label_nameStreet.Name = "label_nameStreet";
            label_nameStreet.Size = new Size(101, 25);
            label_nameStreet.TabIndex = 8;
            label_nameStreet.Text = "nameStreet";
            // 
            // label_special
            // 
            label_special.AutoSize = true;
            label_special.Font = new Font("Segoe UI", 13F);
            label_special.Location = new Point(12, 158);
            label_special.Name = "label_special";
            label_special.Size = new Size(67, 25);
            label_special.TabIndex = 10;
            label_special.Text = "Special";
            // 
            // richTextBox_nameStreet
            // 
            richTextBox_nameStreet.Location = new Point(125, 130);
            richTextBox_nameStreet.Name = "richTextBox_nameStreet";
            richTextBox_nameStreet.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_nameStreet.Size = new Size(540, 22);
            richTextBox_nameStreet.TabIndex = 13;
            richTextBox_nameStreet.Text = "";
            // 
            // richTextBox_special
            // 
            richTextBox_special.Location = new Point(85, 158);
            richTextBox_special.Name = "richTextBox_special";
            richTextBox_special.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_special.Size = new Size(580, 22);
            richTextBox_special.TabIndex = 14;
            richTextBox_special.Text = "";
            // 
            // richTextBox_directions
            // 
            richTextBox_directions.Location = new Point(101, 360);
            richTextBox_directions.Name = "richTextBox_directions";
            richTextBox_directions.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_directions.Size = new Size(564, 22);
            richTextBox_directions.TabIndex = 16;
            richTextBox_directions.Text = "";
            // 
            // textBox_place
            // 
            textBox_place.Location = new Point(70, 186);
            textBox_place.Name = "textBox_place";
            textBox_place.Size = new Size(595, 23);
            textBox_place.TabIndex = 17;
            // 
            // textBox_street
            // 
            textBox_street.Location = new Point(75, 215);
            textBox_street.Name = "textBox_street";
            textBox_street.Size = new Size(590, 23);
            textBox_street.TabIndex = 19;
            // 
            // label_street
            // 
            label_street.AutoSize = true;
            label_street.Font = new Font("Segoe UI", 13F);
            label_street.Location = new Point(12, 212);
            label_street.Name = "label_street";
            label_street.Size = new Size(57, 25);
            label_street.TabIndex = 18;
            label_street.Text = "Street";
            // 
            // textBox_city
            // 
            textBox_city.Location = new Point(60, 244);
            textBox_city.Name = "textBox_city";
            textBox_city.Size = new Size(605, 23);
            textBox_city.TabIndex = 21;
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Font = new Font("Segoe UI", 13F);
            label_city.Location = new Point(12, 241);
            label_city.Name = "label_city";
            label_city.Size = new Size(42, 25);
            label_city.TabIndex = 20;
            label_city.Text = "City";
            // 
            // textBox_zip
            // 
            textBox_zip.Location = new Point(70, 273);
            textBox_zip.Name = "textBox_zip";
            textBox_zip.Size = new Size(595, 23);
            textBox_zip.TabIndex = 23;
            // 
            // label_zip
            // 
            label_zip.AutoSize = true;
            label_zip.Font = new Font("Segoe UI", 13F);
            label_zip.Location = new Point(12, 270);
            label_zip.Name = "label_zip";
            label_zip.Size = new Size(37, 25);
            label_zip.TabIndex = 22;
            label_zip.Text = "ZIP";
            // 
            // textBox_country
            // 
            textBox_country.Location = new Point(90, 302);
            textBox_country.Name = "textBox_country";
            textBox_country.Size = new Size(575, 23);
            textBox_country.TabIndex = 25;
            // 
            // label_country
            // 
            label_country.AutoSize = true;
            label_country.Font = new Font("Segoe UI", 13F);
            label_country.Location = new Point(12, 299);
            label_country.Name = "label_country";
            label_country.Size = new Size(75, 25);
            label_country.TabIndex = 24;
            label_country.Text = "Country";
            // 
            // textBox_currency
            // 
            textBox_currency.Location = new Point(99, 331);
            textBox_currency.Name = "textBox_currency";
            textBox_currency.Size = new Size(566, 23);
            textBox_currency.TabIndex = 27;
            // 
            // label_currency
            // 
            label_currency.AutoSize = true;
            label_currency.Font = new Font("Segoe UI", 13F);
            label_currency.Location = new Point(12, 328);
            label_currency.Name = "label_currency";
            label_currency.Size = new Size(81, 25);
            label_currency.TabIndex = 26;
            label_currency.Text = "Currency";
            // 
            // textBox_wheelchairAccesible
            // 
            textBox_wheelchairAccesible.Location = new Point(185, 441);
            textBox_wheelchairAccesible.Name = "textBox_wheelchairAccesible";
            textBox_wheelchairAccesible.Size = new Size(480, 23);
            textBox_wheelchairAccesible.TabIndex = 29;
            // 
            // label_direction
            // 
            label_direction.AutoSize = true;
            label_direction.Font = new Font("Segoe UI", 13F);
            label_direction.Location = new Point(12, 357);
            label_direction.Name = "label_direction";
            label_direction.Size = new Size(83, 25);
            label_direction.TabIndex = 28;
            label_direction.Text = "Direction";
            // 
            // label_directionCar
            // 
            label_directionCar.AutoSize = true;
            label_directionCar.Font = new Font("Segoe UI", 13F);
            label_directionCar.Location = new Point(12, 385);
            label_directionCar.Name = "label_directionCar";
            label_directionCar.Size = new Size(65, 25);
            label_directionCar.TabIndex = 31;
            label_directionCar.Text = "Dir.Car";
            // 
            // richTextBox_directionsCar
            // 
            richTextBox_directionsCar.Location = new Point(83, 388);
            richTextBox_directionsCar.Name = "richTextBox_directionsCar";
            richTextBox_directionsCar.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_directionsCar.Size = new Size(582, 22);
            richTextBox_directionsCar.TabIndex = 30;
            richTextBox_directionsCar.Text = "";
            // 
            // label_directionPublic
            // 
            label_directionPublic.AutoSize = true;
            label_directionPublic.Font = new Font("Segoe UI", 13F);
            label_directionPublic.Location = new Point(12, 413);
            label_directionPublic.Name = "label_directionPublic";
            label_directionPublic.Size = new Size(86, 25);
            label_directionPublic.TabIndex = 33;
            label_directionPublic.Text = "Dir.Public";
            // 
            // richTextBox_directionsPublic
            // 
            richTextBox_directionsPublic.Location = new Point(104, 416);
            richTextBox_directionsPublic.Name = "richTextBox_directionsPublic";
            richTextBox_directionsPublic.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_directionsPublic.Size = new Size(561, 22);
            richTextBox_directionsPublic.TabIndex = 32;
            richTextBox_directionsPublic.Text = "";
            // 
            // label_wheelchairAccesible
            // 
            label_wheelchairAccesible.AutoSize = true;
            label_wheelchairAccesible.Font = new Font("Segoe UI", 13F);
            label_wheelchairAccesible.Location = new Point(12, 441);
            label_wheelchairAccesible.Name = "label_wheelchairAccesible";
            label_wheelchairAccesible.Size = new Size(167, 25);
            label_wheelchairAccesible.TabIndex = 35;
            label_wheelchairAccesible.Text = "wheelchairAccesible";
            // 
            // richTextBox_url
            // 
            richTextBox_url.Location = new Point(56, 524);
            richTextBox_url.Name = "richTextBox_url";
            richTextBox_url.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_url.Size = new Size(609, 22);
            richTextBox_url.TabIndex = 34;
            richTextBox_url.Text = "";
            // 
            // label_latitude
            // 
            label_latitude.AutoSize = true;
            label_latitude.Font = new Font("Segoe UI", 13F);
            label_latitude.Location = new Point(12, 466);
            label_latitude.Name = "label_latitude";
            label_latitude.Size = new Size(75, 25);
            label_latitude.TabIndex = 37;
            label_latitude.Text = "Latitude";
            // 
            // textBox_latitude
            // 
            textBox_latitude.Location = new Point(93, 466);
            textBox_latitude.Name = "textBox_latitude";
            textBox_latitude.Size = new Size(572, 23);
            textBox_latitude.TabIndex = 36;
            // 
            // label_longitude
            // 
            label_longitude.AutoSize = true;
            label_longitude.Font = new Font("Segoe UI", 13F);
            label_longitude.Location = new Point(12, 495);
            label_longitude.Name = "label_longitude";
            label_longitude.Size = new Size(92, 25);
            label_longitude.TabIndex = 39;
            label_longitude.Text = "Longitude";
            // 
            // textBox_longitude
            // 
            textBox_longitude.Location = new Point(110, 495);
            textBox_longitude.Name = "textBox_longitude";
            textBox_longitude.Size = new Size(555, 23);
            textBox_longitude.TabIndex = 38;
            // 
            // label_url
            // 
            label_url.AutoSize = true;
            label_url.Font = new Font("Segoe UI", 13F);
            label_url.Location = new Point(12, 524);
            label_url.Name = "label_url";
            label_url.Size = new Size(43, 25);
            label_url.TabIndex = 41;
            label_url.Text = "URL";
            // 
            // checkBox_dressingroom
            // 
            checkBox_dressingroom.AutoSize = true;
            checkBox_dressingroom.Font = new Font("Segoe UI", 13F);
            checkBox_dressingroom.Location = new Point(138, 552);
            checkBox_dressingroom.Name = "checkBox_dressingroom";
            checkBox_dressingroom.Size = new Size(144, 29);
            checkBox_dressingroom.TabIndex = 45;
            checkBox_dressingroom.Text = "Dressingroom";
            checkBox_dressingroom.UseVisualStyleBackColor = true;
            // 
            // checkBox_claimAssistant
            // 
            checkBox_claimAssistant.AutoSize = true;
            checkBox_claimAssistant.Font = new Font("Segoe UI", 13F);
            checkBox_claimAssistant.Location = new Point(138, 587);
            checkBox_claimAssistant.Name = "checkBox_claimAssistant";
            checkBox_claimAssistant.Size = new Size(146, 29);
            checkBox_claimAssistant.TabIndex = 46;
            checkBox_claimAssistant.Text = "ClaimAssistant";
            checkBox_claimAssistant.UseVisualStyleBackColor = true;
            // 
            // checkBox_packetConsignment
            // 
            checkBox_packetConsignment.AutoSize = true;
            checkBox_packetConsignment.Font = new Font("Segoe UI", 13F);
            checkBox_packetConsignment.Location = new Point(138, 622);
            checkBox_packetConsignment.Name = "checkBox_packetConsignment";
            checkBox_packetConsignment.Size = new Size(187, 29);
            checkBox_packetConsignment.TabIndex = 47;
            checkBox_packetConsignment.Text = "PacketConsignment";
            checkBox_packetConsignment.UseVisualStyleBackColor = true;
            // 
            // label_maxWeight
            // 
            label_maxWeight.AutoSize = true;
            label_maxWeight.Font = new Font("Segoe UI", 13F);
            label_maxWeight.Location = new Point(12, 657);
            label_maxWeight.Name = "label_maxWeight";
            label_maxWeight.Size = new Size(101, 25);
            label_maxWeight.TabIndex = 49;
            label_maxWeight.Text = "maxWeight";
            // 
            // textBox_maxWeight
            // 
            textBox_maxWeight.Location = new Point(119, 657);
            textBox_maxWeight.Name = "textBox_maxWeight";
            textBox_maxWeight.Size = new Size(546, 23);
            textBox_maxWeight.TabIndex = 48;
            // 
            // label_labelRouting
            // 
            label_labelRouting.AutoSize = true;
            label_labelRouting.Font = new Font("Segoe UI", 13F);
            label_labelRouting.Location = new Point(12, 686);
            label_labelRouting.Name = "label_labelRouting";
            label_labelRouting.Size = new Size(115, 25);
            label_labelRouting.TabIndex = 51;
            label_labelRouting.Text = "LabelRouting";
            // 
            // textBox_labelRouting
            // 
            textBox_labelRouting.Location = new Point(133, 686);
            textBox_labelRouting.Name = "textBox_labelRouting";
            textBox_labelRouting.Size = new Size(532, 23);
            textBox_labelRouting.TabIndex = 50;
            // 
            // label_labelName
            // 
            label_labelName.AutoSize = true;
            label_labelName.Font = new Font("Segoe UI", 13F);
            label_labelName.Location = new Point(12, 715);
            label_labelName.Name = "label_labelName";
            label_labelName.Size = new Size(100, 25);
            label_labelName.TabIndex = 53;
            label_labelName.Text = "LabelName";
            // 
            // label_place
            // 
            label_place.AutoSize = true;
            label_place.Font = new Font("Segoe UI", 13F);
            label_place.Location = new Point(12, 186);
            label_place.Name = "label_place";
            label_place.Size = new Size(52, 25);
            label_place.TabIndex = 54;
            label_place.Text = "Place";
            // 
            // richTextBox_labelName
            // 
            richTextBox_labelName.Location = new Point(118, 718);
            richTextBox_labelName.Name = "richTextBox_labelName";
            richTextBox_labelName.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_labelName.Size = new Size(547, 22);
            richTextBox_labelName.TabIndex = 55;
            richTextBox_labelName.Text = "";
            // 
            // button_Show_On_Map
            // 
            button_Show_On_Map.Location = new Point(552, 12);
            button_Show_On_Map.Name = "button_Show_On_Map";
            button_Show_On_Map.Size = new Size(174, 37);
            button_Show_On_Map.TabIndex = 56;
            button_Show_On_Map.Text = "Zobraz Mapu";
            button_Show_On_Map.UseVisualStyleBackColor = true;
            button_Show_On_Map.Click += button_Show_On_Map_Click;
            // 
            // dataGridView_openingHoursExceptions
            // 
            dataGridView_openingHoursExceptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_openingHoursExceptions.Columns.AddRange(new DataGridViewColumn[] { date, hour });
            dataGridView_openingHoursExceptions.Location = new Point(740, 238);
            dataGridView_openingHoursExceptions.Name = "dataGridView_openingHoursExceptions";
            dataGridView_openingHoursExceptions.ScrollBars = ScrollBars.Vertical;
            dataGridView_openingHoursExceptions.Size = new Size(653, 105);
            dataGridView_openingHoursExceptions.TabIndex = 57;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            date.Width = 110;
            // 
            // hour
            // 
            hour.HeaderText = "Hour";
            hour.Name = "hour";
            hour.Width = 500;
            // 
            // dataGridView_openingHours
            // 
            dataGridView_openingHours.AllowUserToAddRows = false;
            dataGridView_openingHours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_openingHours.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBox_day, dataGridViewTextBox_OpeningHoursDay });
            dataGridView_openingHours.Location = new Point(740, 102);
            dataGridView_openingHours.Name = "dataGridView_openingHours";
            dataGridView_openingHours.ScrollBars = ScrollBars.Vertical;
            dataGridView_openingHours.Size = new Size(653, 105);
            dataGridView_openingHours.TabIndex = 58;
            // 
            // dataGridViewTextBox_day
            // 
            dataGridViewTextBox_day.HeaderText = "Day";
            dataGridViewTextBox_day.Name = "dataGridViewTextBox_day";
            dataGridViewTextBox_day.ReadOnly = true;
            dataGridViewTextBox_day.Width = 110;
            // 
            // dataGridViewTextBox_OpeningHoursDay
            // 
            dataGridViewTextBox_OpeningHoursDay.HeaderText = "Opening Hours";
            dataGridViewTextBox_OpeningHoursDay.Name = "dataGridViewTextBox_OpeningHoursDay";
            dataGridViewTextBox_OpeningHoursDay.Width = 500;
            // 
            // richTextBox_compactShort
            // 
            richTextBox_compactShort.Location = new Point(145, 746);
            richTextBox_compactShort.Name = "richTextBox_compactShort";
            richTextBox_compactShort.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_compactShort.Size = new Size(520, 22);
            richTextBox_compactShort.TabIndex = 60;
            richTextBox_compactShort.Text = "";
            // 
            // label_compactShort
            // 
            label_compactShort.AutoSize = true;
            label_compactShort.Font = new Font("Segoe UI", 13F);
            label_compactShort.Location = new Point(12, 743);
            label_compactShort.Name = "label_compactShort";
            label_compactShort.Size = new Size(127, 25);
            label_compactShort.TabIndex = 59;
            label_compactShort.Text = "CompactShort";
            // 
            // richTextBox_compactLong
            // 
            richTextBox_compactLong.Location = new Point(143, 774);
            richTextBox_compactLong.Name = "richTextBox_compactLong";
            richTextBox_compactLong.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_compactLong.Size = new Size(523, 22);
            richTextBox_compactLong.TabIndex = 62;
            richTextBox_compactLong.Text = "";
            // 
            // label_compactLong
            // 
            label_compactLong.AutoSize = true;
            label_compactLong.Font = new Font("Segoe UI", 13F);
            label_compactLong.Location = new Point(13, 771);
            label_compactLong.Name = "label_compactLong";
            label_compactLong.Size = new Size(124, 25);
            label_compactLong.TabIndex = 61;
            label_compactLong.Text = "CompactLong";
            // 
            // richTextBox_tableLong
            // 
            richTextBox_tableLong.Location = new Point(110, 802);
            richTextBox_tableLong.Name = "richTextBox_tableLong";
            richTextBox_tableLong.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_tableLong.Size = new Size(555, 22);
            richTextBox_tableLong.TabIndex = 64;
            richTextBox_tableLong.Text = "";
            // 
            // label_tableLong
            // 
            label_tableLong.AutoSize = true;
            label_tableLong.Font = new Font("Segoe UI", 13F);
            label_tableLong.Location = new Point(12, 799);
            label_tableLong.Name = "label_tableLong";
            label_tableLong.Size = new Size(92, 25);
            label_tableLong.TabIndex = 63;
            label_tableLong.Text = "TableLong";
            // 
            // dataGridView_photos
            // 
            dataGridView_photos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_photos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBox_thumbnail, dataGridViewTextBox_normal });
            dataGridView_photos.Location = new Point(740, 374);
            dataGridView_photos.Name = "dataGridView_photos";
            dataGridView_photos.ScrollBars = ScrollBars.Vertical;
            dataGridView_photos.Size = new Size(653, 105);
            dataGridView_photos.TabIndex = 65;
            // 
            // dataGridViewTextBox_thumbnail
            // 
            dataGridViewTextBox_thumbnail.HeaderText = "Thumbnail";
            dataGridViewTextBox_thumbnail.Name = "dataGridViewTextBox_thumbnail";
            dataGridViewTextBox_thumbnail.Width = 305;
            // 
            // dataGridViewTextBox_normal
            // 
            dataGridViewTextBox_normal.HeaderText = "Normal";
            dataGridViewTextBox_normal.Name = "dataGridViewTextBox_normal";
            dataGridViewTextBox_normal.Width = 305;
            // 
            // label_openingHours
            // 
            label_openingHours.AutoSize = true;
            label_openingHours.Font = new Font("Segoe UI", 13F);
            label_openingHours.Location = new Point(740, 74);
            label_openingHours.Name = "label_openingHours";
            label_openingHours.Size = new Size(130, 25);
            label_openingHours.TabIndex = 66;
            label_openingHours.Text = "Otevirací Doba";
            // 
            // label_openingHoursException
            // 
            label_openingHoursException.AutoSize = true;
            label_openingHoursException.Font = new Font("Segoe UI", 13F);
            label_openingHoursException.Location = new Point(740, 210);
            label_openingHoursException.Name = "label_openingHoursException";
            label_openingHoursException.Size = new Size(189, 25);
            label_openingHoursException.TabIndex = 67;
            label_openingHoursException.Text = "Výjmečné zavírací časy";
            // 
            // label_photos
            // 
            label_photos.AutoSize = true;
            label_photos.Font = new Font("Segoe UI", 13F);
            label_photos.Location = new Point(740, 346);
            label_photos.Name = "label_photos";
            label_photos.Size = new Size(100, 25);
            label_photos.TabIndex = 68;
            label_photos.Text = "Photo links";
            // 
            // label_pom_pickupPoint_ID
            // 
            label_pom_pickupPoint_ID.AutoSize = true;
            label_pom_pickupPoint_ID.Location = new Point(1281, 9);
            label_pom_pickupPoint_ID.Name = "label_pom_pickupPoint_ID";
            label_pom_pickupPoint_ID.Size = new Size(87, 15);
            label_pom_pickupPoint_ID.TabIndex = 69;
            label_pom_pickupPoint_ID.Text = "pickupPoint_ID";
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1405, 950);
            Controls.Add(label_pom_pickupPoint_ID);
            Controls.Add(label_photos);
            Controls.Add(label_openingHoursException);
            Controls.Add(label_openingHours);
            Controls.Add(dataGridView_photos);
            Controls.Add(richTextBox_tableLong);
            Controls.Add(label_tableLong);
            Controls.Add(richTextBox_compactLong);
            Controls.Add(label_compactLong);
            Controls.Add(richTextBox_compactShort);
            Controls.Add(label_compactShort);
            Controls.Add(dataGridView_openingHours);
            Controls.Add(dataGridView_openingHoursExceptions);
            Controls.Add(button_Show_On_Map);
            Controls.Add(richTextBox_labelName);
            Controls.Add(label_place);
            Controls.Add(label_labelName);
            Controls.Add(label_labelRouting);
            Controls.Add(textBox_labelRouting);
            Controls.Add(label_maxWeight);
            Controls.Add(textBox_maxWeight);
            Controls.Add(checkBox_packetConsignment);
            Controls.Add(checkBox_claimAssistant);
            Controls.Add(checkBox_dressingroom);
            Controls.Add(label_url);
            Controls.Add(label_longitude);
            Controls.Add(textBox_longitude);
            Controls.Add(label_latitude);
            Controls.Add(textBox_latitude);
            Controls.Add(label_wheelchairAccesible);
            Controls.Add(richTextBox_url);
            Controls.Add(label_directionPublic);
            Controls.Add(richTextBox_directionsPublic);
            Controls.Add(label_directionCar);
            Controls.Add(richTextBox_directionsCar);
            Controls.Add(textBox_wheelchairAccesible);
            Controls.Add(label_direction);
            Controls.Add(textBox_currency);
            Controls.Add(label_currency);
            Controls.Add(textBox_country);
            Controls.Add(label_country);
            Controls.Add(textBox_zip);
            Controls.Add(label_zip);
            Controls.Add(textBox_city);
            Controls.Add(label_city);
            Controls.Add(textBox_street);
            Controls.Add(label_street);
            Controls.Add(textBox_place);
            Controls.Add(richTextBox_directions);
            Controls.Add(richTextBox_special);
            Controls.Add(richTextBox_nameStreet);
            Controls.Add(label_special);
            Controls.Add(label_nameStreet);
            Controls.Add(label_Name);
            Controls.Add(button_Reset);
            Controls.Add(button_Uloz_Zmeny);
            Controls.Add(richTextBox_name);
            Controls.Add(textBox_PP_ID);
            Controls.Add(button_zpet);
            Controls.Add(label_id);
            Name = "DetailsForm";
            Text = "DetailsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_openingHoursExceptions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_openingHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_photos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_id;
        private Button button_zpet;
        private TextBox textBox_PP_ID;
        private RichTextBox richTextBox_name;
        private Button button_Uloz_Zmeny;
        private Button button_Reset;
        private Label label_Name;
        private Label label_nameStreet;
        private Label label_special;
        private Label label_Place;
        private RichTextBox richTextBox_nameStreet;
        private RichTextBox richTextBox_special;
        private Label label2;
        private RichTextBox richTextBox_directions;
        private TextBox textBox_place;
        private TextBox textBox_street;
        private Label label_street;
        private TextBox textBox_city;
        private Label label_city;
        private TextBox textBox_zip;
        private Label label_zip;
        private TextBox textBox_country;
        private Label label_country;
        private TextBox textBox_currency;
        private Label label_currency;
        private TextBox textBox_wheelchairAccesible;
        private Label label_direction;
        private Label label_directionCar;
        private RichTextBox richTextBox_directionsCar;
        private Label label_directionPublic;
        private RichTextBox richTextBox_directionsPublic;
        private Label label_wheelchairAccesible;
        private RichTextBox richTextBox_url;
        private Label label_latitude;
        private TextBox textBox_latitude;
        private Label label_longitude;
        private TextBox textBox_longitude;
        private Label label_url;
        private CheckBox checkBox_dressingroom;
        private CheckBox checkBox_claimAssistant;
        private CheckBox checkBox_packetConsignment;
        private Label label_maxWeight;
        private TextBox textBox_maxWeight;
        private Label label_labelRouting;
        private TextBox textBox_labelRouting;
        private Label label_labelName;
        private Label label_place;
        private RichTextBox richTextBox_labelName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button_Show_On_Map;
        private DataGridView dataGridView_openingHoursExceptions;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn hour;
        private DataGridView dataGridView_openingHours;
        private DataGridViewTextBoxColumn dataGridViewTextBox_day;
        private DataGridViewTextBoxColumn dataGridViewTextBox_OpeningHoursDay;
        private RichTextBox richTextBox_compactShort;
        private Label label_compactShort;
        private RichTextBox richTextBox_compactLong;
        private Label label_compactLong;
        private RichTextBox richTextBox_tableLong;
        private Label label_tableLong;
        private DataGridView dataGridView_photos;
        private DataGridViewTextBoxColumn dataGridViewTextBox_thumbnail;
        private DataGridViewTextBoxColumn dataGridViewTextBox_normal;
        private Label label_openingHours;
        private Label label_openingHoursException;
        private Label label_photos;
        private Label label_pom_pickupPoint_ID;
    }
}