
namespace Presentation
{
    partial class Form1
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
            this.checkingListBox = new System.Windows.Forms.ListBox();
            this.savingListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkingLabel = new System.Windows.Forms.Label();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.overdraftLabel = new System.Windows.Forms.Label();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.denyOverdrafting = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkingListBox
            // 
            this.checkingListBox.FormattingEnabled = true;
            this.checkingListBox.Location = new System.Drawing.Point(241, 101);
            this.checkingListBox.Name = "checkingListBox";
            this.checkingListBox.Size = new System.Drawing.Size(194, 251);
            this.checkingListBox.TabIndex = 0;
            // 
            // savingListBox
            // 
            this.savingListBox.FormattingEnabled = true;
            this.savingListBox.Location = new System.Drawing.Point(456, 101);
            this.savingListBox.Name = "savingListBox";
            this.savingListBox.Size = new System.Drawing.Size(194, 251);
            this.savingListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Checking Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saving Transactions";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 121);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 25);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Savings";
            // 
            // checkingLabel
            // 
            this.checkingLabel.AutoSize = true;
            this.checkingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingLabel.Location = new System.Drawing.Point(127, 158);
            this.checkingLabel.Name = "checkingLabel";
            this.checkingLabel.Size = new System.Drawing.Size(58, 25);
            this.checkingLabel.TabIndex = 7;
            this.checkingLabel.Text = "0.00";
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsLabel.Location = new System.Drawing.Point(127, 198);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(58, 25);
            this.savingsLabel.TabIndex = 8;
            this.savingsLabel.Text = "0.00";
            // 
            // overdraftLabel
            // 
            this.overdraftLabel.AutoSize = true;
            this.overdraftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdraftLabel.ForeColor = System.Drawing.Color.Red;
            this.overdraftLabel.Location = new System.Drawing.Point(297, 20);
            this.overdraftLabel.Name = "overdraftLabel";
            this.overdraftLabel.Size = new System.Drawing.Size(292, 25);
            this.overdraftLabel.TabIndex = 9;
            this.overdraftLabel.Text = "You have overdrafted 0.00";
            this.overdraftLabel.Click += new System.EventHandler(this.OverdraftLabelClick);
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTransactionButton.Location = new System.Drawing.Point(17, 285);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(147, 67);
            this.addTransactionButton.TabIndex = 10;
            this.addTransactionButton.Text = "Add Transaction";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.AddTransactionButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mikado Bold DEMO", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Banking Account Demo";
            // 
            // denyOverdrafting
            // 
            this.denyOverdrafting.AutoSize = true;
            this.denyOverdrafting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyOverdrafting.Location = new System.Drawing.Point(17, 244);
            this.denyOverdrafting.Name = "denyOverdrafting";
            this.denyOverdrafting.Size = new System.Drawing.Size(216, 29);
            this.denyOverdrafting.TabIndex = 12;
            this.denyOverdrafting.Text = "Stop Overdrafting";
            this.denyOverdrafting.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(675, 390);
            this.Controls.Add(this.denyOverdrafting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.overdraftLabel);
            this.Controls.Add(this.savingsLabel);
            this.Controls.Add(this.checkingLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savingListBox);
            this.Controls.Add(this.checkingListBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BankAccountDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox checkingListBox;
        private System.Windows.Forms.ListBox savingListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label checkingLabel;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label overdraftLabel;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox denyOverdrafting;
    }
}

