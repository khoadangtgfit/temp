
namespace AppWareHouse_Manager
{
    partial class frmUpdate_Supply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate_Supply));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSupply_Quantity = new System.Windows.Forms.TextBox();
            this.txtSupply_Name = new System.Windows.Forms.TextBox();
            this.txtSupply_ID = new System.Windows.Forms.TextBox();
            this.txtSupply_Unit = new System.Windows.Forms.TextBox();
            this.lblSupply_Category_ID = new System.Windows.Forms.Label();
            this.lblSupply_Unit = new System.Windows.Forms.Label();
            this.lblSupply_Quantity = new System.Windows.Forms.Label();
            this.lblSupply_Name = new System.Windows.Forms.Label();
            this.lblSupply_ID = new System.Windows.Forms.Label();
            this.lblPublisher_ID = new System.Windows.Forms.Label();
            this.cmbSupply_Category_Name = new System.Windows.Forms.ComboBox();
            this.cmbPublisher_Name = new System.Windows.Forms.ComboBox();
            this.lblWarningOne = new System.Windows.Forms.Label();
            this.lblWarningTwo = new System.Windows.Forms.Label();
            this.lblWarningThree = new System.Windows.Forms.Label();
            this.lblWarningFour = new System.Windows.Forms.Label();
            this.btnNewSupply_Category = new System.Windows.Forms.Button();
            this.btnNewPublisher = new System.Windows.Forms.Button();
            this.panelOne = new System.Windows.Forms.Panel();
            this.panelTwo = new System.Windows.Forms.Panel();
            this.panelThree = new System.Windows.Forms.Panel();
            this.panelFour = new System.Windows.Forms.Panel();
            this.pbAddImage = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(272, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(23, 467);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSupply_Quantity
            // 
            this.txtSupply_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupply_Quantity.Location = new System.Drawing.Point(164, 205);
            this.txtSupply_Quantity.Name = "txtSupply_Quantity";
            this.txtSupply_Quantity.Size = new System.Drawing.Size(249, 19);
            this.txtSupply_Quantity.TabIndex = 2;
            // 
            // txtSupply_Name
            // 
            this.txtSupply_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupply_Name.Location = new System.Drawing.Point(164, 129);
            this.txtSupply_Name.Name = "txtSupply_Name";
            this.txtSupply_Name.Size = new System.Drawing.Size(249, 19);
            this.txtSupply_Name.TabIndex = 1;
            // 
            // txtSupply_ID
            // 
            this.txtSupply_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupply_ID.Location = new System.Drawing.Point(164, 51);
            this.txtSupply_ID.Name = "txtSupply_ID";
            this.txtSupply_ID.Size = new System.Drawing.Size(249, 19);
            this.txtSupply_ID.TabIndex = 0;
            // 
            // txtSupply_Unit
            // 
            this.txtSupply_Unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupply_Unit.Location = new System.Drawing.Point(164, 272);
            this.txtSupply_Unit.Name = "txtSupply_Unit";
            this.txtSupply_Unit.Size = new System.Drawing.Size(249, 19);
            this.txtSupply_Unit.TabIndex = 3;
            // 
            // lblSupply_Category_ID
            // 
            this.lblSupply_Category_ID.AutoSize = true;
            this.lblSupply_Category_ID.Location = new System.Drawing.Point(29, 341);
            this.lblSupply_Category_ID.Name = "lblSupply_Category_ID";
            this.lblSupply_Category_ID.Size = new System.Drawing.Size(115, 20);
            this.lblSupply_Category_ID.TabIndex = 15;
            this.lblSupply_Category_ID.Text = "Tên loại vật tư :";
            // 
            // lblSupply_Unit
            // 
            this.lblSupply_Unit.AutoSize = true;
            this.lblSupply_Unit.Location = new System.Drawing.Point(29, 274);
            this.lblSupply_Unit.Name = "lblSupply_Unit";
            this.lblSupply_Unit.Size = new System.Drawing.Size(61, 20);
            this.lblSupply_Unit.TabIndex = 16;
            this.lblSupply_Unit.Text = "Đơn vị :";
            // 
            // lblSupply_Quantity
            // 
            this.lblSupply_Quantity.AutoSize = true;
            this.lblSupply_Quantity.Location = new System.Drawing.Point(29, 207);
            this.lblSupply_Quantity.Name = "lblSupply_Quantity";
            this.lblSupply_Quantity.Size = new System.Drawing.Size(84, 20);
            this.lblSupply_Quantity.TabIndex = 17;
            this.lblSupply_Quantity.Text = "Số lượng  :";
            // 
            // lblSupply_Name
            // 
            this.lblSupply_Name.AutoSize = true;
            this.lblSupply_Name.Location = new System.Drawing.Point(29, 131);
            this.lblSupply_Name.Name = "lblSupply_Name";
            this.lblSupply_Name.Size = new System.Drawing.Size(87, 20);
            this.lblSupply_Name.TabIndex = 18;
            this.lblSupply_Name.Text = "Tên vật tư :";
            // 
            // lblSupply_ID
            // 
            this.lblSupply_ID.AutoSize = true;
            this.lblSupply_ID.Location = new System.Drawing.Point(29, 53);
            this.lblSupply_ID.Name = "lblSupply_ID";
            this.lblSupply_ID.Size = new System.Drawing.Size(82, 20);
            this.lblSupply_ID.TabIndex = 19;
            this.lblSupply_ID.Text = "Mã vật tư :";
            // 
            // lblPublisher_ID
            // 
            this.lblPublisher_ID.AutoSize = true;
            this.lblPublisher_ID.Location = new System.Drawing.Point(29, 403);
            this.lblPublisher_ID.Name = "lblPublisher_ID";
            this.lblPublisher_ID.Size = new System.Drawing.Size(115, 20);
            this.lblPublisher_ID.TabIndex = 14;
            this.lblPublisher_ID.Text = "Nhà cung cấp :";
            // 
            // cmbSupply_Category_Name
            // 
            this.cmbSupply_Category_Name.FormattingEnabled = true;
            this.cmbSupply_Category_Name.Location = new System.Drawing.Point(164, 332);
            this.cmbSupply_Category_Name.Name = "cmbSupply_Category_Name";
            this.cmbSupply_Category_Name.Size = new System.Drawing.Size(135, 28);
            this.cmbSupply_Category_Name.TabIndex = 4;
            // 
            // cmbPublisher_Name
            // 
            this.cmbPublisher_Name.FormattingEnabled = true;
            this.cmbPublisher_Name.Location = new System.Drawing.Point(164, 395);
            this.cmbPublisher_Name.Name = "cmbPublisher_Name";
            this.cmbPublisher_Name.Size = new System.Drawing.Size(135, 28);
            this.cmbPublisher_Name.TabIndex = 5;
            // 
            // lblWarningOne
            // 
            this.lblWarningOne.AutoSize = true;
            this.lblWarningOne.ForeColor = System.Drawing.Color.Red;
            this.lblWarningOne.Location = new System.Drawing.Point(164, 9);
            this.lblWarningOne.Name = "lblWarningOne";
            this.lblWarningOne.Size = new System.Drawing.Size(0, 20);
            this.lblWarningOne.TabIndex = 27;
            // 
            // lblWarningTwo
            // 
            this.lblWarningTwo.AutoSize = true;
            this.lblWarningTwo.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTwo.Location = new System.Drawing.Point(164, 86);
            this.lblWarningTwo.Name = "lblWarningTwo";
            this.lblWarningTwo.Size = new System.Drawing.Size(0, 20);
            this.lblWarningTwo.TabIndex = 27;
            // 
            // lblWarningThree
            // 
            this.lblWarningThree.AutoSize = true;
            this.lblWarningThree.ForeColor = System.Drawing.Color.Red;
            this.lblWarningThree.Location = new System.Drawing.Point(160, 167);
            this.lblWarningThree.Name = "lblWarningThree";
            this.lblWarningThree.Size = new System.Drawing.Size(0, 20);
            this.lblWarningThree.TabIndex = 27;
            // 
            // lblWarningFour
            // 
            this.lblWarningFour.AutoSize = true;
            this.lblWarningFour.ForeColor = System.Drawing.Color.Red;
            this.lblWarningFour.Location = new System.Drawing.Point(164, 241);
            this.lblWarningFour.Name = "lblWarningFour";
            this.lblWarningFour.Size = new System.Drawing.Size(0, 20);
            this.lblWarningFour.TabIndex = 27;
            // 
            // btnNewSupply_Category
            // 
            this.btnNewSupply_Category.AutoSize = true;
            this.btnNewSupply_Category.Location = new System.Drawing.Point(338, 331);
            this.btnNewSupply_Category.Name = "btnNewSupply_Category";
            this.btnNewSupply_Category.Size = new System.Drawing.Size(75, 30);
            this.btnNewSupply_Category.TabIndex = 28;
            this.btnNewSupply_Category.Text = "Thêm ...";
            this.btnNewSupply_Category.UseVisualStyleBackColor = true;
            this.btnNewSupply_Category.Click += new System.EventHandler(this.btnNewSupply_Category_Click);
            // 
            // btnNewPublisher
            // 
            this.btnNewPublisher.AutoSize = true;
            this.btnNewPublisher.Location = new System.Drawing.Point(338, 393);
            this.btnNewPublisher.Name = "btnNewPublisher";
            this.btnNewPublisher.Size = new System.Drawing.Size(75, 30);
            this.btnNewPublisher.TabIndex = 28;
            this.btnNewPublisher.Text = "Thêm ...";
            this.btnNewPublisher.UseVisualStyleBackColor = true;
            this.btnNewPublisher.Click += new System.EventHandler(this.btnNewPublisher_Click);
            // 
            // panelOne
            // 
            this.panelOne.BackColor = System.Drawing.Color.Black;
            this.panelOne.Location = new System.Drawing.Point(164, 72);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(249, 1);
            this.panelOne.TabIndex = 29;
            // 
            // panelTwo
            // 
            this.panelTwo.BackColor = System.Drawing.Color.Black;
            this.panelTwo.Location = new System.Drawing.Point(164, 150);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(249, 1);
            this.panelTwo.TabIndex = 29;
            // 
            // panelThree
            // 
            this.panelThree.BackColor = System.Drawing.Color.Black;
            this.panelThree.Location = new System.Drawing.Point(164, 226);
            this.panelThree.Name = "panelThree";
            this.panelThree.Size = new System.Drawing.Size(249, 1);
            this.panelThree.TabIndex = 29;
            // 
            // panelFour
            // 
            this.panelFour.BackColor = System.Drawing.Color.Black;
            this.panelFour.Location = new System.Drawing.Point(164, 293);
            this.panelFour.Name = "panelFour";
            this.panelFour.Size = new System.Drawing.Size(249, 1);
            this.panelFour.TabIndex = 29;
            // 
            // pbAddImage
            // 
            this.pbAddImage.Image = ((System.Drawing.Image)(resources.GetObject("pbAddImage.Image")));
            this.pbAddImage.Location = new System.Drawing.Point(506, 72);
            this.pbAddImage.Name = "pbAddImage";
            this.pbAddImage.Size = new System.Drawing.Size(339, 295);
            this.pbAddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddImage.TabIndex = 30;
            this.pbAddImage.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.AutoSize = true;
            this.btnAddImage.Location = new System.Drawing.Point(655, 395);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(88, 30);
            this.btnAddImage.TabIndex = 6;
            this.btnAddImage.Text = "Chọn ảnh";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // frmUpdate_Supply
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 518);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.pbAddImage);
            this.Controls.Add(this.panelFour);
            this.Controls.Add(this.panelThree);
            this.Controls.Add(this.panelTwo);
            this.Controls.Add(this.panelOne);
            this.Controls.Add(this.btnNewPublisher);
            this.Controls.Add(this.btnNewSupply_Category);
            this.Controls.Add(this.lblWarningFour);
            this.Controls.Add(this.lblWarningThree);
            this.Controls.Add(this.lblWarningTwo);
            this.Controls.Add(this.lblWarningOne);
            this.Controls.Add(this.cmbPublisher_Name);
            this.Controls.Add(this.cmbSupply_Category_Name);
            this.Controls.Add(this.txtSupply_Quantity);
            this.Controls.Add(this.txtSupply_Name);
            this.Controls.Add(this.txtSupply_ID);
            this.Controls.Add(this.txtSupply_Unit);
            this.Controls.Add(this.lblPublisher_ID);
            this.Controls.Add(this.lblSupply_Category_ID);
            this.Controls.Add(this.lblSupply_Unit);
            this.Controls.Add(this.lblSupply_Quantity);
            this.Controls.Add(this.lblSupply_Name);
            this.Controls.Add(this.lblSupply_ID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmUpdate_Supply";
            this.Text = "Cập Nhật Vật Tư";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSupply_Quantity;
        private System.Windows.Forms.TextBox txtSupply_Name;
        private System.Windows.Forms.TextBox txtSupply_ID;
        private System.Windows.Forms.TextBox txtSupply_Unit;
        private System.Windows.Forms.Label lblSupply_Category_ID;
        private System.Windows.Forms.Label lblSupply_Unit;
        private System.Windows.Forms.Label lblSupply_Quantity;
        private System.Windows.Forms.Label lblSupply_Name;
        private System.Windows.Forms.Label lblSupply_ID;
        private System.Windows.Forms.Label lblPublisher_ID;
        private System.Windows.Forms.ComboBox cmbSupply_Category_Name;
        private System.Windows.Forms.ComboBox cmbPublisher_Name;
        private System.Windows.Forms.Label lblWarningOne;
        private System.Windows.Forms.Label lblWarningTwo;
        private System.Windows.Forms.Label lblWarningThree;
        private System.Windows.Forms.Label lblWarningFour;
        private System.Windows.Forms.Button btnNewSupply_Category;
        private System.Windows.Forms.Button btnNewPublisher;
        private System.Windows.Forms.Panel panelOne;
        private System.Windows.Forms.Panel panelTwo;
        private System.Windows.Forms.Panel panelThree;
        private System.Windows.Forms.Panel panelFour;
        private System.Windows.Forms.PictureBox pbAddImage;
        private System.Windows.Forms.Button btnAddImage;
    }
}