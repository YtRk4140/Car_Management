namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            IbCarID = new Label();
            IbCarName = new Label();
            IbManufacturer = new Label();
            IbPrice = new Label();
            IbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            dgvCarList = new DataGridView();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // IbCarID
            // 
            IbCarID.AutoSize = true;
            IbCarID.Location = new Point(36, 35);
            IbCarID.Name = "IbCarID";
            IbCarID.Size = new Size(46, 20);
            IbCarID.TabIndex = 0;
            IbCarID.Text = "CarID";
            // 
            // IbCarName
            // 
            IbCarName.AutoSize = true;
            IbCarName.Location = new Point(36, 77);
            IbCarName.Name = "IbCarName";
            IbCarName.Size = new Size(71, 20);
            IbCarName.TabIndex = 1;
            IbCarName.Text = "CarName";
            // 
            // IbManufacturer
            // 
            IbManufacturer.AutoSize = true;
            IbManufacturer.Location = new Point(36, 122);
            IbManufacturer.Name = "IbManufacturer";
            IbManufacturer.Size = new Size(97, 20);
            IbManufacturer.TabIndex = 2;
            IbManufacturer.Text = "Manufacturer";
            // 
            // IbPrice
            // 
            IbPrice.AutoSize = true;
            IbPrice.Location = new Point(417, 35);
            IbPrice.Name = "IbPrice";
            IbPrice.Size = new Size(41, 20);
            IbPrice.TabIndex = 3;
            IbPrice.Text = "Price";
            // 
            // IbReleaseYear
            // 
            IbReleaseYear.AutoSize = true;
            IbReleaseYear.Location = new Point(417, 77);
            IbReleaseYear.Name = "IbReleaseYear";
            IbReleaseYear.Size = new Size(92, 20);
            IbReleaseYear.TabIndex = 4;
            IbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(135, 32);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(253, 27);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(135, 74);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(253, 27);
            txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(135, 119);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(253, 27);
            txtManufacturer.TabIndex = 7;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(518, 74);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(253, 27);
            txtReleaseYear.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(518, 32);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(253, 27);
            txtPrice.TabIndex = 9;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(7, 197);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.Size = new Size(836, 230);
            dgvCarList.TabIndex = 10;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(135, 161);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 30);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(354, 161);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 30);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(576, 161);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 30);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(354, 433);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 30);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 469);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvCarList);
            Controls.Add(txtPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(IbReleaseYear);
            Controls.Add(IbPrice);
            Controls.Add(IbManufacturer);
            Controls.Add(IbCarName);
            Controls.Add(IbCarID);
            Name = "frmCarManagement";
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbCarID;
        private Label IbCarName;
        private Label IbManufacturer;
        private Label IbPrice;
        private Label IbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private DataGridView dgvCarList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
    }
}