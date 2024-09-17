 using System;
using System.Windows.Forms;

public class TicTacToeMethods
{
    char[,] board = new char[3, 3];

    int iNumberOfMoves = 0;

    public TicTacToeMethods()
    {
        // Inicjalizacja pustej tablicy
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';  // Oznacza puste pole
            }
        }
    }

    public bool makeMove(char playerSymbol, int row, int col)
    {
        //Sprawdzamy czy dane pole jest wolne
        if (board[row, col] != ' ')
        {
            return false;
        }

        // Zapisujemy ruch na planszy
        board[row, col] = playerSymbol;
        iNumberOfMoves++;
        return true;
    }

    // Sprawdzanie w grze, po ilości ruchów
    public bool checkDraw()
    {
        if (iNumberOfMoves == 9)
        {
            return true;
        }

        return false;
    }

    // Sprawdzanie remisu dla algorytmu minimax
    public bool checkDraw2()
    {
        if (board[0, 0] != ' ' && board[0, 1] != ' ' && board[0, 2] != ' '
            && board[1, 0] != ' ' && board[1, 1] != ' ' && board[1, 2] != ' '
            && board[2, 0] != ' ' && board[2, 1] != ' ' && board[2, 2] != ' ')
        {
            return true;
        }

        return false;
    }

    public bool checkWin(char playerSymbol)
    {
        // Poziomy
        if ((board[0, 0] == playerSymbol && board[0, 1] == playerSymbol && board[0, 2] == playerSymbol) ||
            (board[1, 0] == playerSymbol && board[1, 1] == playerSymbol && board[1, 2] == playerSymbol) ||
            (board[2, 0] == playerSymbol && board[2, 1] == playerSymbol && board[2, 2] == playerSymbol))
        {
            return true;
        }

        // Piony
        if ((board[0, 0] == playerSymbol && board[1, 0] == playerSymbol && board[2, 0] == playerSymbol) ||
            (board[0, 1] == playerSymbol && board[1, 1] == playerSymbol && board[2, 1] == playerSymbol) ||
            (board[0, 2] == playerSymbol && board[1, 2] == playerSymbol && board[2, 2] == playerSymbol))
        {
            return true;
        }

        // Skosy
        if ((board[0, 0] == playerSymbol && board[1, 1] == playerSymbol && board[2, 2] == playerSymbol) ||
            (board[0, 2] == playerSymbol && board[1, 1] == playerSymbol && board[2, 0] == playerSymbol))
        {
            return true;
        }

        return false;
    }

    // Implementacja algorytmu Minimax
    public int minimax(bool isMax)
    {
        bool bWin;

        // Zwracamy 1, jeśli wygrał gracz X
        bWin = checkWin('X');
        if (bWin)
        {
            return 1;
        }
        // Zwracamy -1, jeśli wygrał gracz O
        bWin = checkWin('O');
        if (bWin)
        {
            return -1;
        }

        // Zwracamy 0, jeśli remis
        bWin = checkDraw2();
        if (bWin)
        {
            return 0;
        }

        if (isMax) // Wywołanie minimax dla gracza X 
        {
            int iBestScore = int.MinValue; // Na start minimalmna wartość dla int 

            // Przechodzimy po całej planszy gry
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Sprawdzamy, czy pole puste
                    if (board[i, j] == ' ')
                    {                   
                        // Wykonujemy ruch na pustym polu przez gracza X
                        board[i, j] = 'X';

                        // Wywołujemy rekurencyjnie algorytm minimax
                        iBestScore = Math.Max(iBestScore, minimax(false));

                        // Cofamy ruch
                        board[i, j] = ' ';
                    }
                }
            }
            return iBestScore;
        }
        else // Wywołanie minimax dla gracza O
        {
            int iBestScore = int.MaxValue; // Na start maksymalna wartość dla int 

            // Przechodzimy po całej planszy gry
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Sprawdzamy, czy pole jest puste
                    if (board[i, j] == ' ')
                    {
                        // Wykonujemy ruch na pustym polu przez gracza O
                        board[i, j] = 'O';

                        // Wywołujemy rekurencyjnie algorytm minimax
                        iBestScore = Math.Min(iBestScore, minimax(true));

                        // Cofamy ruch
                        board[i, j] = ' ';
                    }
                }
            }
            return iBestScore;
        }
    }

    //Znajdowanie najlepszego ruchu dla gracza O
    public (int, int) findBestMoveO()
    {
        int iBestScore = int.MaxValue; // Na start maksymalna wartość dla int 
        int iBestRow = -1;
        int iBestCol = -1;

        // Przechodzimy po całej planszy gry
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // Sprawdzamy, czy pole jest puste
                if (board[i, j] == ' ')
                {
                    // Wykonujemy ruch na pustym polu przez gracza O
                    board[i, j] = 'O';

                    // Wywołujemy algorytm minimax dla tego ruchu
                    int iMoveScore = minimax(true);

                    // Cofamy ruch
                    board[i, j] = ' ';

                    // Jeśli ten ruch jest optymalny, to go zapamiętujemy
                    if (iMoveScore < iBestScore)
                    {
                        iBestRow = i;
                        iBestCol = j;
                        iBestScore = iMoveScore;
                    }
                }
            }
        }

        // Zwracamy najlepszy ruch
        return (iBestRow, iBestCol);
    }

    //Znajdowanie najlepszego ruchu dla gracza X
    public (int, int) findBestMove()
    {
        int iBestScore = int.MinValue; // Na start minimalmna wartość dla int 
        int iBestRow = -1;
        int iBestCol = -1;

        // Przechodzimy po całej planszy gry
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // Sprawdzamy, czy pole jest puste
                if (board[i, j] == ' ')
                {
                    // Wykonujemy ruch na pustym polu przez gracza X
                    board[i, j] = 'X';

                    // Wywołujemy algorytm minimax dla tego ruchu
                    int iMoveScore = minimax(false);

                    // Cofamy ruch
                    board[i, j] = ' ';

                    // Jeśli ten ruch jest optymalny, to go zapamiętujemy
                    if (iMoveScore > iBestScore)
                    {
                        iBestRow = i;
                        iBestCol = j;
                        iBestScore = iMoveScore;
                    }
                }
            }
        }

        // Zwracamy najlepszy ruch
        return (iBestRow, iBestCol);
    }

}