
namespace NewClassForm1
{
    partial class PersonDataForm
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
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cmTextBox = new System.Windows.Forms.TextBox();
            this.kgTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.massInKgLabel = new System.Windows.Forms.Label();
            this.addToListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataListBox
            // 
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.ItemHeight = 15;
            this.dataListBox.Location = new System.Drawing.Point(549, 24);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(207, 259);
            this.dataListBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(149, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(130, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(32, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // cmTextBox
            // 
            this.cmTextBox.Location = new System.Drawing.Point(149, 75);
            this.cmTextBox.Name = "cmTextBox";
            this.cmTextBox.Size = new System.Drawing.Size(58, 23);
            this.cmTextBox.TabIndex = 3;
            // 
            // kgTextBox
            // 
            this.kgTextBox.Location = new System.Drawing.Point(149, 188);
            this.kgTextBox.Name = "kgTextBox";
            this.kgTextBox.Size = new System.Drawing.Size(58, 23);
            this.kgTextBox.TabIndex = 4;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(32, 75);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(76, 15);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height in cm";
            // 
            // massInKgLabel
            // 
            this.massInKgLabel.AutoSize = true;
            this.massInKgLabel.Location = new System.Drawing.Point(32, 188);
            this.massInKgLabel.Name = "massInKgLabel";
            this.massInKgLabel.Size = new System.Drawing.Size(63, 15);
            this.massInKgLabel.TabIndex = 6;
            this.massInKgLabel.Text = "Mass in kg";
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(580, 289);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(141, 35);
            this.addToListButton.TabIndex = 7;
            this.addToListButton.Text = "Add to List";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // PersonDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.massInKgLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.kgTextBox);
            this.Controls.Add(this.cmTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dataListBox);
            this.Name = "PersonDataForm";
            this.Text = "Person Data Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox cmTextBox;
        private System.Windows.Forms.TextBox kgTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label massInKgLabel;
        private System.Windows.Forms.Button addToListButton;
    }
}

