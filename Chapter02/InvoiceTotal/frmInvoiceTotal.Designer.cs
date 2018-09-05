namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercentage = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(278, 59);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.Location = new System.Drawing.Point(278, 113);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(100, 26);
            this.txtDiscountPercentage.TabIndex = 1;
            this.txtDiscountPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(278, 230);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(278, 174);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 26);
            this.txtDiscountAmount.TabIndex = 1;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(52, 64);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(77, 20);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "&Subtotal :";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercentage.Location = new System.Drawing.Point(56, 118);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(166, 20);
            this.lblDiscountPercentage.TabIndex = 0;
            this.lblDiscountPercentage.Text = "Discount Percentage :";
            this.lblDiscountPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.Location = new System.Drawing.Point(56, 179);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(140, 20);
            this.lblDiscountAmount.TabIndex = 0;
            this.lblDiscountAmount.Text = "Discount Amount :";
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(56, 235);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total :";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(104, 305);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 33);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(260, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(552, 403);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercentage);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountPercentage);
            this.Controls.Add(this.txtSubtotal);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercentage;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

