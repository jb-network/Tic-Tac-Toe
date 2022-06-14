// This is challenge work for the "C# Players Guide"
// Level 24 "Tic-Tac-Toe" Challenge
// The task is create a Tic-Tac-Toe game
// It assumes two players on the same key board
// It must display the state of the board on the console

// Creates New MainGame Object

//Test area
// User Selection menu
// User loop to set up numbers


//This is a rough prototype of the game loop.  More is neede but the basics are here. 
// A cheap trick for player rotation could be to use round with Mod to get even or odd round number.  If odd player 1 turn, if even player 2 turn. There might be an better way.  
Console.WriteLine("Pick the current player for testing: 'Player1' or 'Player2'");
string CurrentPlayer = Console.ReadLine();
char CurrentLetter;
//Sets current letter based on player
if (CurrentPlayer == "Player1") CurrentLetter = 'X';
else CurrentLetter = 'O';

//Builds 3x3 array
char[,] board4 = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

//Sample set up menu at start of game
Console.WriteLine("***********************************");
Console.WriteLine($"{CurrentPlayer}'s Turn");
Console.WriteLine("***********************************");
Console.WriteLine("Sample Array test board");
Console.WriteLine("***********************************");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board4[0, 0]} | {board4[0, 1]} | {board4[0, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board4[1, 0]} | {board4[1, 1]} | {board4[1, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board4[2, 0]} | {board4[2, 1]} | {board4[2, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine("***********************************");

//Sample user input
Console.WriteLine("Select one of the numbers:");
char UserSelection = Convert.ToChar(Console.Read());
Console.Clear();

//Test switch to update board
switch (UserSelection)
{
    case '1': 
        board4[0, 0] = CurrentLetter;
        break;
    case '2':
        board4[0, 1] = CurrentLetter;
        break;
    case '3':
        board4[0, 2] = CurrentLetter;
        break;
    case '4':
        board4[1, 0] = CurrentLetter;
        break;
    case '5':
        board4[1, 1] = CurrentLetter;
        break;
    case '6':
        board4[1, 2] = CurrentLetter;
        break;
    case '7':
        board4[2, 0] = CurrentLetter;
        break;
    case '8':
        board4[2, 1] = CurrentLetter;
        break;
    case '9':
        board4[2, 2] = CurrentLetter;
        break;
    default:
        Console.WriteLine("Not a valid selection");
        break;
        
}
//Test board after update. Updates to 0,2 or number 3 will trigger test win
Console.WriteLine("***********************************");
Console.WriteLine($"{CurrentPlayer}'s Turn");
Console.WriteLine("***********************************");
Console.WriteLine("Sample Array test board");
Console.WriteLine("***********************************");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board4[0, 0]} | {board4[0, 1]} | {board4[0, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board4[1, 0]} | {board4[1, 1]} | {board4[1, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board4[2, 0]} | {board4[2, 1]} | {board4[2, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine("***********************************");

//The test win can be updated with currentletter each round and checked for a winner before moving to the next player. 
// This should return a bool true or false once set up in a Method, True if won, False if lost.  check each line. 
//Add across x 3
if (board4[0, 0] == '1' && board4[0, 1] == '2' && board4[0, 2] == CurrentLetter) Console.WriteLine("Test: WINNER!");
// Add up x 3
// Add diagonal x 2

Console.ReadKey();

public class MainGame
{
//Set up
// Creates New Board Object
// Ceates New Board Draw Object
// Creates Player1
//Creates Player2

//Loop of nine turns 
// Draw board
// Next player, to pick spot
// Checks for win via win Method
// swap player after end of turn (not sure how to do this) could use if player 1 add one to current player, if player 2 subtract one to current player

//After 9 breaks loop gives win to cat. 


}

public class Board
{
 //builds 3X3 array
 // keeps track of empty array elements
 // injects user provided info to new cells
 // tracks cell status 
}

public class DrawBoard
{
//Draws current board


}

public class Player
{
    //Get players Name?
    // Get X or O
    // Pick square
}



