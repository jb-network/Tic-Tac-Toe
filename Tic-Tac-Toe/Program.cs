// This is challenge work for the "C# Players Guide"
// Level 24 "Tic-Tac-Toe" Challenge
// The task is create a Tic-Tac-Toe game
// It assumes two players on the same key board
// It must display the state of the board on the console

// Creates New MainGame Object

//Test area
// User Selection menu
// User loop to set up numbers
/*
string CurrentPlayer = "Player 1";
Console.WriteLine("***********************************");
Console.WriteLine($"{CurrentPlayer}'s Turn");
Console.WriteLine("Select one of the numbers below:");
Console.WriteLine("***********************************");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| 1 | 2 | 3 |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| 4 | 5 | 6 |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| 7 | 8 | 9 |");
Console.WriteLine("|---+---+---|");
Console.WriteLine("***********************************");
Console.WriteLine("\n");

//Prototype board
char[,] board = new char[3, 3];
board[0, 0] = 'X';
Console.WriteLine("***********************************");
Console.WriteLine("Sample board");
Console.WriteLine("***********************************");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board[0, 0]} | O | X |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| O | X | X |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| X | O | O |");
Console.WriteLine("|---+---+---|");
Console.WriteLine("***********************************");

//array test 1
char[,] board2 = new char[3, 3] { { '1','2','3'}, { '4','5','6' }, { '7','8','9' } };
Console.WriteLine("***********************************");
Console.WriteLine("Sample Array test board");
Console.WriteLine("***********************************");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board2[0, 0]} | {board2[0, 1]} | {board2[0, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board2[1, 0]} | {board2[1, 1]} | {board2[1, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board2[2, 0]} | {board2[2, 1]} | {board2[2, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine("***********************************");


//array test 2
char[,] board3 = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

board3[0, 0] = 'X';
Console.WriteLine("***********************************");
Console.WriteLine("Sample Array test board");
Console.WriteLine("***********************************");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board3[0, 0]} | {board3[0, 1]} | {board3[0, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board3[1, 0]} | {board3[1, 1]} | {board3[1, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine($"| {board3[2, 0]} | {board3[2, 1]} | {board3[2, 2]} |");
Console.WriteLine("|---+---+---|");
Console.WriteLine("***********************************");

*/
//Test user selection
//array test 2
Console.WriteLine("Pick the current player for testing: 'Player1' or 'Player2'");
string CurrentPlayer = Console.ReadLine();

char CurrentLetter;
if (CurrentPlayer == "Player1") CurrentLetter = 'X';
else CurrentLetter = 'O';
char[,] board4 = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

Console.WriteLine("***********************************");
Console.WriteLine($"{CurrentPlayer}'s Turn");
Console.WriteLine("Select one of the numbers below:");
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

//User to get user input and update array.  Need to add 
char UserSelection = Convert.ToChar(Console.Read());

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


Console.WriteLine("***********************************");
Console.WriteLine($"{CurrentPlayer}'s Turn");
Console.WriteLine("Select one of the numbers below:");
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



