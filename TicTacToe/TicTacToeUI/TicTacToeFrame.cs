using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using TicTacToeGame;

namespace TicTacToeUI
{
    class TicTacToeFrame : Form
    {
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Game game;
        private Board board;
        private ResultAnalyzer resultAnalyzer;
        private Label label1;
        private Label label2;
        private List<Button> buttons = new List<Button>();

        public TicTacToeFrame()
        {
            Player p1 = new Player("shreya", Mark.O);
            Player p2 = new Player("prachi", Mark.X);

            List<Player> players = new List<Player>();
            players.Add(p1);
            players.Add(p2);
            board = new Board(3);
            resultAnalyzer = new ResultAnalyzer(board);
            game = new Game(players, board, resultAnalyzer);
            InitializeComponent();   
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(88, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 373);
            this.panel1.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(313, 254);
            this.button9.Name = "8";
            this.button9.Size = new System.Drawing.Size(150, 120);
            this.button9.TabIndex = 8;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Play);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(156, 254);
            this.button8.Name = "7";
            this.button8.Size = new System.Drawing.Size(150, 120);
            this.button8.TabIndex = 7;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Play);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 253);
            this.button7.Name = "6";
            this.button7.Size = new System.Drawing.Size(150, 120);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Play);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(312, 132);
            this.button6.Name = "5";
            this.button6.Size = new System.Drawing.Size(150, 120);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Play);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(156, 132);
            this.button5.Name = "4";
            this.button5.Size = new System.Drawing.Size(150, 120);
            this.button5.TabIndex = 4;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Play);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 132);
            this.button4.Name = "3";
            this.button4.Size = new System.Drawing.Size(150, 120);
            this.button4.TabIndex = 3;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Play);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 3);
            this.button3.Name = "2";
            this.button3.Size = new System.Drawing.Size(150, 120);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Play);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 3);
            this.button2.Name = "1";
            this.button2.Size = new System.Drawing.Size(150, 120);
            this.button2.TabIndex = 1;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Play);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "0";
            this.button1.Size = new System.Drawing.Size(150, 120);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Play);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(85, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "CurrentPlayer";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(94, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 2;
            string ownerName = ConfigurationManager.AppSettings["ownerName"];
            string contactInfo = ConfigurationManager.AppSettings["contactInfo"];
            this.label2.Text = "Owner: "+ ownerName + " - " +contactInfo;

            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            // 
            // TicTacToeFrame
            // 
            this.ClientSize = new System.Drawing.Size(802, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "TicTacToeFrame";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Play(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //button.Text = "presses";
            //Console.WriteLine(button.na);
            Perform(Convert.ToInt32(button.Name));
        }

        private void Perform(int btnIndex)
        {
            int index = btnIndex;
            try
            {
                game.Play(index);
                MarkTheButton(index);
                label1.Text = game.GetCurrentPlayer().GetName();
            }
            catch (CellAlreadyMarkedException e)
            {
                game.ChangePlayer();
                MessageBox.Show(e.Message, "Cell already marked",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Result result = resultAnalyzer.GetResult(board, game.GetCurrentPlayer().GetMark(), btnIndex);
            if (CheckWin(result) || CheckDraw(result))
            {
                return;
            }
        }

        private void MarkTheButton(int index)
        {
            if (game.GetCurrentPlayer().GetMark() == Mark.X)
            {
                buttons.ElementAt(index).Text = "X";
            }
            else if (game.GetCurrentPlayer().GetMark() == Mark.O)
            {
                buttons.ElementAt(index).Text = "O";
            }
        }

        public bool CheckWin(Result result)
        {
            if (result == Result.WIN)
            {
                MessageBox.Show("Congratulations ," + game.GetCurrentPlayer().GetName() + " Won");
                DisableButtons();
                return true;
            }
            return false;
        }

        private void DisableButtons()
        {
            foreach(var button in buttons)
            {
                button.Enabled = false;
            }
        }

        public bool CheckDraw(Result result)
        {
            if (result == Result.DRAW)
            {
                MessageBox.Show("It is a draw");
                DisableButtons();
                return true;
            }
            return false;
        }
    }
}
