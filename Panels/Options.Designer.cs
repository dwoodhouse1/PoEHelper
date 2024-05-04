namespace PoEHelper
{
    partial class Options
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_back = new Button();
            label1 = new Label();
            button_farmingStrats = new Button();
            button_vendorRecipes = new Button();
            button1 = new Button();
            button_usefulLinks = new Button();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Location = new Point(3, 534);
            button_back.Name = "button_back";
            button_back.Size = new Size(118, 75);
            button_back.TabIndex = 0;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 0);
            label1.Name = "label1";
            label1.Size = new Size(776, 86);
            label1.TabIndex = 1;
            label1.Text = "What are you looking for?";
            // 
            // button_farmingStrats
            // 
            button_farmingStrats.Location = new Point(235, 107);
            button_farmingStrats.Name = "button_farmingStrats";
            button_farmingStrats.Size = new Size(352, 75);
            button_farmingStrats.TabIndex = 2;
            button_farmingStrats.Text = "Farming Strategies";
            button_farmingStrats.UseVisualStyleBackColor = true;
            // 
            // button_vendorRecipes
            // 
            button_vendorRecipes.Location = new Point(235, 208);
            button_vendorRecipes.Name = "button_vendorRecipes";
            button_vendorRecipes.Size = new Size(352, 75);
            button_vendorRecipes.TabIndex = 3;
            button_vendorRecipes.Text = "Vendor Recipes";
            button_vendorRecipes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(235, 311);
            button1.Name = "button1";
            button1.Size = new Size(352, 75);
            button1.TabIndex = 4;
            button1.Text = "League Mechanic Info";
            button1.UseVisualStyleBackColor = true;
            // 
            // button_usefulLinks
            // 
            button_usefulLinks.Location = new Point(235, 409);
            button_usefulLinks.Name = "button_usefulLinks";
            button_usefulLinks.Size = new Size(352, 75);
            button_usefulLinks.TabIndex = 5;
            button_usefulLinks.Text = "Useful Links";
            button_usefulLinks.UseVisualStyleBackColor = true;
            button_usefulLinks.Click += button_usefulLinks_Click;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_usefulLinks);
            Controls.Add(button1);
            Controls.Add(button_vendorRecipes);
            Controls.Add(button_farmingStrats);
            Controls.Add(label1);
            Controls.Add(button_back);
            Name = "Test";
            Size = new Size(858, 612);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private Label label1;
        private Button button_farmingStrats;
        private Button button_vendorRecipes;
        private Button button1;
        private Button button_usefulLinks;
    }
}
