using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleWinForm
{
    class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            this.Text = "Swabhav";

            Button redBtn = new Button();
            redBtn.Text = "red";
            redBtn.Location = new System.Drawing.Point(50, 50);
            redBtn.Click += new EventHandler(ChangeBackgroundColor);

            Button blueBtn = new Button();
            blueBtn.Text = "blue";
            blueBtn.Location = new System.Drawing.Point(150, 50);
            blueBtn.Click += new EventHandler(ChangeBackgroundColor);

            Controls.Add(redBtn);
            Controls.Add(blueBtn);
        }

        private void ChangeBackgroundColor(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button.Text == "red")
            {
                this.BackColor = Color.Red;
                return;
            }
            this.BackColor = Color.Blue;
        }

    }
}
