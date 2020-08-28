using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DinnerParty
{
    public partial class Form1 : Form
    {

        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBoxHealthyDecorations.Checked, checkBoxFancyDecorations.Checked);
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, textBoxWriting.Text);

        }

        private void DisplayDinnerPartyCost()
        {
            textBoxCost.Text = dinnerParty.Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBoxFancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = checkBoxFancyDecorations.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBoxHealthyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = checkBoxHealthyDecorations.Checked;
            DisplayDinnerPartyCost();
        }
    }
}
