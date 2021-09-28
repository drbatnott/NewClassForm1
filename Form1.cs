using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewClassForm1
{
    public partial class PersonDataForm : Form
    {
        public PersonDataForm()
        {
            InitializeComponent();
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            dataListBox.Items.Add("Name " + nameTextBox.Text);
            dataListBox.Items.Add("Height in cm " + cmTextBox.Text);
            dataListBox.Items.Add("Mass in kg " + kgTextBox.Text);
        }
    }
}
