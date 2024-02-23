using System;
Console.CursorVisible = false;
Console.ForegroundColor = ConsoleColor.Red;


string[,] board = new string[3, 3];
bool HasWon = false, IsPlayer1 = true;
string border = "   +---+---+---+";
char letter = 'A', row, col;
int x = 0, xaxis, yaxis, rowcheck = 1, colcheck = 1, playercheck = 0;
Console.WriteLine("Willkommen zu Tic Tac Toe");
Console.WriteLine("Spieler 1 ist X und Spieler 2 ist O");
Console.WriteLine("Die Felder werden mit A1, A2, A3, B1, B2, B3, C1, C2, C3 bezeichnet");
Console.WriteLine("Drücken Sie Enter um zu starten");
Console.ReadLine();
Console.Clear();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        board[i, j] = " ";
    }
}
Console.WriteLine("     1   2   3");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(border);
    Console.Write((char)(letter + x) + "  ");
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"| {board[i, j]} ");
    }
    Console.Write("|");
    Console.WriteLine();
    x++;
}
Console.WriteLine(border);
x = 0;

do
{
    if (IsPlayer1 == true)
    {
        Console.Write("Spieler 1 wo wollen sie setzen: ");
        string input = Console.ReadLine()!.ToUpper();
        Console.Clear();
        if (input[0] >= 'A' && input[0] <= 'C')
        {
            row = input[0];
            col = input[1];
        }
        else
        {
            row = input[1];
            col = input[0];
        }

        if (board[row - 'A', col - '1'] == " ")
        {
            board[row - 'A', col - '1'] = "X";

            Console.WriteLine("     1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(border);
                Console.Write((char)(letter + x) + "  ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"| {board[i, j]} ");
                }
                Console.Write("|");
                Console.WriteLine();
                x++;
            }
            Console.WriteLine(border);
            x = 0;
            IsPlayer1 = false;
        }
        else
        {
            IsPlayer1 = true;
            Console.WriteLine("Dieses Feld ist schon besetzt!");
            Thread.Sleep(1000);
            Console.Clear();
        }


        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] != " " && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                HasWon = true;
                if (board[i, 0] == "X")
                {
                    Console.WriteLine();
                    Console.WriteLine("Spieler 1 hat gewonnen");
                }
                else if (board[i, 0] == "O")
                {
                    Console.WriteLine();
                    Console.WriteLine("Spieler 2 hat gewonnen");
                }
            }
        }
        for (int j = 0; j < 3; j++)
        {
            if (board[0, j] != " " && board[0, j] == board[1, j] && board[1, j] == board[2, j])
            {
                HasWon = true;
                if (board[0, j] == "X")
                {
                    Console.WriteLine();
                    Console.WriteLine("Spieler 1 hat gewonnen");
                }
                else if (board[0, j] == "O")
                {
                    Console.WriteLine();
                    Console.WriteLine("Spieler 2 hat gewonnen");
                }
            }
        }
        if (board[0, 0] != " " && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            HasWon = true;
            if (board[0, 0] == "X")
            {
                Console.WriteLine();
                Console.WriteLine("Spieler 1 hat gewonnen");
            }
            else if (board[0, 0] == "O")
            {
                Console.WriteLine();
                Console.WriteLine("Spieler 2 hat gewonnen");
            }
        }
        else if (board[0, 2] != " " && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            HasWon = true;
            if (board[0, 2] == "X")
            {
                Console.WriteLine();
                Console.WriteLine("Spieler 1 hat gewonnen");
            }
            else if (board[0, 2] == "O")
            {
                Console.WriteLine();
                Console.WriteLine("Spieler 2 hat gewonnen");
            }
        }
    }


    else if (IsPlayer1 == false && HasWon == false)
    {
        Console.Write("Spieler 2 wo wollen sie setzen: ");
        string input = Console.ReadLine()!.ToUpper();
        Console.Clear();
        if (input[0] >= 'A' && input[0] <= 'C')
        {
            row = input[0];
            col = input[1];
        }
        else
        {
            row = input[1];
            col = input[0];
        }

        if (board[row - 'A', col - '1'] == " ")
        {
            board[row - 'A', col - '1'] = "O";

            Console.WriteLine("     1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(border);
                Console.Write((char)(letter + x) + "  ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"| {board[i, j]} ");
                }
                Console.Write("|");
                Console.WriteLine();
                x++;
            }
            Console.WriteLine(border);
            x = 0;
            IsPlayer1 = true;
        }
        else
        {
            IsPlayer1 = false;
            Console.WriteLine("Dieses Feld ist schon besetzt!");
            Thread.Sleep(1000);
            Console.Clear();
        }


        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] != " " && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                HasWon = true;
                if (board[i, 0] == "X")
                {
                    Console.WriteLine();
                    Console.WriteLine("Spieler 1 hat gewonnen");
                }
                else if (board[i, 0] == "O")
                {
                    Console.WriteLine();
                    Console.WriteLine("Spieler 2 hat gewonnen");
                }
            }
        }
        for (int j = 0; j < 3; j++)
        {
            if (board[0, j] != " " && board[0, j] == board[1, j] && board[1, j] == board[2, j])
            {
                HasWon = true;
                if (board[0, j] == "X")
                {
                    Console.WriteLine();
                    Console.WriteLine("Spieler 1 hat gewonnen");
                }
                else if (board[0, j] == "O")
                {
                    Console.WriteLine();
                    Console.WriteLine("Spieler 2 hat gewonnen");
                }
            }
        }

        if (board[0, 0] != " " && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            HasWon = true;
            if (board[0, 0] == "X")
            {
                Console.WriteLine();
                Console.WriteLine("Spieler 1 hat gewonnen");
            }
            else if (board[0, 0] == "O")
            {
                Console.WriteLine();
                Console.WriteLine("Spieler 2 hat gewonnen");
            }
        }
        else if (board[0, 2] != " " && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            HasWon = true;
            if (board[0, 2] == "X")
            {
                Console.WriteLine();
                Console.WriteLine("Spieler 1 hat gewonnen");
            }
            else if (board[0, 2] == "O")
            {
                Console.WriteLine();
                Console.WriteLine("Spieler 2 hat gewonnen");
            }
        }
    }
} while (HasWon == false);

