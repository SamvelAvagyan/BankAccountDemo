
namespace Presentation
{
    partial class Transaction
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
            this.sumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionName = new System.Windows.Forms.TextBox();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.overdraftingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sumUpDown
            // 
            this.sumUpDown.Location = new System.Drawing.Point(52, 89);
            this.sumUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sumUpDown.Name = "sumUpDown";
            this.sumUpDown.Size = new System.Drawing.Size(184, 20);
            this.sumUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction name";
            // 
            // transactionName
            // 
            this.transactionName.Location = new System.Drawing.Point(52, 52);
            this.transactionName.Name = "transactionName";
            this.transactionName.Size = new System.Drawing.Size(184, 20);
            this.transactionName.TabIndex = 2;
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTransactionButton.Location = new System.Drawing.Point(87, 131);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(109, 25);
            this.addTransactionButton.TabIndex = 3;
            this.addTransactionButton.Text = "Add";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.AddTransactionButtonClick);
            // 
            // overdraftingLabel
            // 
            this.overdraftingLabel.AutoSize = true;
            this.overdraftingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdraftingLabel.ForeColor = System.Drawing.Color.Red;
            this.overdraftingLabel.Location = new System.Drawing.Point(65, 172);
            this.overdraftingLabel.Name = "overdraftingLabel";
            this.overdraftingLabel.Size = new System.Drawing.Size(160, 18);
            this.overdraftingLabel.TabIndex = 4;
            this.overdraftingLabel.Text = "You are overdrafting";
            this.overdraftingLabel.Click += new System.EventHandler(this.OverdraftingLabelClick);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(281, 215);
            this.Controls.Add(this.overdraftingLabel);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.transactionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumUpDown);
            this.MaximizeBox = false;
            this.Name = "Transaction";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.sumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transactionName;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.Label overdraftingLabel;
    }
}