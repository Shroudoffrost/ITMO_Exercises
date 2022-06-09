namespace CustomerManager
{
    partial class CustomerViewer
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
            if(disposing && (components != null))
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.orderlistBox = new System.Windows.Forms.ListBox();
            this.customerList = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.labellastName = new System.Windows.Forms.Label();
            this.labelmail = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.labelphoto = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.OrderradioButton = new System.Windows.Forms.RadioButton();
            this.CustomerradioButton = new System.Windows.Forms.RadioButton();
            this.groupBoxinfo = new System.Windows.Forms.GroupBox();
            this.ViporderradioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBoxinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Location = new System.Drawing.Point(0, 208);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(800, 242);
            this.GridView.TabIndex = 0;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(300, 15);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 20);
            this.textBoxname.TabIndex = 1;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(300, 41);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(100, 20);
            this.textBoxlastname.TabIndex = 1;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(300, 67);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxmail.TabIndex = 1;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(300, 93);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(100, 20);
            this.textBoxage.TabIndex = 1;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(540, 9);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(106, 53);
            this.buttonOut.TabIndex = 2;
            this.buttonOut.Text = "Show info";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(652, 9);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(136, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(652, 39);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(136, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(300, 119);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(100, 49);
            this.buttonFile.TabIndex = 2;
            this.buttonFile.Text = "Choose file";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(493, 148);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(283, 20);
            this.textBoxCustomer.TabIndex = 1;
            // 
            // orderlistBox
            // 
            this.orderlistBox.FormattingEnabled = true;
            this.orderlistBox.Location = new System.Drawing.Point(26, 56);
            this.orderlistBox.Name = "orderlistBox";
            this.orderlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.orderlistBox.Size = new System.Drawing.Size(168, 134);
            this.orderlistBox.TabIndex = 3;
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(26, 22);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(168, 21);
            this.customerList.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(416, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 53);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add info";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(233, 18);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(35, 13);
            this.labelname.TabIndex = 5;
            this.labelname.Text = "Name";
            // 
            // labellastName
            // 
            this.labellastName.AutoSize = true;
            this.labellastName.Location = new System.Drawing.Point(233, 44);
            this.labellastName.Name = "labellastName";
            this.labellastName.Size = new System.Drawing.Size(56, 13);
            this.labellastName.TabIndex = 5;
            this.labellastName.Text = "Last name";
            // 
            // labelmail
            // 
            this.labelmail.AutoSize = true;
            this.labelmail.Location = new System.Drawing.Point(233, 70);
            this.labelmail.Name = "labelmail";
            this.labelmail.Size = new System.Drawing.Size(26, 13);
            this.labelmail.TabIndex = 5;
            this.labelmail.Text = "Mail";
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Location = new System.Drawing.Point(233, 96);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(26, 13);
            this.labelage.TabIndex = 5;
            this.labelage.Text = "Age";
            // 
            // labelphoto
            // 
            this.labelphoto.AutoSize = true;
            this.labelphoto.Location = new System.Drawing.Point(233, 137);
            this.labelphoto.Name = "labelphoto";
            this.labelphoto.Size = new System.Drawing.Size(35, 13);
            this.labelphoto.TabIndex = 5;
            this.labelphoto.Text = "Photo";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(460, 151);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(18, 13);
            this.labelid.TabIndex = 5;
            this.labelid.Text = "ID";
            // 
            // OrderradioButton
            // 
            this.OrderradioButton.AutoSize = true;
            this.OrderradioButton.Location = new System.Drawing.Point(98, 17);
            this.OrderradioButton.Name = "OrderradioButton";
            this.OrderradioButton.Size = new System.Drawing.Size(56, 17);
            this.OrderradioButton.TabIndex = 6;
            this.OrderradioButton.TabStop = true;
            this.OrderradioButton.Text = "Orders";
            this.OrderradioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerradioButton
            // 
            this.CustomerradioButton.AutoSize = true;
            this.CustomerradioButton.Location = new System.Drawing.Point(18, 17);
            this.CustomerradioButton.Name = "CustomerradioButton";
            this.CustomerradioButton.Size = new System.Drawing.Size(74, 17);
            this.CustomerradioButton.TabIndex = 6;
            this.CustomerradioButton.TabStop = true;
            this.CustomerradioButton.Text = "Customers";
            this.CustomerradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxinfo
            // 
            this.groupBoxinfo.Controls.Add(this.CustomerradioButton);
            this.groupBoxinfo.Controls.Add(this.ViporderradioButton);
            this.groupBoxinfo.Controls.Add(this.OrderradioButton);
            this.groupBoxinfo.Location = new System.Drawing.Point(481, 93);
            this.groupBoxinfo.Name = "groupBoxinfo";
            this.groupBoxinfo.Size = new System.Drawing.Size(295, 40);
            this.groupBoxinfo.TabIndex = 7;
            this.groupBoxinfo.TabStop = false;
            this.groupBoxinfo.Text = "Info about";
            // 
            // ViporderradioButton
            // 
            this.ViporderradioButton.AutoSize = true;
            this.ViporderradioButton.Location = new System.Drawing.Point(184, 17);
            this.ViporderradioButton.Name = "ViporderradioButton";
            this.ViporderradioButton.Size = new System.Drawing.Size(74, 17);
            this.ViporderradioButton.TabIndex = 6;
            this.ViporderradioButton.TabStop = true;
            this.ViporderradioButton.Text = "VIP orders";
            this.ViporderradioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxinfo);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelphoto);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.labelmail);
            this.Controls.Add(this.labellastName);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.orderlistBox);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.GridView);
            this.Name = "CustomerViewer";
            this.Text = "Customer viewer";
            this.Load += new System.EventHandler(this.CustomerViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBoxinfo.ResumeLayout(false);
            this.groupBoxinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.ListBox orderlistBox;
        private System.Windows.Forms.ComboBox customerList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labellastName;
        private System.Windows.Forms.Label labelmail;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.Label labelphoto;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.RadioButton OrderradioButton;
        private System.Windows.Forms.RadioButton CustomerradioButton;
        private System.Windows.Forms.GroupBox groupBoxinfo;
        private System.Windows.Forms.RadioButton ViporderradioButton;
    }
}

