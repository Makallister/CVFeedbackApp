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
            string optionSetTitle = OptionSetTitle.Text;
            SetOptionsForm OptionForm1 = new SetOptionsForm();
            OptionForm1.ShowDialog();
        }
    }
}
