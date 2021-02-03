namespace EstateApp
{
    partial class MainPage
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
            this.roomTextbox = new System.Windows.Forms.TextBox();
            this.loungeTextbox = new System.Windows.Forms.TextBox();
            this.houseListview = new System.Windows.Forms.ListView();
            this.homeTypeCombobox = new System.Windows.Forms.ComboBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.loungeLabel = new System.Windows.Forms.Label();
            this.heatingLabel = new System.Windows.Forms.Label();
            this.homeTypeLabel = new System.Windows.Forms.Label();
            this.homeStatusLabel = new System.Windows.Forms.Label();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.homeStatusCombobox = new System.Windows.Forms.ComboBox();
            this.heatingCombobox = new System.Windows.Forms.ComboBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.optionOneLabel = new System.Windows.Forms.Label();
            this.optionTwoLabel = new System.Windows.Forms.Label();
            this.poolCheck = new System.Windows.Forms.CheckBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.summeryTab = new System.Windows.Forms.TabPage();
            this.viewCombobox = new System.Windows.Forms.ComboBox();
            this.privateTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.gardenCheck = new System.Windows.Forms.CheckBox();
            this.garageCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apartmentTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.balconyCheck = new System.Windows.Forms.CheckBox();
            this.floorTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.summeryTab.SuspendLayout();
            this.privateTab.SuspendLayout();
            this.apartmentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomTextbox
            // 
            this.roomTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomTextbox.Location = new System.Drawing.Point(262, 39);
            this.roomTextbox.MaxLength = 2;
            this.roomTextbox.Multiline = true;
            this.roomTextbox.Name = "roomTextbox";
            this.roomTextbox.Size = new System.Drawing.Size(192, 29);
            this.roomTextbox.TabIndex = 1;
            this.roomTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntKeyPress);
            // 
            // loungeTextbox
            // 
            this.loungeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loungeTextbox.Location = new System.Drawing.Point(262, 79);
            this.loungeTextbox.MaxLength = 2;
            this.loungeTextbox.Multiline = true;
            this.loungeTextbox.Name = "loungeTextbox";
            this.loungeTextbox.Size = new System.Drawing.Size(192, 29);
            this.loungeTextbox.TabIndex = 2;
            this.loungeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntKeyPress);
            // 
            // houseListview
            // 
            this.houseListview.FullRowSelect = true;
            this.houseListview.GridLines = true;
            this.houseListview.HideSelection = false;
            this.houseListview.Location = new System.Drawing.Point(137, 352);
            this.houseListview.Name = "houseListview";
            this.houseListview.Size = new System.Drawing.Size(828, 348);
            this.houseListview.TabIndex = 10;
            this.houseListview.UseCompatibleStateImageBehavior = false;
            this.houseListview.View = System.Windows.Forms.View.Details;
            this.houseListview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EditHouse);
            // 
            // homeTypeCombobox
            // 
            this.homeTypeCombobox.FormattingEnabled = true;
            this.homeTypeCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.homeTypeCombobox.Location = new System.Drawing.Point(262, 166);
            this.homeTypeCombobox.Name = "homeTypeCombobox";
            this.homeTypeCombobox.Size = new System.Drawing.Size(192, 24);
            this.homeTypeCombobox.TabIndex = 4;
            this.homeTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.homeTypeCombobox_SelectedIndexChanged);
            // 
            // roomLabel
            // 
            this.roomLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomLabel.Location = new System.Drawing.Point(134, 39);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(109, 29);
            this.roomLabel.TabIndex = 3;
            this.roomLabel.Text = "Oda Sayısı";
            this.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loungeLabel
            // 
            this.loungeLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.loungeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loungeLabel.Location = new System.Drawing.Point(134, 78);
            this.loungeLabel.Name = "loungeLabel";
            this.loungeLabel.Size = new System.Drawing.Size(109, 29);
            this.loungeLabel.TabIndex = 3;
            this.loungeLabel.Text = "Salon Sayısı";
            this.loungeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heatingLabel
            // 
            this.heatingLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.heatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.heatingLabel.Location = new System.Drawing.Point(133, 120);
            this.heatingLabel.Name = "heatingLabel";
            this.heatingLabel.Size = new System.Drawing.Size(109, 29);
            this.heatingLabel.TabIndex = 3;
            this.heatingLabel.Text = "Isıtma Türü";
            this.heatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeTypeLabel
            // 
            this.homeTypeLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.homeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeTypeLabel.Location = new System.Drawing.Point(134, 160);
            this.homeTypeLabel.Name = "homeTypeLabel";
            this.homeTypeLabel.Size = new System.Drawing.Size(109, 29);
            this.homeTypeLabel.TabIndex = 3;
            this.homeTypeLabel.Text = "Ev Tipi";
            this.homeTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeStatusLabel
            // 
            this.homeStatusLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.homeStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeStatusLabel.Location = new System.Drawing.Point(134, 204);
            this.homeStatusLabel.Name = "homeStatusLabel";
            this.homeStatusLabel.Size = new System.Drawing.Size(109, 29);
            this.homeStatusLabel.TabIndex = 3;
            this.homeStatusLabel.Text = "Ev Durumu";
            this.homeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceTextbox.Location = new System.Drawing.Point(262, 254);
            this.priceTextbox.MaxLength = 15;
            this.priceTextbox.Multiline = true;
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(192, 29);
            this.priceTextbox.TabIndex = 7;
            this.priceTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntKeyPress);
            // 
            // priceLabel
            // 
            this.priceLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLabel.Location = new System.Drawing.Point(134, 253);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(109, 29);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Fiyat";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.IndianRed;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.ForeColor = System.Drawing.Color.Azure;
            this.addButton.Location = new System.Drawing.Point(487, 284);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 37);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // homeStatusCombobox
            // 
            this.homeStatusCombobox.FormattingEnabled = true;
            this.homeStatusCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.homeStatusCombobox.Location = new System.Drawing.Point(262, 205);
            this.homeStatusCombobox.Name = "homeStatusCombobox";
            this.homeStatusCombobox.Size = new System.Drawing.Size(192, 24);
            this.homeStatusCombobox.TabIndex = 5;
            // 
            // heatingCombobox
            // 
            this.heatingCombobox.FormattingEnabled = true;
            this.heatingCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.heatingCombobox.Location = new System.Drawing.Point(262, 126);
            this.heatingCombobox.Name = "heatingCombobox";
            this.heatingCombobox.Size = new System.Drawing.Size(192, 24);
            this.heatingCombobox.TabIndex = 3;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTextbox.Location = new System.Drawing.Point(805, 292);
            this.searchTextbox.Multiline = true;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(160, 29);
            this.searchTextbox.TabIndex = 9;
            this.searchTextbox.TextChanged += new System.EventHandler(this.SearchBox);
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchLabel.Location = new System.Drawing.Point(805, 260);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(160, 23);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Arama";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.ForeColor = System.Drawing.Color.Azure;
            this.deleteButton.Location = new System.Drawing.Point(861, 714);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 37);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // optionOneLabel
            // 
            this.optionOneLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.optionOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.optionOneLabel.Location = new System.Drawing.Point(21, 56);
            this.optionOneLabel.Name = "optionOneLabel";
            this.optionOneLabel.Size = new System.Drawing.Size(109, 29);
            this.optionOneLabel.TabIndex = 3;
            this.optionOneLabel.Text = "Havuz";
            this.optionOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionTwoLabel
            // 
            this.optionTwoLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.optionTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.optionTwoLabel.Location = new System.Drawing.Point(21, 95);
            this.optionTwoLabel.Name = "optionTwoLabel";
            this.optionTwoLabel.Size = new System.Drawing.Size(109, 29);
            this.optionTwoLabel.TabIndex = 3;
            this.optionTwoLabel.Text = "Manzara";
            this.optionTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poolCheck
            // 
            this.poolCheck.AutoSize = true;
            this.poolCheck.Location = new System.Drawing.Point(149, 59);
            this.poolCheck.Name = "poolCheck";
            this.poolCheck.Size = new System.Drawing.Size(52, 21);
            this.poolCheck.TabIndex = 12;
            this.poolCheck.Text = "Var";
            this.poolCheck.UseVisualStyleBackColor = true;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.summeryTab);
            this.tab.Controls.Add(this.privateTab);
            this.tab.Controls.Add(this.apartmentTab);
            this.tab.Location = new System.Drawing.Point(477, 39);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(299, 217);
            this.tab.TabIndex = 13;
            // 
            // summeryTab
            // 
            this.summeryTab.Controls.Add(this.optionOneLabel);
            this.summeryTab.Controls.Add(this.poolCheck);
            this.summeryTab.Controls.Add(this.optionTwoLabel);
            this.summeryTab.Controls.Add(this.viewCombobox);
            this.summeryTab.Location = new System.Drawing.Point(4, 25);
            this.summeryTab.Name = "summeryTab";
            this.summeryTab.Padding = new System.Windows.Forms.Padding(3);
            this.summeryTab.Size = new System.Drawing.Size(291, 188);
            this.summeryTab.TabIndex = 0;
            this.summeryTab.Text = "Yazlık";
            this.summeryTab.UseVisualStyleBackColor = true;
            // 
            // viewCombobox
            // 
            this.viewCombobox.FormattingEnabled = true;
            this.viewCombobox.Items.AddRange(new object[] {
            "Yazlik",
            "Apartman",
            "Mustakil"});
            this.viewCombobox.Location = new System.Drawing.Point(149, 100);
            this.viewCombobox.Name = "viewCombobox";
            this.viewCombobox.Size = new System.Drawing.Size(121, 24);
            this.viewCombobox.TabIndex = 5;
            // 
            // privateTab
            // 
            this.privateTab.Controls.Add(this.label2);
            this.privateTab.Controls.Add(this.gardenCheck);
            this.privateTab.Controls.Add(this.garageCheck);
            this.privateTab.Controls.Add(this.label3);
            this.privateTab.Location = new System.Drawing.Point(4, 25);
            this.privateTab.Name = "privateTab";
            this.privateTab.Padding = new System.Windows.Forms.Padding(3);
            this.privateTab.Size = new System.Drawing.Size(291, 188);
            this.privateTab.TabIndex = 1;
            this.privateTab.Text = "Müstakil";
            this.privateTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Garaj ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gardenCheck
            // 
            this.gardenCheck.AutoSize = true;
            this.gardenCheck.Location = new System.Drawing.Point(178, 102);
            this.gardenCheck.Name = "gardenCheck";
            this.gardenCheck.Size = new System.Drawing.Size(52, 21);
            this.gardenCheck.TabIndex = 16;
            this.gardenCheck.Text = "Var";
            this.gardenCheck.UseVisualStyleBackColor = true;
            // 
            // garageCheck
            // 
            this.garageCheck.AutoSize = true;
            this.garageCheck.Location = new System.Drawing.Point(178, 63);
            this.garageCheck.Name = "garageCheck";
            this.garageCheck.Size = new System.Drawing.Size(52, 21);
            this.garageCheck.TabIndex = 16;
            this.garageCheck.Text = "Var";
            this.garageCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bahçe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apartmentTab
            // 
            this.apartmentTab.Controls.Add(this.label4);
            this.apartmentTab.Controls.Add(this.balconyCheck);
            this.apartmentTab.Controls.Add(this.floorTextbox);
            this.apartmentTab.Controls.Add(this.label5);
            this.apartmentTab.Location = new System.Drawing.Point(4, 25);
            this.apartmentTab.Name = "apartmentTab";
            this.apartmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.apartmentTab.Size = new System.Drawing.Size(291, 188);
            this.apartmentTab.TabIndex = 2;
            this.apartmentTab.Text = "Apartman";
            this.apartmentTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Balkon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balconyCheck
            // 
            this.balconyCheck.AutoSize = true;
            this.balconyCheck.Location = new System.Drawing.Point(144, 63);
            this.balconyCheck.Name = "balconyCheck";
            this.balconyCheck.Size = new System.Drawing.Size(52, 21);
            this.balconyCheck.TabIndex = 20;
            this.balconyCheck.Text = "Var";
            this.balconyCheck.UseVisualStyleBackColor = true;
            // 
            // floorTextbox
            // 
            this.floorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floorTextbox.Location = new System.Drawing.Point(144, 100);
            this.floorTextbox.MaxLength = 2;
            this.floorTextbox.Multiline = true;
            this.floorTextbox.Name = "floorTextbox";
            this.floorTextbox.Size = new System.Drawing.Size(129, 29);
            this.floorTextbox.TabIndex = 17;
            this.floorTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntKeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PeachPuff;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1121, 772);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.homeStatusLabel);
            this.Controls.Add(this.homeTypeLabel);
            this.Controls.Add(this.heatingLabel);
            this.Controls.Add(this.loungeLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.heatingCombobox);
            this.Controls.Add(this.homeStatusCombobox);
            this.Controls.Add(this.homeTypeCombobox);
            this.Controls.Add(this.houseListview);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.loungeTextbox);
            this.Controls.Add(this.roomTextbox);
            this.Name = "MainPage";
            this.Text = "Emlak Otomasyonu";
            this.tab.ResumeLayout(false);
            this.summeryTab.ResumeLayout(false);
            this.summeryTab.PerformLayout();
            this.privateTab.ResumeLayout(false);
            this.privateTab.PerformLayout();
            this.apartmentTab.ResumeLayout(false);
            this.apartmentTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomTextbox;
        private System.Windows.Forms.TextBox loungeTextbox;
        private System.Windows.Forms.ListView houseListview;
        private System.Windows.Forms.ComboBox homeTypeCombobox;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label loungeLabel;
        private System.Windows.Forms.Label heatingLabel;
        private System.Windows.Forms.Label homeTypeLabel;
        private System.Windows.Forms.Label homeStatusLabel;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox homeStatusCombobox;
        private System.Windows.Forms.ComboBox heatingCombobox;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label optionOneLabel;
        private System.Windows.Forms.Label optionTwoLabel;
        private System.Windows.Forms.CheckBox poolCheck;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage summeryTab;
        private System.Windows.Forms.TabPage privateTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox garageCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage apartmentTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox balconyCheck;
        private System.Windows.Forms.TextBox floorTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox gardenCheck;
        private System.Windows.Forms.ComboBox viewCombobox;
    }
}

