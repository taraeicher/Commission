namespace ChrisCars
{
    partial class frmCommission
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
            this.grpBxData = new System.Windows.Forms.GroupBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.txtBxCost = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBxCar = new System.Windows.Forms.PictureBox();
            this.grpBxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxData
            // 
            this.grpBxData.Controls.Add(this.txtBxCost);
            this.grpBxData.Controls.Add(this.txtBxPrice);
            this.grpBxData.Controls.Add(this.txtBxName);
            this.grpBxData.Controls.Add(this.lblCost);
            this.grpBxData.Controls.Add(this.lblPrice);
            this.grpBxData.Controls.Add(this.lblName);
            this.grpBxData.Location = new System.Drawing.Point(41, 30);
            this.grpBxData.Name = "grpBxData";
            this.grpBxData.Size = new System.Drawing.Size(277, 140);
            this.grpBxData.TabIndex = 0;
            this.grpBxData.TabStop = false;
            this.grpBxData.Text = "Information";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(15, 100);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(61, 13);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Cost &Value:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 64);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "&Selling Price:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name of Salesperson:\r\n";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(146, 24);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 20);
            this.txtBxName.TabIndex = 3;
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Location = new System.Drawing.Point(146, 61);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBxPrice.TabIndex = 4;
            // 
            // txtBxCost
            // 
            this.txtBxCost.Location = new System.Drawing.Point(146, 97);
            this.txtBxCost.Name = "txtBxCost";
            this.txtBxCost.Size = new System.Drawing.Size(100, 20);
            this.txtBxCost.TabIndex = 5;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(137, 236);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(102, 13);
            this.lblCommission.TabIndex = 1;
            this.lblCommission.Text = "C&ommission Earned:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(245, 235);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(100, 24);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = " ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(43, 290);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(212, 290);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Cle&ar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBxCar
            // 
            this.picBxCar.Image = global::ChrisCars.Properties.Resources.default_car;
            this.picBxCar.Location = new System.Drawing.Point(350, 24);
            this.picBxCar.Name = "picBxCar";
            this.picBxCar.Size = new System.Drawing.Size(91, 71);
            this.picBxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxCar.TabIndex = 6;
            this.picBxCar.TabStop = false;
            // 
            // frmCommission
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(475, 350);
            this.Controls.Add(this.picBxCar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.grpBxData);
            this.Name = "frmCommission";
            this.Text = "Commission Earned";
            this.grpBxData.ResumeLayout(false);
            this.grpBxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxData;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtBxCost;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBxCar;
    }
}

