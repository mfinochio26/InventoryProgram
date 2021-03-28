using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    public partial class clothingInventoryForm : Form // inventory class
    {
        public clothingInventoryForm()
        {
            InitializeComponent();
        }
        public Boolean shirtInventory = false; //boolean for if shirt box is filled out
        public Boolean pantInventory = false; // boolean for if pants box is filled out
        public Boolean jacketInventory = false; // boolean for if jacket box is filled out
        public Boolean hatInventory = false; //boolean for if hate box is filled out
        public Boolean shoeInventory = false; //boolean for if shoe box is filled out

        private void saveShirt_Click(object sender, EventArgs e)
        {
            //when user presses save it turns the boolean statement to true
            shirtInventory = true;
        }

        private void savePant_Click(object sender, EventArgs e)
        {
            //when user presses save it turns the boolean statement to true
            pantInventory = true;
        }

        private void saveJacket_Click(object sender, EventArgs e)
        {
            //when user presses save it turns the boolean statement to true
            jacketInventory = true;
        }

        private void saveHat_Click(object sender, EventArgs e)
        {
            //when user presses save it turns the boolean statement to true
            hatInventory = true;
        }

        private void saveShoe_Click(object sender, EventArgs e)
        {
            //when user presses save it turns the boolean statement to true
            shoeInventory = true;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            //once all boxes are filled out and saved
            if (shirtInventory == true && pantInventory == true && jacketInventory == true
                && hatInventory == true && shoeInventory == true)
            {
                int shirts; //amount of shirts
                int pants; //amount of pants
                int jackets; //amount of jackets
                int hats; //amount of hats
                int shoes; //amount of shoes
                int totalInventory; //sum of all inventory items

                try
                {
                    //tries to convert user input into an integer and save each item
                    shirts = int.Parse(shirtAns.Text);
                    pants = int.Parse(pantAns.Text);
                    jackets = int.Parse(jacketAns.Text);
                    hats = int.Parse(hatAns.Text);
                    shoes = int.Parse(shoeAns.Text);

                    //adds all items together and saves as total inventory
                    totalInventory = shirts + pants + jackets + hats + shoes;

                    //displays all inventory and total inventory
                    inventoryBox.Text = "You have " + shirts + " shirts, " + pants + "  pairs of pants, " +
                        jackets + " jackets, " + hats + " hats, and " + shoes +
                        " pairs of shoes, making your total inventory " + totalInventory + " pieces of clothing.";
                }
                catch
                {
                    //if any of the boxes are not filled with an integer and cannot be converted
                    MessageBox.Show("Please make sure all answers are a valid integer...");
                }
            }
            else
            {
                //if user did not save all boxes
                MessageBox.Show("Please fill out all inventory boxes and press save...");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
