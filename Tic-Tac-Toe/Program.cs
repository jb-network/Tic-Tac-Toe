// This is challenge work for the "C# Players Guide"
// Level 24 "Tic-Tac-Toe" Challenge
// The task is create a Tic-Tac-Toe game
// It assumes two players on the same key board
// It must display the state of the board on the console

new Game().NewGame();

public class Game
{
    public void NewGame()
    {
        //Build Game start
 
        //Build Player object
        //Player 1
        int Player1ID = 1;
        char Player1Symbol = 'X';
        string Player1Name = Player.GetPlayerNames(Player1ID);
        Player Player_1 = new Player(Player1Name, Player1ID, Player1Symbol);

        //Player 2
        int Player2ID = 2;
        char Player2Symbol = 'O';
        string Player2Name = Player.GetPlayerNames(Player2ID);
        Player Player_2 = new Player(Player2Name, Player2ID, Player2Symbol);

        //string GameRoundPlayer = Player_1.UserName;
        //Create Board
        Board Gameboard = new();

        //Game Play loop
        int GameRound = 1;
        
        while (GameRound < 10)
        {
            //Sets current player
            string GameRoundPlayer = Player.SetRound(GameRound, Player_1.UserName, Player_2.UserName);  //Selects the correct player for the round

            //Sets current player symbol
            char GameRoundSymbol;
            if (GameRoundPlayer == Player_1.UserName) GameRoundSymbol = Player_1.Symbol;
            else GameRoundSymbol = Player_2.Symbol;

            //Shows the board before the current player takes an action
            Board.ShowBoardBeforeMove(Gameboard, GameRound, GameRoundPlayer); 
            
            //Allows the player to pick location for Sumbol
            Board.PlayerChoice(GameRoundPlayer, GameRoundSymbol, Gameboard);
            
            //Shows the board after the current player takes an action
            Board.ShowBoardAfterMove(Gameboard, GameRound, GameRoundPlayer);
            
            //Check for 3 in a row
            bool CurrentWin = WinCheck(Gameboard, GameRound, GameRoundPlayer, GameRoundSymbol) ;
            if (CurrentWin == true)
            {                
                Console.WriteLine($"Congratulations {GameRoundPlayer} you won Tic-Tac-Toe!");
                Console.WriteLine("WINNER, WINNER, CHICKEN DINNER!");
                Console.WriteLine("The game is over");
                Console.WriteLine("Press any key to end the game");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if(GameRound == 9)
            {                
                Console.WriteLine("The Game Ended in a Tie");
                Console.WriteLine("YOU ARE NOT THE WINNER, BUT YOU ARE NOT THE LOSER");
                Console.WriteLine("Press any key to end the game");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
            else
            {
                Console.WriteLine("Press Any Key to move to the next round");
                Console.ReadKey();
                Console.Clear();
                GameRound++;
            }

        }
        //End of program
        Console.ReadKey();
    }

    private bool WinCheck(Board Gameboard, int Round, string Player, char PlayerSymbol)
    {
        //Check Diagonal for win
        if (Gameboard.BoardStatus[0, 0] == PlayerSymbol && Gameboard.BoardStatus[1, 1] == PlayerSymbol && Gameboard.BoardStatus[2, 2] == PlayerSymbol) return true;
        if (Gameboard.BoardStatus[2, 0] == PlayerSymbol && Gameboard.BoardStatus[1, 1] == PlayerSymbol && Gameboard.BoardStatus[0, 2] == PlayerSymbol) return true;

        // Check Rows for win
        if (Gameboard.BoardStatus[0, 0] == PlayerSymbol && Gameboard.BoardStatus[0, 1] == PlayerSymbol && Gameboard.BoardStatus[0, 2] == PlayerSymbol) return true;
        if (Gameboard.BoardStatus[1, 0] == PlayerSymbol && Gameboard.BoardStatus[1, 1] == PlayerSymbol && Gameboard.BoardStatus[1, 2] == PlayerSymbol) return true;
        if (Gameboard.BoardStatus[2, 0] == PlayerSymbol && Gameboard.BoardStatus[2, 1] == PlayerSymbol && Gameboard.BoardStatus[2, 2] == PlayerSymbol) return true;

        // Check Columns for win
        if (Gameboard.BoardStatus[0, 0] == PlayerSymbol && Gameboard.BoardStatus[1, 0] == PlayerSymbol && Gameboard.BoardStatus[2, 0] == PlayerSymbol) return true;
        if (Gameboard.BoardStatus[0, 1] == PlayerSymbol && Gameboard.BoardStatus[1, 1] == PlayerSymbol && Gameboard.BoardStatus[2, 1] == PlayerSymbol) return true;
        if (Gameboard.BoardStatus[0, 2] == PlayerSymbol && Gameboard.BoardStatus[1, 2] == PlayerSymbol && Gameboard.BoardStatus[2, 2] == PlayerSymbol) return true;
        return false;
    }
}

public class Board
{
    public char[,] BoardStatus = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

    internal static void ShowBoardBeforeMove(Board Gameboard, int Round, string Player)
    {
        Console.WriteLine("***********************************");
        Console.WriteLine($"ROUND: {Round} PLAYER: {Player}");
        Console.WriteLine("***********************************");
        Console.WriteLine($"START OF ROUND {Round}");
        Console.WriteLine("***********************************");
        Console.WriteLine("|---+---+---|");
        Console.WriteLine($"| {Gameboard.BoardStatus[0, 0]} | {Gameboard.BoardStatus[0, 1]} | {Gameboard.BoardStatus[0, 2]} |");
        Console.WriteLine("|---+---+---|");
        Console.WriteLine($"| {Gameboard.BoardStatus[1, 0]} | {Gameboard.BoardStatus[1, 1]} | {Gameboard.BoardStatus[1, 2]} |");
        Console.WriteLine("|---+---+---|");
        Console.WriteLine($"| {Gameboard.BoardStatus[2, 0]} | {Gameboard.BoardStatus[2, 1]} | {Gameboard.BoardStatus[2, 2]} |");
        Console.WriteLine("|---+---+---|");
        Console.WriteLine("***********************************");
    }

    internal static void ShowBoardAfterMove(Board Gameboard, int Round, string Player)
    {
        Console.Clear();
        Console.WriteLine("***********************************");
        Console.WriteLine($"ROUND: {Round} PLAYER: {Player}");
        Console.WriteLine("***********************************");
        Console.WriteLine($"END OF ROUND {Round}");
        Console.WriteLine("***********************************");
        Console.WriteLine("|---+---+---|");
        Console.WriteLine($"| {Gameboard.BoardStatus[0, 0]} | {Gameboard.BoardStatus[0, 1]} | {Gameboard.BoardStatus[0, 2]} |");
        Console.WriteLine("|---+---+---|");
        Console.WriteLine($"| {Gameboard.BoardStatus[1, 0]} | {Gameboard.BoardStatus[1, 1]} | {Gameboard.BoardStatus[1, 2]} |");
        Console.WriteLine("|---+---+---|");
        Console.WriteLine($"| {Gameboard.BoardStatus[2, 0]} | {Gameboard.BoardStatus[2, 1]} | {Gameboard.BoardStatus[2, 2]} |");
        Console.WriteLine("|---+---+---|");
        Console.WriteLine("***********************************");
    }

    internal static void PlayerChoice(string PlayerName, char Symbol, Board Board)
    {
        int? UserSelection;
        do
        {
            //Will not work if user enters a string rather than a number
            //bool isNumber = int.TryParse(s1, out int n); would test for this, but this is beyond the scope of this task

            Console.WriteLine($"Hello {PlayerName}.");
            Console.WriteLine($"Please choose a number to place an {Symbol} in");
            UserSelection = Convert.ToInt16(Console.ReadLine());

            switch (UserSelection)
            {
                case 1:
                    Board.BoardStatus[0, 0] = Symbol;
                    break;
                case 2:
                    Board.BoardStatus[0, 1] = Symbol;
                    break;
                case 3:
                    Board.BoardStatus[0, 2] = Symbol;
                    break;
                case 4:
                    Board.BoardStatus[1, 0] = Symbol;
                    break;
                case 5:
                    Board.BoardStatus[1, 1] = Symbol;
                    break;
                case 6:
                    Board.BoardStatus[1, 2] = Symbol;
                    break;
                case 7:
                    Board.BoardStatus[2, 0] = Symbol;
                    break;
                case 8:
                    Board.BoardStatus[2, 1] = Symbol;
                    break;
                case 9:
                    Board.BoardStatus[2, 2] = Symbol;
                    break;
                default:
                    Console.WriteLine("The selection you made is not valid");
                    Console.WriteLine("Please try again");                                        
                    break;
            }
        } while (UserSelection == null  || UserSelection < 0 || UserSelection > 9 );
    }
}

public class Player
{
    public string UserName { get; }
    public int PlayerNumber { get; }
    public char Symbol { get; }

    public Player(string User, int PlayerNum, char PlayerSymbol)
    {
        UserName = User;
        PlayerNumber = PlayerNum;
        Symbol = PlayerSymbol;
    }

    //User provided player names
    internal static string GetPlayerNames(int PlayerNumber)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe");
        Console.WriteLine("Best of luck to you!\n");
        Console.WriteLine($"Please enter Player {PlayerNumber}'s Name: ");
        string? Name = Console.ReadLine();
        if (Name == "" || Name == null) Name = $"Player {PlayerNumber}";
        Console.WriteLine($"Name: {Name} set for Player: {PlayerNumber} ");
        Console.WriteLine("Press any key to proceed");
        Console.ReadKey();
        Console.Clear();
        return Name;
    }
    
    //Sets the player Name for the Round
    internal static string SetRound(int GameRound, string Player1, string Player2)
    {
        if (GameRound != 1)
        {
            if (GameRound % 2 != 0) return Player1;
            else return Player2;
        }
        else return Player1;
    }
}
