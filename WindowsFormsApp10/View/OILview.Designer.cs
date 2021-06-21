
namespace WindowsFormsApp10.View
{
    partial class OILview
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
            this.OILComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.OILSListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OILComboBox
            // 
            this.OILComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OILComboBox.FormattingEnabled = true;
            this.OILComboBox.Location = new System.Drawing.Point(154, 69);
            this.OILComboBox.Name = "OILComboBox";
            this.OILComboBox.Size = new System.Drawing.Size(144, 33);
            this.OILComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price";
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTxtBox.Location = new System.Drawing.Point(154, 240);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.Size = new System.Drawing.Size(100, 26);
            this.PriceTxtBox.TabIndex = 2;
            // 
            // OILSListBox
            // 
            this.OILSListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OILSListBox.FormattingEnabled = true;
            this.OILSListBox.ItemHeight = 25;
            this.OILSListBox.Location = new System.Drawing.Point(599, 69);
            this.OILSListBox.Name = "OILSListBox";
            this.OILSListBox.Size = new System.Drawing.Size(246, 329);
            this.OILSListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "OIL";
            // 
            // OrderBtn
            // 
            this.OrderBtn.AutoSize = true;
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderBtn.Location = new System.Drawing.Point(120, 364);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(100, 34);
            this.OrderBtn.TabIndex = 5;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // OILview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(894, 515);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OILSListBox);
            this.Controls.Add(this.PriceTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OILComboBox);
            this.Name = "OILview";
            this.Text = "OILview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OILComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PriceTxtBox;
        private System.Windows.Forms.ListBox OILSListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OrderBtn;
    }
}