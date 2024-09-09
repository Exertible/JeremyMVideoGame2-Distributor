namespace FraryPNumAirline
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
            label1 = new Label();
            label2 = new Label();
            txtQuantityNumber = new TextBox();
            label3 = new Label();
            txtGamePrice = new TextBox();
            lstOutput = new ListBox();
            btnCalcPrice = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(410, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Quantity:";
            // 
            // txtQuantityNumber
            // 
            txtQuantityNumber.Location = new Point(389, 64);
            txtQuantityNumber.Name = "txtQuantityNumber";
            txtQuantityNumber.Size = new Size(100, 29);
            txtQuantityNumber.TabIndex = 2;
            txtQuantityNumber.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 64);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 3;
            label3.Text = "Price:";
            label3.Click += label3_Click;
            // 
            // txtGamePrice
            // 
            txtGamePrice.Location = new Point(389, 108);
            txtGamePrice.Name = "txtGamePrice";
            txtGamePrice.Size = new Size(100, 29);
            txtGamePrice.TabIndex = 4;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 21;
            lstOutput.Location = new Point(184, 240);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(593, 130);
            lstOutput.TabIndex = 5;
            // 
            // btnCalcPrice
            // 
            btnCalcPrice.Location = new Point(184, 388);
            btnCalcPrice.Name = "btnCalcPrice";
            btnCalcPrice.Size = new Size(142, 31);
            btnCalcPrice.TabIndex = 6;
            btnCalcPrice.Text = "Calculate &Price";
            btnCalcPrice.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(410, 388);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 31);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(644, 388);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(133, 31);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalcPrice);
            Controls.Add(lstOutput);
            Controls.Add(txtGamePrice);
            Controls.Add(label3);
            Controls.Add(txtQuantityNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtQuantityNumber;
        private Label label3;
        private TextBox txtGamePrice;
        private ListBox lstOutput;
        private Button btnCalcPrice;
        private Button btnClear;
        private Button btnQuit;
    }
}
