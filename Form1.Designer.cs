namespace ShoppingCart
{
    partial class Form1
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
            button1 = new Button();
            Coffee = new CheckBox();
            GreenTea = new CheckBox();
            label1 = new Label();
            CoffeePrice = new TextBox();
            CoffeeQuantity = new TextBox();
            GreenTeaQuantity = new TextBox();
            GreenTeaPrice = new TextBox();
            tbTotal = new TextBox();
            tbCash = new TextBox();
            tbChange = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tb1000 = new TextBox();
            tb500 = new TextBox();
            tb100 = new TextBox();
            tb50 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tb20 = new TextBox();
            tb10 = new TextBox();
            tb5 = new TextBox();
            tb1 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(448, 49);
            button1.Name = "button1";
            button1.Size = new Size(94, 352);
            button1.TabIndex = 0;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Coffee
            // 
            Coffee.AutoSize = true;
            Coffee.Location = new Point(59, 49);
            Coffee.Name = "Coffee";
            Coffee.Size = new Size(75, 24);
            Coffee.TabIndex = 1;
            Coffee.Text = "Coffee";
            Coffee.UseVisualStyleBackColor = true;
            Coffee.CheckedChanged += Coffee_CheckedChanged;
            // 
            // GreenTea
            // 
            GreenTea.AutoSize = true;
            GreenTea.Location = new Point(59, 79);
            GreenTea.Name = "GreenTea";
            GreenTea.Size = new Size(93, 24);
            GreenTea.TabIndex = 2;
            GreenTea.Text = "GreenTea";
            GreenTea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 50);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Total";
            label1.Click += label1_Click;
            // 
            // CoffeePrice
            // 
            CoffeePrice.Location = new Point(169, 49);
            CoffeePrice.Name = "CoffeePrice";
            CoffeePrice.Size = new Size(125, 27);
            CoffeePrice.TabIndex = 4;
            // 
            // CoffeeQuantity
            // 
            CoffeeQuantity.Location = new Point(300, 49);
            CoffeeQuantity.Name = "CoffeeQuantity";
            CoffeeQuantity.Size = new Size(125, 27);
            CoffeeQuantity.TabIndex = 5;
            // 
            // GreenTeaQuantity
            // 
            GreenTeaQuantity.Location = new Point(300, 82);
            GreenTeaQuantity.Name = "GreenTeaQuantity";
            GreenTeaQuantity.Size = new Size(125, 27);
            GreenTeaQuantity.TabIndex = 6;
            // 
            // GreenTeaPrice
            // 
            GreenTeaPrice.Location = new Point(169, 82);
            GreenTeaPrice.Name = "GreenTeaPrice";
            GreenTeaPrice.Size = new Size(125, 27);
            GreenTeaPrice.TabIndex = 7;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(638, 46);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 8;
            // 
            // tbCash
            // 
            tbCash.Location = new Point(638, 77);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(125, 27);
            tbCash.TabIndex = 9;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(638, 110);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(125, 27);
            tbChange.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(573, 80);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 11;
            label2.Text = "Cash";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 113);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 12;
            label3.Text = "Change";
            // 
            // tb1000
            // 
            tb1000.Location = new Point(638, 143);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(125, 27);
            tb1000.TabIndex = 13;
            tb1000.TextChanged += textBox3_TextChanged;
            // 
            // tb500
            // 
            tb500.Location = new Point(638, 176);
            tb500.Name = "tb500";
            tb500.Size = new Size(125, 27);
            tb500.TabIndex = 14;
            // 
            // tb100
            // 
            tb100.Location = new Point(638, 209);
            tb100.Name = "tb100";
            tb100.Size = new Size(125, 27);
            tb100.TabIndex = 15;
            tb100.TextChanged += textBox5_TextChanged;
            // 
            // tb50
            // 
            tb50.Location = new Point(638, 242);
            tb50.Name = "tb50";
            tb50.Size = new Size(125, 27);
            tb50.TabIndex = 16;
            tb50.TextChanged += textBox6_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 146);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 17;
            label4.Text = "1000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(580, 179);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 18;
            label5.Text = "500";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 212);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 19;
            label6.Text = "100";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(588, 245);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 20;
            label7.Text = "50";
            // 
            // tb20
            // 
            tb20.Location = new Point(638, 275);
            tb20.Name = "tb20";
            tb20.Size = new Size(125, 27);
            tb20.TabIndex = 21;
            // 
            // tb10
            // 
            tb10.Location = new Point(638, 308);
            tb10.Name = "tb10";
            tb10.Size = new Size(125, 27);
            tb10.TabIndex = 22;
            // 
            // tb5
            // 
            tb5.Location = new Point(638, 341);
            tb5.Name = "tb5";
            tb5.Size = new Size(125, 27);
            tb5.TabIndex = 23;
            // 
            // tb1
            // 
            tb1.Location = new Point(638, 374);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(588, 278);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 25;
            label8.Text = "20";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(588, 311);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 26;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(596, 344);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 27;
            label10.Text = "5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(596, 381);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 28;
            label11.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(tb1000);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbChange);
            Controls.Add(tbCash);
            Controls.Add(tbTotal);
            Controls.Add(GreenTeaPrice);
            Controls.Add(GreenTeaQuantity);
            Controls.Add(CoffeeQuantity);
            Controls.Add(CoffeePrice);
            Controls.Add(label1);
            Controls.Add(GreenTea);
            Controls.Add(Coffee);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox Coffee;
        private CheckBox GreenTea;
        private Label label1;
        private TextBox CoffeePrice;
        private TextBox CoffeeQuantity;
        private TextBox GreenTeaQuantity;
        private TextBox GreenTeaPrice;
        private TextBox tbTotal;
        private TextBox tbCash;
        private TextBox tbChange;
        private Label label2;
        private Label label3;
        private TextBox tb1000;
        private TextBox tb500;
        private TextBox tb100;
        private TextBox tb50;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb20;
        private TextBox tb10;
        private TextBox tb5;
        private TextBox tb1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
