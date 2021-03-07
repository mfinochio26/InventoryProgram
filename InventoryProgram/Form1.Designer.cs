
namespace InventoryProgram
{
    partial class clothingInventoryForm
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
            this.inventoryIntro = new System.Windows.Forms.Label();
            this.inventoryQuestion = new System.Windows.Forms.Label();
            this.shirtQuest = new System.Windows.Forms.Label();
            this.jacketQuest = new System.Windows.Forms.Label();
            this.pantQuest = new System.Windows.Forms.Label();
            this.hatQuest = new System.Windows.Forms.Label();
            this.showQuest = new System.Windows.Forms.Label();
            this.shirtAns = new System.Windows.Forms.TextBox();
            this.pantAns = new System.Windows.Forms.TextBox();
            this.jacketAns = new System.Windows.Forms.TextBox();
            this.hatAns = new System.Windows.Forms.TextBox();
            this.shoeAns = new System.Windows.Forms.TextBox();
            this.saveShirt = new System.Windows.Forms.Button();
            this.savePant = new System.Windows.Forms.Button();
            this.saveJacket = new System.Windows.Forms.Button();
            this.saveHat = new System.Windows.Forms.Button();
            this.saveShoe = new System.Windows.Forms.Button();
            this.inventoryBox = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inventoryIntro
            // 
            this.inventoryIntro.AutoSize = true;
            this.inventoryIntro.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryIntro.Location = new System.Drawing.Point(220, 34);
            this.inventoryIntro.Name = "inventoryIntro";
            this.inventoryIntro.Size = new System.Drawing.Size(353, 54);
            this.inventoryIntro.TabIndex = 0;
            this.inventoryIntro.Text = "Clothing Inventory";
            // 
            // inventoryQuestion
            // 
            this.inventoryQuestion.AutoSize = true;
            this.inventoryQuestion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryQuestion.Location = new System.Drawing.Point(12, 134);
            this.inventoryQuestion.Name = "inventoryQuestion";
            this.inventoryQuestion.Size = new System.Drawing.Size(445, 41);
            this.inventoryQuestion.TabIndex = 1;
            this.inventoryQuestion.Text = "How many of each do you own?";
            // 
            // shirtQuest
            // 
            this.shirtQuest.AutoSize = true;
            this.shirtQuest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shirtQuest.Location = new System.Drawing.Point(12, 204);
            this.shirtQuest.Name = "shirtQuest";
            this.shirtQuest.Size = new System.Drawing.Size(98, 41);
            this.shirtQuest.TabIndex = 2;
            this.shirtQuest.Text = "Shirts:";
            // 
            // jacketQuest
            // 
            this.jacketQuest.AutoSize = true;
            this.jacketQuest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jacketQuest.Location = new System.Drawing.Point(12, 318);
            this.jacketQuest.Name = "jacketQuest";
            this.jacketQuest.Size = new System.Drawing.Size(119, 41);
            this.jacketQuest.TabIndex = 3;
            this.jacketQuest.Text = "Jackets:";
            // 
            // pantQuest
            // 
            this.pantQuest.AutoSize = true;
            this.pantQuest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pantQuest.Location = new System.Drawing.Point(12, 258);
            this.pantQuest.Name = "pantQuest";
            this.pantQuest.Size = new System.Drawing.Size(96, 41);
            this.pantQuest.TabIndex = 4;
            this.pantQuest.Text = "Pants:";
            // 
            // hatQuest
            // 
            this.hatQuest.AutoSize = true;
            this.hatQuest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hatQuest.Location = new System.Drawing.Point(12, 378);
            this.hatQuest.Name = "hatQuest";
            this.hatQuest.Size = new System.Drawing.Size(84, 41);
            this.hatQuest.TabIndex = 5;
            this.hatQuest.Text = "Hats:";
            // 
            // showQuest
            // 
            this.showQuest.AutoSize = true;
            this.showQuest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showQuest.Location = new System.Drawing.Point(12, 444);
            this.showQuest.Name = "showQuest";
            this.showQuest.Size = new System.Drawing.Size(105, 41);
            this.showQuest.TabIndex = 6;
            this.showQuest.Text = "Shoes:";
            // 
            // shirtAns
            // 
            this.shirtAns.Location = new System.Drawing.Point(178, 218);
            this.shirtAns.Name = "shirtAns";
            this.shirtAns.Size = new System.Drawing.Size(210, 27);
            this.shirtAns.TabIndex = 7;
            this.shirtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pantAns
            // 
            this.pantAns.Location = new System.Drawing.Point(178, 272);
            this.pantAns.Name = "pantAns";
            this.pantAns.Size = new System.Drawing.Size(210, 27);
            this.pantAns.TabIndex = 8;
            this.pantAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // jacketAns
            // 
            this.jacketAns.Location = new System.Drawing.Point(178, 332);
            this.jacketAns.Name = "jacketAns";
            this.jacketAns.Size = new System.Drawing.Size(210, 27);
            this.jacketAns.TabIndex = 9;
            this.jacketAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hatAns
            // 
            this.hatAns.Location = new System.Drawing.Point(178, 392);
            this.hatAns.Name = "hatAns";
            this.hatAns.Size = new System.Drawing.Size(210, 27);
            this.hatAns.TabIndex = 10;
            this.hatAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // shoeAns
            // 
            this.shoeAns.Location = new System.Drawing.Point(178, 458);
            this.shoeAns.Name = "shoeAns";
            this.shoeAns.Size = new System.Drawing.Size(210, 27);
            this.shoeAns.TabIndex = 11;
            this.shoeAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saveShirt
            // 
            this.saveShirt.Location = new System.Drawing.Point(446, 216);
            this.saveShirt.Name = "saveShirt";
            this.saveShirt.Size = new System.Drawing.Size(94, 29);
            this.saveShirt.TabIndex = 12;
            this.saveShirt.Text = "SAVE";
            this.saveShirt.UseVisualStyleBackColor = true;
            // 
            // savePant
            // 
            this.savePant.Location = new System.Drawing.Point(446, 270);
            this.savePant.Name = "savePant";
            this.savePant.Size = new System.Drawing.Size(94, 29);
            this.savePant.TabIndex = 13;
            this.savePant.Text = "SAVE";
            this.savePant.UseVisualStyleBackColor = true;
            // 
            // saveJacket
            // 
            this.saveJacket.Location = new System.Drawing.Point(446, 330);
            this.saveJacket.Name = "saveJacket";
            this.saveJacket.Size = new System.Drawing.Size(94, 29);
            this.saveJacket.TabIndex = 14;
            this.saveJacket.Text = "SAVE";
            this.saveJacket.UseVisualStyleBackColor = true;
            // 
            // saveHat
            // 
            this.saveHat.Location = new System.Drawing.Point(446, 390);
            this.saveHat.Name = "saveHat";
            this.saveHat.Size = new System.Drawing.Size(94, 29);
            this.saveHat.TabIndex = 15;
            this.saveHat.Text = "SAVE";
            this.saveHat.UseVisualStyleBackColor = true;
            // 
            // saveShoe
            // 
            this.saveShoe.Location = new System.Drawing.Point(446, 456);
            this.saveShoe.Name = "saveShoe";
            this.saveShoe.Size = new System.Drawing.Size(94, 29);
            this.saveShoe.TabIndex = 16;
            this.saveShoe.Text = "SAVE";
            this.saveShoe.UseVisualStyleBackColor = true;
            // 
            // inventoryBox
            // 
            this.inventoryBox.BackColor = System.Drawing.SystemColors.Window;
            this.inventoryBox.Location = new System.Drawing.Point(12, 518);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(528, 29);
            this.inventoryBox.TabIndex = 17;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(583, 518);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(149, 29);
            this.viewButton.TabIndex = 18;
            this.viewButton.Text = "VIEW INVENTORY";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(348, 602);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 29);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // clothingInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.saveShoe);
            this.Controls.Add(this.saveHat);
            this.Controls.Add(this.saveJacket);
            this.Controls.Add(this.savePant);
            this.Controls.Add(this.saveShirt);
            this.Controls.Add(this.shoeAns);
            this.Controls.Add(this.hatAns);
            this.Controls.Add(this.jacketAns);
            this.Controls.Add(this.pantAns);
            this.Controls.Add(this.shirtAns);
            this.Controls.Add(this.showQuest);
            this.Controls.Add(this.hatQuest);
            this.Controls.Add(this.pantQuest);
            this.Controls.Add(this.jacketQuest);
            this.Controls.Add(this.shirtQuest);
            this.Controls.Add(this.inventoryQuestion);
            this.Controls.Add(this.inventoryIntro);
            this.Name = "clothingInventoryForm";
            this.Text = "Clothing Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryIntro;
        private System.Windows.Forms.Label inventoryQuestion;
        private System.Windows.Forms.Label shirtQuest;
        private System.Windows.Forms.Label jacketQuest;
        private System.Windows.Forms.Label pantQuest;
        private System.Windows.Forms.Label hatQuest;
        private System.Windows.Forms.Label showQuest;
        private System.Windows.Forms.TextBox shirtAns;
        private System.Windows.Forms.TextBox pantAns;
        private System.Windows.Forms.TextBox jacketAns;
        private System.Windows.Forms.TextBox hatAns;
        private System.Windows.Forms.TextBox shoeAns;
        private System.Windows.Forms.Button saveShirt;
        private System.Windows.Forms.Button savePant;
        private System.Windows.Forms.Button saveJacket;
        private System.Windows.Forms.Button saveHat;
        private System.Windows.Forms.Button saveShoe;
        private System.Windows.Forms.Label inventoryBox;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button exitButton;
    }
}

