namespace PolinaVargot_Lab_Due4_22_Dealership
{
    partial class frmDealership
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.btnSellSelectedCar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddCarBrand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddCarModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddCarYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddCarPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEnterPriceToChange = new System.Windows.Forms.TextBox();
            this.btnTotalAmount = new System.Windows.Forms.Button();
            this.btnShowCarHighestPrice = new System.Windows.Forms.Button();
            this.btnShowCarLowestPrice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(583, 292);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price:";
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.Location = new System.Drawing.Point(110, 373);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(158, 28);
            this.btnChangePrice.TabIndex = 7;
            this.btnChangePrice.Text = "Change Price";
            this.btnChangePrice.UseVisualStyleBackColor = true;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // btnSellSelectedCar
            // 
            this.btnSellSelectedCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellSelectedCar.Location = new System.Drawing.Point(499, 333);
            this.btnSellSelectedCar.Name = "btnSellSelectedCar";
            this.btnSellSelectedCar.Size = new System.Drawing.Size(96, 66);
            this.btnSellSelectedCar.TabIndex = 8;
            this.btnSellSelectedCar.Text = "&Sell Selected Car";
            this.btnSellSelectedCar.UseVisualStyleBackColor = true;
            this.btnSellSelectedCar.Click += new System.EventHandler(this.btnSellSelectedCar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add New Car:";
            // 
            // txtAddCarBrand
            // 
            this.txtAddCarBrand.Location = new System.Drawing.Point(12, 456);
            this.txtAddCarBrand.Name = "txtAddCarBrand";
            this.txtAddCarBrand.Size = new System.Drawing.Size(149, 24);
            this.txtAddCarBrand.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter Brand:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enter Model:";
            // 
            // txtAddCarModel
            // 
            this.txtAddCarModel.Location = new System.Drawing.Point(167, 456);
            this.txtAddCarModel.Name = "txtAddCarModel";
            this.txtAddCarModel.Size = new System.Drawing.Size(144, 24);
            this.txtAddCarModel.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Enter Year:";
            // 
            // txtAddCarYear
            // 
            this.txtAddCarYear.Location = new System.Drawing.Point(317, 456);
            this.txtAddCarYear.Name = "txtAddCarYear";
            this.txtAddCarYear.Size = new System.Drawing.Size(92, 24);
            this.txtAddCarYear.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Enter Price:";
            // 
            // txtAddCarPrice
            // 
            this.txtAddCarPrice.Location = new System.Drawing.Point(416, 456);
            this.txtAddCarPrice.Name = "txtAddCarPrice";
            this.txtAddCarPrice.Size = new System.Drawing.Size(92, 24);
            this.txtAddCarPrice.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "To Change Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Enter Price:";
            // 
            // txtEnterPriceToChange
            // 
            this.txtEnterPriceToChange.Location = new System.Drawing.Point(12, 375);
            this.txtEnterPriceToChange.Name = "txtEnterPriceToChange";
            this.txtEnterPriceToChange.Size = new System.Drawing.Size(92, 24);
            this.txtEnterPriceToChange.TabIndex = 19;
            // 
            // btnTotalAmount
            // 
            this.btnTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalAmount.Location = new System.Drawing.Point(16, 495);
            this.btnTotalAmount.Name = "btnTotalAmount";
            this.btnTotalAmount.Size = new System.Drawing.Size(98, 70);
            this.btnTotalAmount.TabIndex = 21;
            this.btnTotalAmount.Text = "Total Amount Of All Cars";
            this.btnTotalAmount.UseVisualStyleBackColor = true;
            this.btnTotalAmount.Click += new System.EventHandler(this.btnTotalAmount_Click);
            // 
            // btnShowCarHighestPrice
            // 
            this.btnShowCarHighestPrice.Location = new System.Drawing.Point(120, 495);
            this.btnShowCarHighestPrice.Name = "btnShowCarHighestPrice";
            this.btnShowCarHighestPrice.Size = new System.Drawing.Size(109, 70);
            this.btnShowCarHighestPrice.TabIndex = 23;
            this.btnShowCarHighestPrice.Text = "Show the car with highest price";
            this.btnShowCarHighestPrice.UseVisualStyleBackColor = true;
            this.btnShowCarHighestPrice.Click += new System.EventHandler(this.btnShowCarHighestPrice_Click);
            // 
            // btnShowCarLowestPrice
            // 
            this.btnShowCarLowestPrice.Location = new System.Drawing.Point(235, 495);
            this.btnShowCarLowestPrice.Name = "btnShowCarLowestPrice";
            this.btnShowCarLowestPrice.Size = new System.Drawing.Size(105, 70);
            this.btnShowCarLowestPrice.TabIndex = 24;
            this.btnShowCarLowestPrice.Text = "Show the car with lowest price";
            this.btnShowCarLowestPrice.UseVisualStyleBackColor = true;
            this.btnShowCarLowestPrice.Click += new System.EventHandler(this.btnShowCarLowestPrice_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(517, 529);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(514, 436);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 45);
            this.btnAddCar.TabIndex = 26;
            this.btnAddCar.Text = "&Add";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // frmDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 579);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowCarLowestPrice);
            this.Controls.Add(this.btnShowCarHighestPrice);
            this.Controls.Add(this.btnTotalAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEnterPriceToChange);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAddCarPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddCarYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddCarModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddCarBrand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSellSelectedCar);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDealership";
            this.Text = "Dealership";
            this.Load += new System.EventHandler(this.frmDealership_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.Button btnSellSelectedCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddCarBrand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddCarModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddCarYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddCarPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEnterPriceToChange;
        private System.Windows.Forms.Button btnTotalAmount;
        private System.Windows.Forms.Button btnShowCarHighestPrice;
        private System.Windows.Forms.Button btnShowCarLowestPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddCar;
    }
}

