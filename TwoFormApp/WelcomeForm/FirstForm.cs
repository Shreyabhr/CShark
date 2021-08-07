using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeForm
{
    public class FirstForm : Form
    {
        private TextBox input;
        public FirstForm()
        {
            Label label = new Label();
            input = new TextBox();
         

            label.Location = new System.Drawing.Point(10, 20);
            input.Location = new System.Drawing.Point(10, 60);

            label.Text = "Name";
          

            Button button = new Button();
            button.Text = "next";
            button.Location = new System.Drawing.Point(10, 90);

            button.Click += new EventHandler(PassTheInputValue);
            Controls.Add(label);
            Controls.Add(input);
            Controls.Add(button);
        }

        private void PassTheInputValue(object sender, EventArgs e)
        {
            string value = input.Text;
            Console.WriteLine(value);
            SecondForm form2 = new SecondForm(value);
            form2.ShowDialog();
         
        }

        
    }
}
