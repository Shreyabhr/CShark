using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeForm
{
    public class SecondForm : Form
    {
        //private string _inputValue;
        public SecondForm(string inputValue)
        {
            //_inputValue = inputValue;
            Label label = new Label();
            label.Text = inputValue;
            label.Location = new System.Drawing.Point(10, 20);
            Controls.Add(label);
        }
    }
}
