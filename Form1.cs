namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WIn checkWin = new WIn();

        bool X = false;
        bool O = true;

        char x = 'x';
        char o = 'o';

        int count = 0;

        private void Win()
        {
            if(count > 2) { 
                if (checkWin.CheckForWin(x))
                {
                    MessageBox.Show("Х победил");
                    Close();
                }
                else if (checkWin.CheckForWin(o))
                {
                    MessageBox.Show("O победил");
                    Close();
                }
            }
        }

        private string CheckClick(string buttonText, int x, int y)
        {
            count++;
            string currentText = buttonText;

            if (currentText == " ")
            {
                if (O)
                {
                    currentText = "o";
                    O = false;
                    X = true;

                    checkWin.board[x, y] = 'o';
                }
                else
                {
                    currentText = "x";
                    O = true;
                    X = false;

                    checkWin.board[x, y] = 'x';
                }

            }
            return currentText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = CheckClick(button1.Text, 0, 0);
            Win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = CheckClick(button4.Text, 0, 1);
            Win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = CheckClick(button5.Text, 0, 2);
            Win();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = CheckClick(button2.Text, 1, 0);
            Win();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = CheckClick(button6.Text, 1, 1);
            Win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = CheckClick(button7.Text, 1, 2);
            Win();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = CheckClick(button3.Text, 2, 0);
            Win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = CheckClick(button8.Text, 2, 1);
            Win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = CheckClick(button9.Text, 2, 2);
            Win();
        }
    }
}