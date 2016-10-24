using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVFeedbackApp
{
    public partial class AddOptionSet : Form
    {
        public AddOptionSet()
        {
            InitializeComponent();
        }

        private void SaveOptionCategory_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            //Temporary Strings holding values from textbox
            string optionSetTitle = OptionSetTitle.Text;

            //Creates new OptionSet
            OptionSet newOptionSet = new OptionSet();

            //Calls constructors
            newOptionSet.GetOptionSetTitle(optionSetTitle);

            //Creates and displays new OptionForm
            SetOptionsForm OptionForm1 = new SetOptionsForm();
            OptionForm1.ShowDialog();

            //is there text in the field?
            if (string.IsNullOrEmpty(optionSetTitle))
            {
                if (MessageBox.Show("One or more fields contain no text, you must go back.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK) ;
                {
                    //what do do when button pressed
                    this.Hide();

                    OptionForm1.ShowDialog();
                }
            }
            else
            {
                //continue
            }
        }
        
        

        private void EditPreviousOptions_MouseClick(object sender, MouseEventArgs e)
        {
            //Go to previous
        }

        private void AddOptionSet_Load(object sender, EventArgs e)
        {

        }
    }
}
