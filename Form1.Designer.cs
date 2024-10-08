namespace CashierApplication
{
    partial class frmPurchaseDiscountItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseDiscountItem));
            txtItemName = new TextBox();
            txtPayment = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtDiscount = new TextBox();
            btnCalculateTotal = new Button();
            btnCalculate = new Button();
            lblTotalAmount = new Label();
            lblChange = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Segoe UI", 13F);
            txtItemName.Location = new Point(12, 29);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(207, 31);
            txtItemName.TabIndex = 0;
            // 
            // txtPayment
            // 
            txtPayment.Font = new Font("Segoe UI", 12F);
            txtPayment.Location = new Point(142, 177);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(133, 29);
            txtPayment.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 13F);
            txtQuantity.Location = new Point(308, 66);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(58, 31);
            txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 13F);
            txtPrice.Location = new Point(65, 66);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(154, 31);
            txtPrice.TabIndex = 4;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 13F);
            txtDiscount.Location = new Point(232, 29);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(134, 31);
            txtDiscount.TabIndex = 5;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Font = new Font("Segoe UI", 12F);
            btnCalculateTotal.Location = new Point(142, 103);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(89, 30);
            btnCalculateTotal.TabIndex = 6;
            btnCalculateTotal.Text = "Compute";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F);
            btnCalculate.Location = new Point(281, 177);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(77, 29);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Submit";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F);
            lblTotalAmount.Location = new Point(167, 145);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(52, 21);
            lblTotalAmount.TabIndex = 8;
            lblTotalAmount.Text = "label1";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 12F);
            lblChange.Location = new Point(167, 222);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(52, 21);
            lblChange.TabIndex = 9;
            lblChange.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 10;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 11;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(232, 5);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 12;
            label3.Text = "Discount (%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(232, 70);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 13;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(43, 145);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 14;
            label5.Text = "Total amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 179);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 15;
            label6.Text = "Payment received:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(80, 222);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 16;
            label7.Text = "Change:";
            // 
            // frmPurchaseDiscountItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 259);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblChange);
            Controls.Add(lblTotalAmount);
            Controls.Add(btnCalculate);
            Controls.Add(btnCalculateTotal);
            Controls.Add(txtDiscount);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtPayment);
            Controls.Add(txtItemName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPurchaseDiscountItem";
            Text = "Purchase Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItemName;
        private TextBox txtPayment;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtDiscount;
        private Button btnCalculateTotal;
        private Button btnCalculate;
        private Label lblTotalAmount;
        private Label lblChange;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
