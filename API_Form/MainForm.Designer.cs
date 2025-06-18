namespace API_Form
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
            button_Exit = new Button();
            button_Erase_DB_and_load_API_data_to_DB = new Button();
            button_Search_Zasilkovna = new Button();
            SuspendLayout();
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(305, 401);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(174, 37);
            button_Exit.TabIndex = 0;
            button_Exit.Text = "Exit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // button_Erase_DB_and_load_API_data_to_DB
            // 
            button_Erase_DB_and_load_API_data_to_DB.Location = new Point(305, 12);
            button_Erase_DB_and_load_API_data_to_DB.Name = "button_Erase_DB_and_load_API_data_to_DB";
            button_Erase_DB_and_load_API_data_to_DB.Size = new Size(174, 37);
            button_Erase_DB_and_load_API_data_to_DB.TabIndex = 1;
            button_Erase_DB_and_load_API_data_to_DB.Text = "Nacti API do DB";
            button_Erase_DB_and_load_API_data_to_DB.UseVisualStyleBackColor = true;
            button_Erase_DB_and_load_API_data_to_DB.Click += button_Erase_DB_and_load_API_data_to_DB_Click;
            // 
            // button_Search_Zasilkovna
            // 
            button_Search_Zasilkovna.Location = new Point(305, 55);
            button_Search_Zasilkovna.Name = "button_Search_Zasilkovna";
            button_Search_Zasilkovna.Size = new Size(174, 37);
            button_Search_Zasilkovna.TabIndex = 2;
            button_Search_Zasilkovna.Text = "Vyhledej Zasilkovnu";
            button_Search_Zasilkovna.UseVisualStyleBackColor = true;
            button_Search_Zasilkovna.Click += button_Search_Zasilkovna_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Search_Zasilkovna);
            Controls.Add(button_Erase_DB_and_load_API_data_to_DB);
            Controls.Add(button_Exit);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Exit;
        private Button button_Erase_DB_and_load_API_data_to_DB;
        private Button button_Search_Zasilkovna;
    }
}
