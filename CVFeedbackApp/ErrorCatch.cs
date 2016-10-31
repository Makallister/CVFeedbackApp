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
    public class ErrorCatch
    {
        ErrorCatch ErrorCatcher = new ErrorCatch();
        
        public void NewTemplateError()
        {
            if (MessageBox.Show("One or more fields contain no text, you must go back.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK) ;
            {
                //what do do when button pressed
                
                CreateNewTemplateForm NewCreateNewTemplateForm = new CreateNewTemplateForm();
                NewCreateNewTemplateForm.ShowDialog();
            }
        }
            
     }
}

