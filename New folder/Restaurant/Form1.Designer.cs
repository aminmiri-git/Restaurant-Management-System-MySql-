namespace Restaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.panelAddCustomer = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.savecustomerbutton = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.panelCreateOrder = new System.Windows.Forms.Panel();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSEARCH = new System.Windows.Forms.Button();
            this.listBoxsearch = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAddCustomer.SuspendLayout();
            this.panelCreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(1059, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test DB Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(619, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show DATA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(780, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 375);
            this.dataGridView1.TabIndex = 2;
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.BackColor = System.Drawing.Color.DarkOrange;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(492, 387);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTables.TabIndex = 3;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddCustomer.BackgroundImage")));
            this.buttonAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddCustomer.Location = new System.Drawing.Point(14, 53);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(144, 122);
            this.buttonAddCustomer.TabIndex = 4;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCreateOrder.BackgroundImage")));
            this.buttonCreateOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateOrder.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateOrder.Location = new System.Drawing.Point(14, 203);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(144, 122);
            this.buttonCreateOrder.TabIndex = 5;
            this.buttonCreateOrder.Text = "Create Order";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // panelAddCustomer
            // 
            this.panelAddCustomer.Controls.Add(this.label5);
            this.panelAddCustomer.Controls.Add(this.label4);
            this.panelAddCustomer.Controls.Add(this.label3);
            this.panelAddCustomer.Controls.Add(this.label2);
            this.panelAddCustomer.Controls.Add(this.savecustomerbutton);
            this.panelAddCustomer.Controls.Add(this.Address);
            this.panelAddCustomer.Controls.Add(this.Email);
            this.panelAddCustomer.Controls.Add(this.Phone);
            this.panelAddCustomer.Controls.Add(this.Name);
            this.panelAddCustomer.Location = new System.Drawing.Point(186, 53);
            this.panelAddCustomer.Name = "panelAddCustomer";
            this.panelAddCustomer.Size = new System.Drawing.Size(576, 122);
            this.panelAddCustomer.TabIndex = 7;
            this.panelAddCustomer.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // savecustomerbutton
            // 
            this.savecustomerbutton.Location = new System.Drawing.Point(216, 96);
            this.savecustomerbutton.Name = "savecustomerbutton";
            this.savecustomerbutton.Size = new System.Drawing.Size(94, 23);
            this.savecustomerbutton.TabIndex = 4;
            this.savecustomerbutton.Text = "Save Customer";
            this.savecustomerbutton.UseVisualStyleBackColor = true;
            this.savecustomerbutton.Click += new System.EventHandler(this.savecustomerbutton_Click);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(361, 29);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 20);
            this.Address.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(255, 29);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 2;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(149, 29);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 20);
            this.Phone.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(43, 29);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 0;
            // 
            // panelCreateOrder
            // 
            this.panelCreateOrder.Controls.Add(this.numericUpDownQuantity);
            this.panelCreateOrder.Controls.Add(this.labelItemPrice);
            this.panelCreateOrder.Controls.Add(this.listBoxMenu);
            this.panelCreateOrder.Controls.Add(this.buttonSaveOrder);
            this.panelCreateOrder.Controls.Add(this.label1);
            this.panelCreateOrder.Controls.Add(this.comboBoxCustomers);
            this.panelCreateOrder.Location = new System.Drawing.Point(186, 203);
            this.panelCreateOrder.Name = "panelCreateOrder";
            this.panelCreateOrder.Size = new System.Drawing.Size(576, 122);
            this.panelCreateOrder.TabIndex = 8;
            this.panelCreateOrder.Visible = false;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(229, 27);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 7;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.Location = new System.Drawing.Point(230, 87);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(36, 13);
            this.labelItemPrice.TabIndex = 6;
            this.labelItemPrice.Text = "Price";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(17, 24);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMenu.Size = new System.Drawing.Size(207, 82);
            this.listBoxMenu.TabIndex = 5;
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxMenu_SelectedIndexChanged);
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveOrder.Location = new System.Drawing.Point(427, 87);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(122, 23);
            this.buttonSaveOrder.TabIndex = 4;
            this.buttonSaveOrder.Text = "Save Order";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            this.buttonSaveOrder.Click += new System.EventHandler(this.buttonSaveOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Customer";
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.BackColor = System.Drawing.Color.DarkOrange;
            this.comboBoxCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(427, 37);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustomers.TabIndex = 0;
            // 
            // listBoxData
            // 
            this.listBoxData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(780, 506);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(502, 121);
            this.listBoxData.TabIndex = 10;
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteRow.Location = new System.Drawing.Point(671, 604);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRow.TabIndex = 11;
            this.buttonDeleteRow.Text = "Delete";
            this.buttonDeleteRow.UseVisualStyleBackColor = true;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLoadData.BackgroundImage")));
            this.buttonLoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoadData.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadData.Location = new System.Drawing.Point(619, 506);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(127, 46);
            this.buttonLoadData.TabIndex = 12;
            this.buttonLoadData.Text = "Show DATA (DEL)";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(14, 464);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(180, 20);
            this.textBoxSearch.TabIndex = 13;
            // 
            // buttonSEARCH
            // 
            this.buttonSEARCH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSEARCH.BackgroundImage")));
            this.buttonSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSEARCH.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSEARCH.Location = new System.Drawing.Point(14, 490);
            this.buttonSEARCH.Name = "buttonSEARCH";
            this.buttonSEARCH.Size = new System.Drawing.Size(102, 32);
            this.buttonSEARCH.TabIndex = 14;
            this.buttonSEARCH.Text = "Search";
            this.buttonSEARCH.UseVisualStyleBackColor = true;
            this.buttonSEARCH.Click += new System.EventHandler(this.buttonSEARCH_Click);
            // 
            // listBoxsearch
            // 
            this.listBoxsearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxsearch.FormattingEnabled = true;
            this.listBoxsearch.Location = new System.Drawing.Point(14, 532);
            this.listBoxsearch.Name = "listBoxsearch";
            this.listBoxsearch.Size = new System.Drawing.Size(421, 95);
            this.listBoxsearch.TabIndex = 15;
            this.listBoxsearch.SelectedIndexChanged += new System.EventHandler(this.listBoxsearch_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(14, 633);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(335, 633);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 19;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(229, 633);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 20;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(120, 633);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 21;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(360, 659);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveChanges.TabIndex = 22;
            this.buttonSaveChanges.Text = "Save";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(14, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Clear Panels";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1564, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1564, 780);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxsearch);
            this.Controls.Add(this.buttonSEARCH);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.panelCreateOrder);
            this.Controls.Add(this.panelAddCustomer);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAddCustomer.ResumeLayout(false);
            this.panelAddCustomer.PerformLayout();
            this.panelCreateOrder.ResumeLayout(false);
            this.panelCreateOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Panel panelAddCustomer;
        private System.Windows.Forms.Panel panelCreateOrder;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button savecustomerbutton;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSEARCH;
        private System.Windows.Forms.ListBox listBoxsearch;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

