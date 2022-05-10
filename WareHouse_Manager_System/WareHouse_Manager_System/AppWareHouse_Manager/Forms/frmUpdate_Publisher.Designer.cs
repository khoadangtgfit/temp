
namespace AppWareHouse_Manager
{
    partial class frmUpdate_Publisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate_Publisher));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPublisher_ID = new System.Windows.Forms.TextBox();
            this.lblPublisher_ID = new System.Windows.Forms.Label();
            this.txtPublisher_Name = new System.Windows.Forms.TextBox();
            this.lblPublisher_Name = new System.Windows.Forms.Label();
            this.txtPublisher_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPublisher_PhoneNumber = new System.Windows.Forms.Label();
            this.txtPublisher_Address = new System.Windows.Forms.TextBox();
            this.lblPublisher_Address = new System.Windows.Forms.Label();
            this.pbAddImage = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.panelOne = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelTwo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWarningOne = new System.Windows.Forms.Label();
            this.lblWarningTwo = new System.Windows.Forms.Label();
            this.lblWarningThree = new System.Windows.Forms.Label();
            this.lblWarningFour = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(323, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(199, 399);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPublisher_ID
            // 
            this.txtPublisher_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisher_ID.Location = new System.Drawing.Point(269, 68);
            this.txtPublisher_ID.Name = "txtPublisher_ID";
            this.txtPublisher_ID.Size = new System.Drawing.Size(275, 19);
            this.txtPublisher_ID.TabIndex = 0;
            // 
            // lblPublisher_ID
            // 
            this.lblPublisher_ID.AutoSize = true;
            this.lblPublisher_ID.Location = new System.Drawing.Point(34, 70);
            this.lblPublisher_ID.Name = "lblPublisher_ID";
            this.lblPublisher_ID.Size = new System.Drawing.Size(160, 20);
            this.lblPublisher_ID.TabIndex = 8;
            this.lblPublisher_ID.Text = "Mã số nhà cung cấp :";
            // 
            // txtPublisher_Name
            // 
            this.txtPublisher_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisher_Name.Location = new System.Drawing.Point(269, 158);
            this.txtPublisher_Name.Name = "txtPublisher_Name";
            this.txtPublisher_Name.Size = new System.Drawing.Size(275, 19);
            this.txtPublisher_Name.TabIndex = 1;
            // 
            // lblPublisher_Name
            // 
            this.lblPublisher_Name.AutoSize = true;
            this.lblPublisher_Name.Location = new System.Drawing.Point(34, 158);
            this.lblPublisher_Name.Name = "lblPublisher_Name";
            this.lblPublisher_Name.Size = new System.Drawing.Size(144, 20);
            this.lblPublisher_Name.TabIndex = 9;
            this.lblPublisher_Name.Text = "Tên nhà cung cấp :";
            // 
            // txtPublisher_PhoneNumber
            // 
            this.txtPublisher_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisher_PhoneNumber.Location = new System.Drawing.Point(269, 245);
            this.txtPublisher_PhoneNumber.Name = "txtPublisher_PhoneNumber";
            this.txtPublisher_PhoneNumber.Size = new System.Drawing.Size(275, 19);
            this.txtPublisher_PhoneNumber.TabIndex = 2;
            // 
            // lblPublisher_PhoneNumber
            // 
            this.lblPublisher_PhoneNumber.AutoSize = true;
            this.lblPublisher_PhoneNumber.Location = new System.Drawing.Point(34, 247);
            this.lblPublisher_PhoneNumber.Name = "lblPublisher_PhoneNumber";
            this.lblPublisher_PhoneNumber.Size = new System.Drawing.Size(210, 20);
            this.lblPublisher_PhoneNumber.TabIndex = 10;
            this.lblPublisher_PhoneNumber.Text = "Số điện thoại nhà cung cấp :";
            // 
            // txtPublisher_Address
            // 
            this.txtPublisher_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisher_Address.Location = new System.Drawing.Point(273, 329);
            this.txtPublisher_Address.Name = "txtPublisher_Address";
            this.txtPublisher_Address.Size = new System.Drawing.Size(275, 19);
            this.txtPublisher_Address.TabIndex = 3;
            // 
            // lblPublisher_Address
            // 
            this.lblPublisher_Address.AutoSize = true;
            this.lblPublisher_Address.Location = new System.Drawing.Point(34, 329);
            this.lblPublisher_Address.Name = "lblPublisher_Address";
            this.lblPublisher_Address.Size = new System.Drawing.Size(165, 20);
            this.lblPublisher_Address.TabIndex = 11;
            this.lblPublisher_Address.Text = "Địa chỉ nhà cung cấp :";
            // 
            // pbAddImage
            // 
            this.pbAddImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAddImage.Image = ((System.Drawing.Image)(resources.GetObject("pbAddImage.Image")));
            this.pbAddImage.Location = new System.Drawing.Point(617, 64);
            this.pbAddImage.Name = "pbAddImage";
            this.pbAddImage.Size = new System.Drawing.Size(345, 285);
            this.pbAddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddImage.TabIndex = 17;
            this.pbAddImage.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.AutoSize = true;
            this.btnAddImage.Location = new System.Drawing.Point(752, 399);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(88, 30);
            this.btnAddImage.TabIndex = 4;
            this.btnAddImage.Text = "Chọn ảnh";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // panelOne
            // 
            this.panelOne.BackColor = System.Drawing.Color.Black;
            this.panelOne.Location = new System.Drawing.Point(269, 89);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(275, 1);
            this.panelOne.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(273, 348);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(275, 1);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(269, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 1);
            this.panel2.TabIndex = 19;
            // 
            // PanelTwo
            // 
            this.PanelTwo.BackColor = System.Drawing.Color.Black;
            this.PanelTwo.Location = new System.Drawing.Point(269, 177);
            this.PanelTwo.Name = "PanelTwo";
            this.PanelTwo.Size = new System.Drawing.Size(275, 1);
            this.PanelTwo.TabIndex = 0;
            // 
            // lblWarningOne
            // 
            this.lblWarningOne.AutoSize = true;
            this.lblWarningOne.ForeColor = System.Drawing.Color.Red;
            this.lblWarningOne.Location = new System.Drawing.Point(269, 19);
            this.lblWarningOne.Name = "lblWarningOne";
            this.lblWarningOne.Size = new System.Drawing.Size(0, 20);
            this.lblWarningOne.TabIndex = 20;
            // 
            // lblWarningTwo
            // 
            this.lblWarningTwo.AutoSize = true;
            this.lblWarningTwo.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTwo.Location = new System.Drawing.Point(269, 109);
            this.lblWarningTwo.Name = "lblWarningTwo";
            this.lblWarningTwo.Size = new System.Drawing.Size(0, 20);
            this.lblWarningTwo.TabIndex = 20;
            // 
            // lblWarningThree
            // 
            this.lblWarningThree.AutoSize = true;
            this.lblWarningThree.ForeColor = System.Drawing.Color.Red;
            this.lblWarningThree.Location = new System.Drawing.Point(269, 195);
            this.lblWarningThree.Name = "lblWarningThree";
            this.lblWarningThree.Size = new System.Drawing.Size(0, 20);
            this.lblWarningThree.TabIndex = 20;
            // 
            // lblWarningFour
            // 
            this.lblWarningFour.AutoSize = true;
            this.lblWarningFour.ForeColor = System.Drawing.Color.Red;
            this.lblWarningFour.Location = new System.Drawing.Point(265, 283);
            this.lblWarningFour.Name = "lblWarningFour";
            this.lblWarningFour.Size = new System.Drawing.Size(0, 20);
            this.lblWarningFour.TabIndex = 20;
            // 
            // frmUpdate_Publisher
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.lblWarningFour);
            this.Controls.Add(this.lblWarningThree);
            this.Controls.Add(this.lblWarningTwo);
            this.Controls.Add(this.lblWarningOne);
            this.Controls.Add(this.PanelTwo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelOne);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.pbAddImage);
            this.Controls.Add(this.txtPublisher_ID);
            this.Controls.Add(this.lblPublisher_ID);
            this.Controls.Add(this.txtPublisher_Name);
            this.Controls.Add(this.lblPublisher_Name);
            this.Controls.Add(this.txtPublisher_PhoneNumber);
            this.Controls.Add(this.lblPublisher_PhoneNumber);
            this.Controls.Add(this.txtPublisher_Address);
            this.Controls.Add(this.lblPublisher_Address);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmUpdate_Publisher";
            this.Text = "Update Publisher";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPublisher_ID;
        private System.Windows.Forms.Label lblPublisher_ID;
        private System.Windows.Forms.TextBox txtPublisher_Name;
        private System.Windows.Forms.Label lblPublisher_Name;
        private System.Windows.Forms.TextBox txtPublisher_PhoneNumber;
        private System.Windows.Forms.Label lblPublisher_PhoneNumber;
        private System.Windows.Forms.TextBox txtPublisher_Address;
        private System.Windows.Forms.Label lblPublisher_Address;
        private System.Windows.Forms.PictureBox pbAddImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Panel panelOne;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel PanelTwo;
        private System.Windows.Forms.Label lblWarningOne;
        private System.Windows.Forms.Label lblWarningTwo;
        private System.Windows.Forms.Label lblWarningThree;
        private System.Windows.Forms.Label lblWarningFour;
    }
}