
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
            this.button1 = new System.Windows.Forms.Button();
            this.overdraftingLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sumUpDown
            // 
            this.sumUpDown.Location = new System.Drawing.Point(52, 107);
            this.sumUpDown.Name = "sumUpDown";
            this.sumUpDown.Size = new System.Drawing.Size(184, 20);
            this.sumUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction name";
            // 
            // transactionName
            // 
            this.transactionName.Location = new System.Drawing.Point(52, 70);
            this.transactionName.Name = "transactionName";
            this.transactionName.Size = new System.Drawing.Size(184, 20);
            this.transactionName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // overdraftingLabel1
            // 
            this.overdraftingLabel1.AutoSize = true;
            this.overdraftingLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdraftingLabel1.ForeColor = System.Drawing.Color.Red;
            this.overdraftingLabel1.Location = new System.Drawing.Point(65, 190);
            this.overdraftingLabel1.Name = "overdraftingLabel1";
            this.overdraftingLabel1.Size = new System.Drawing.Size(160, 18);
            this.overdraftingLabel1.TabIndex = 4;
            this.overdraftingLabel1.Text = "You are overdrafting";
            this.overdraftingLabel1.Click += new System.EventHandler(this.overdraftingLabel1_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 217);
            this.Controls.Add(this.overdraftingLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transactionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumUpDown);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label overdraftingLabel1;
    }
}