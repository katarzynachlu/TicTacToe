using Microsoft.VisualBasic;
using System.DirectoryServices;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        TicTacToeMethods cMethods;
        bool bResult;
        bool bWin;
        bool bDraw;
        char cPlayer = 'X';
        char cCompSymbol;
        char[] cOptions = { 'X', 'O'};
        char cMode;
        int cRow;
        int cCol;
        public Form1(char cInputMode)
        {
            InitializeComponent();
            cMethods = new TicTacToeMethods();
            labelKoniecGry.Visible = false;
            cMode = cInputMode;
            // Je¿eli gra z komputerem, to pierwszy ruch komputera
            if (cMode == 'C')
            {
                Random random = new Random();
                int randomNumberComp = random.Next(0, 2);
                cCompSymbol = cOptions[randomNumberComp];

                if (cCompSymbol == 'X')
                {
                    int randomNumber = random.Next(1, 5);

                    switch (randomNumber)
                    {
                        case 1:
                            cMethods.makeMove(cPlayer, 0, 0);
                            button1.Text = cPlayer.ToString();
                            switchPlayer();
                            break;
                        case 2:
                            cMethods.makeMove(cPlayer, 0, 2);
                            button3.Text = cPlayer.ToString();
                            switchPlayer();
                            break;
                        case 3:
                            cMethods.makeMove(cPlayer, 2, 0);
                            button7.Text = cPlayer.ToString();
                            switchPlayer();
                            break;
                        case 4:
                            cMethods.makeMove(cPlayer, 2, 2);
                            button9.Text = cPlayer.ToString();
                            switchPlayer();
                            break;
                    }
                }
            }
        }

        private void switchPlayer() //Zmiana gracza
        {
            switch (cPlayer) {
                case 'X':
                    cPlayer = 'O';
                    break;
                case 'O':
                    cPlayer = 'X';
                    break;
            }
        }

        private void checkWinOrDraw()
        {
            bWin = cMethods.checkWin(cPlayer);
            if (bWin == true)
            {
                MessageBox.Show("Koniec gry. Wygra³ gracz " + cPlayer + ".", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelKoniecGry.Visible = true;
                return;
            }
            bDraw = cMethods.checkDraw();
            if (bDraw == true)
            {
                MessageBox.Show("Koniec gry. Remis.", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelKoniecGry.Visible = true;
                return;
            }

            switchPlayer();

            if (cMode == 'C' && cPlayer == cCompSymbol)
            {
                if (cPlayer == 'X')
                {
                    (cRow, cCol) = cMethods.findBestMove();
                }
                else
                {
                    (cRow, cCol) = cMethods.findBestMoveO();
                }
                cMethods.makeMove(cPlayer, cRow, cCol);

                if (cRow == 0 && cCol == 0)
                {
                    button1.Text = cPlayer.ToString();
                }

                else if (cRow == 0 && cCol == 1)
                {
                    button2.Text = cPlayer.ToString();
                }

                else if (cRow == 0 && cCol == 2)
                {
                    button3.Text = cPlayer.ToString();  
                }

                else if (cRow == 1 && cCol == 0)
                {
                    button4.Text = cPlayer.ToString();
                }
                else if (cRow == 1 && cCol == 1)
                {
                    button5.Text = cPlayer.ToString();
                }

                else if (cRow == 1 && cCol == 2)
                {
                    button6.Text = cPlayer.ToString();
                }

                else if (cRow == 2 && cCol == 0)
                {
                    button7.Text = cPlayer.ToString();
                }

                else if (cRow == 2 && cCol == 1)
                {
                    button8.Text = cPlayer.ToString();
                }

                else if (cRow == 2 && cCol == 2)
                {
                    button9.Text = cPlayer.ToString();
                }
                checkWinOrDraw();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bWin == true)
            {
                return;
            }

            bResult = cMethods.makeMove(cPlayer, 0, 0);
            if (bResult == true)
            {
                button1.Text = cPlayer.ToString();
                checkWinOrDraw();
            }
            else
            {
                MessageBox.Show("Wyst¹pi³ b³¹d - to pole jest ju¿ zajête!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bWin == true)
            {
                return;
            }

            bResult = cMethods.makeMove(cPlayer, 0, 1);
            if (bResult == true)
            {
                button2.Text = cPlayer.ToString();
                checkWinOrDraw();
            }
            else
            {
                MessageBox.Show("Wyst¹pi³ b³¹d - to pole jest ju¿ zajête!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bWin == true)
            {
                return;
            }

            bResult = cMethods.makeMove(cPlayer, 0, 2);
            if (bResult == true)
            {
                button3.Text = cPlayer.ToString();
                checkWinOrDraw();
            }
            else
            {
                MessageBox.Show("Wyst¹pi³ b³¹d - to pole jest ju¿ zajête!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bWin == true)
            {
                return;
            }

            bResult = cMethods.makeMove(cPlayer, 1, 0);
            if (bResult == true)
            {
                button4.Text = cPlayer.ToString();
                checkWinOrDraw();
            }
            else
            {
                MessageBox.Show("Wyst¹pi³ b³¹d - to pole jest ju¿ zajête!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bWin == true)
            {
                return;
            }

            bResult = cMethods.makeMove(cPlayer, 1, 1);
            if (bResult == true)
            {
                button5.Text = cPlayer.ToString();
                checkWinOrDraw();
            }
            else
            {
                MessageBox.Show("Wyst¹pi³ b³¹d - to pole jest ju¿ zajête!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bWin == true)
            {
                return;
            }

            bResult = cMethods.makeMove(cPlayer, 1, 2);
            if (bResult == true)
            {
                button6.Text = cPlayer.ToString();
                checkWinOrDraw();
            }
            else
            {
                MessageBox.Show("Wyst¹pi³ b³¹d - to pole jest ju¿ zajête!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bWin == true)
            {
                return;
            }

            bResult = cMethods.makeMove(cPlayer, 2, 0);
            if (bResult == true)
            {
                button7.Text = cPlayer.ToString();
                checkWinOrDraw();
            }
            else
            {
                MessageBox.Show("Wyst¹pi³ b³¹d - to pole jest ju¿ zajête!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bWin == true)
            {
                return;
            }

            bResult = cMethods.makeMove(cPlayer, 2, 1);
            if (bResult == true)
            {
                button8.Text = cPlayer.ToString();
                checkWinOrDraw();
            }
            else
            {
                MessageBox.Show("Wyst¹pi³ b³¹d - to pole jest ju¿ zajête!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bWin == true)
            {
                return;
            }

            bResult = cMethods.makeMove(cPlayer, 2, 2);
            if (bResult == true)
            {
                button9.Text = cPlayer.ToString();
                checkWinOrDraw();
            }
            else
            {
                MessageBox.Show("Wyst¹pi³ b³¹d - to pole jest ju¿ zajête!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
