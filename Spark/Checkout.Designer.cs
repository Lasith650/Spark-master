namespace Spark
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.checkoutDocument = new System.Drawing.Printing.PrintDocument();
            this.confirmpay1 = new System.Windows.Forms.Label();
            this.confirmPay = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.pricePaidCal = new System.Windows.Forms.Label();
            this.paidLbl = new System.Windows.Forms.Label();
            this.pricepaidlbl = new System.Windows.Forms.Label();
            this.paidnbx = new System.Windows.Forms.NumericUpDown();
            this.checkoutPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.calculatePrice = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calPrice = new System.Windows.Forms.Label();
            this.checkoutDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.paidnbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutDocument
            // 
            this.checkoutDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.checkoutDocument_PrintPage);
            // 
            // confirmpay1
            // 
            this.confirmpay1.AutoSize = true;
            this.confirmpay1.BackColor = System.Drawing.Color.Transparent;
            this.confirmpay1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpay1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.confirmpay1.Location = new System.Drawing.Point(587, 329);
            this.confirmpay1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmpay1.Name = "confirmpay1";
            this.confirmpay1.Size = new System.Drawing.Size(138, 19);
            this.confirmpay1.TabIndex = 35;
            this.confirmpay1.Text = "Confirm Payment";
            this.confirmpay1.Click += new System.EventHandler(this.confirmpay1_Click_1);
            // 
            // confirmPay
            // 
            this.confirmPay.AutoSize = true;
            this.confirmPay.BackColor = System.Drawing.Color.Transparent;
            this.confirmPay.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmPay.Location = new System.Drawing.Point(587, 327);
            this.confirmPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPay.Name = "confirmPay";
            this.confirmPay.Size = new System.Drawing.Size(138, 19);
            this.confirmPay.TabIndex = 34;
            this.confirmPay.Text = "Confirm Payment";
            this.confirmPay.Click += new System.EventHandler(this.confirmPay_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.Transparent;
            this.balance.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.ForeColor = System.Drawing.Color.Snow;
            this.balance.Location = new System.Drawing.Point(588, 199);
            this.balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(0, 19);
            this.balance.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(473, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Balance (Rs) :";
            // 
            // horizontalLine
            // 
            this.horizontalLine.AutoSize = true;
            this.horizontalLine.BackColor = System.Drawing.SystemColors.Control;
            this.horizontalLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalLine.Location = new System.Drawing.Point(476, 178);
            this.horizontalLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.horizontalLine.MinimumSize = new System.Drawing.Size(240, 0);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(240, 2);
            this.horizontalLine.TabIndex = 31;
            // 
            // pricePaidCal
            // 
            this.pricePaidCal.AutoSize = true;
            this.pricePaidCal.BackColor = System.Drawing.Color.Transparent;
            this.pricePaidCal.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePaidCal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pricePaidCal.Location = new System.Drawing.Point(417, 345);
            this.pricePaidCal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pricePaidCal.MinimumSize = new System.Drawing.Size(22, 24);
            this.pricePaidCal.Name = "pricePaidCal";
            this.pricePaidCal.Size = new System.Drawing.Size(41, 24);
            this.pricePaidCal.TabIndex = 30;
            this.pricePaidCal.Text = "Paid";
            this.pricePaidCal.Visible = false;
            this.pricePaidCal.Click += new System.EventHandler(this.pricePaidCal_Click);
            // 
            // paidLbl
            // 
            this.paidLbl.AutoSize = true;
            this.paidLbl.BackColor = System.Drawing.Color.Transparent;
            this.paidLbl.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidLbl.ForeColor = System.Drawing.Color.Snow;
            this.paidLbl.Location = new System.Drawing.Point(588, 148);
            this.paidLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paidLbl.Name = "paidLbl";
            this.paidLbl.Size = new System.Drawing.Size(0, 19);
            this.paidLbl.TabIndex = 29;
            // 
            // pricepaidlbl
            // 
            this.pricepaidlbl.AutoSize = true;
            this.pricepaidlbl.BackColor = System.Drawing.Color.Transparent;
            this.pricepaidlbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricepaidlbl.ForeColor = System.Drawing.Color.Snow;
            this.pricepaidlbl.Location = new System.Drawing.Point(473, 148);
            this.pricepaidlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pricepaidlbl.Name = "pricepaidlbl";
            this.pricepaidlbl.Size = new System.Drawing.Size(118, 19);
            this.pricepaidlbl.TabIndex = 28;
            this.pricepaidlbl.Text = "Price Paid (Rs) :";
            // 
            // paidnbx
            // 
            this.paidnbx.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidnbx.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.paidnbx.Location = new System.Drawing.Point(354, 318);
            this.paidnbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paidnbx.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.paidnbx.Name = "paidnbx";
            this.paidnbx.Size = new System.Drawing.Size(100, 26);
            this.paidnbx.TabIndex = 27;
            // 
            // checkoutPreviewDialog
            // 
            this.checkoutPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.checkoutPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.checkoutPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.checkoutPreviewDialog.Enabled = true;
            this.checkoutPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("checkoutPreviewDialog.Icon")));
            this.checkoutPreviewDialog.Name = "checkoutPreviewDialog";
            this.checkoutPreviewDialog.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(266, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Price Paid";
            // 
            // calculatePrice
            // 
            this.calculatePrice.AutoSize = true;
            this.calculatePrice.BackColor = System.Drawing.Color.Transparent;
            this.calculatePrice.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePrice.ForeColor = System.Drawing.Color.Snow;
            this.calculatePrice.Location = new System.Drawing.Point(590, 111);
            this.calculatePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatePrice.Name = "calculatePrice";
            this.calculatePrice.Size = new System.Drawing.Size(0, 19);
            this.calculatePrice.TabIndex = 24;
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.BackColor = System.Drawing.Color.Transparent;
            this.totallbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.ForeColor = System.Drawing.Color.Snow;
            this.totallbl.Location = new System.Drawing.Point(473, 111);
            this.totallbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(121, 19);
            this.totallbl.TabIndex = 23;
            this.totallbl.Text = "Total Price (Rs) :";
            // 
            // col4
            // 
            this.col4.HeaderText = "Quantity";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "Price";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.HeaderText = "Part Type";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.HeaderText = "Model Name";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Brandname";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // calPrice
            // 
            this.calPrice.AutoSize = true;
            this.calPrice.BackColor = System.Drawing.Color.Transparent;
            this.calPrice.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calPrice.Location = new System.Drawing.Point(50, 325);
            this.calPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calPrice.Name = "calPrice";
            this.calPrice.Size = new System.Drawing.Size(120, 19);
            this.calPrice.TabIndex = 25;
            this.calPrice.Text = "Calculate Price";
            this.calPrice.Click += new System.EventHandler(this.calPrice_Click);
            // 
            // checkoutDataGrid
            // 
            this.checkoutDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkoutDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.col2,
            this.col3,
            this.Col5,
            this.col4});
            this.checkoutDataGrid.Location = new System.Drawing.Point(52, 58);
            this.checkoutDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkoutDataGrid.Name = "checkoutDataGrid";
            this.checkoutDataGrid.RowTemplate.Height = 24;
            this.checkoutDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.checkoutDataGrid.Size = new System.Drawing.Size(401, 253);
            this.checkoutDataGrid.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Raleway Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(611, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Check Out";
            // 
            // goBack
            // 
            this.goBack.AutoSize = true;
            this.goBack.BackColor = System.Drawing.Color.Transparent;
            this.goBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goBack.Image = ((System.Drawing.Image)(resources.GetObject("goBack.Image")));
            this.goBack.Location = new System.Drawing.Point(9, 12);
            this.goBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goBack.MinimumSize = new System.Drawing.Size(22, 24);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(22, 24);
            this.goBack.TabIndex = 20;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(616, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 36;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 400);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.confirmpay1);
            this.Controls.Add(this.confirmPay);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.pricePaidCal);
            this.Controls.Add(this.paidLbl);
            this.Controls.Add(this.pricepaidlbl);
            this.Controls.Add(this.paidnbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculatePrice);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.calPrice);
            this.Controls.Add(this.checkoutDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.paidnbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument checkoutDocument;
        private System.Windows.Forms.Label confirmpay1;
        private System.Windows.Forms.Label confirmPay;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label horizontalLine;
        private System.Windows.Forms.Label pricePaidCal;
        private System.Windows.Forms.Label paidLbl;
        private System.Windows.Forms.Label pricepaidlbl;
        private System.Windows.Forms.NumericUpDown paidnbx;
        private System.Windows.Forms.PrintPreviewDialog checkoutPreviewDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label calculatePrice;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.Label calPrice;
        private System.Windows.Forms.DataGridView checkoutDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label goBack;
        private System.Windows.Forms.TextBox textBox1;
    }
}