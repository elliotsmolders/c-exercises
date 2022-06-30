/* Robot Simulator
Volgende opgave komt uit Exercism.io

” Write a robot simulator.

A robot factories’ test facility needs a program to verify robot movements. The robots have three possible movements:

turn right
turn left
advance Robots are placed on a hypothetical infinite grid, facing a particular direction (north, east, south, or west) at a set of {x, y} coordinates, e.g., {3, 8}, with coordinates increasing to the north and east.
The robot then receives a number of instructions, at which point the testing facility verifies the robot’s new position, and in which direction it is pointing.

The letter-string “RAALAL” means:

Turn right
Advance twice
Turn left
Advance once
Turn left yet again
Say a robot starts at {7, 3} facing north. Then running this stream of instructions should leave it at {9, 4} facing west.”

Teken het gevolgde pad in de console (gebruik Console.SetCursorPosition()). */
Helpers helper = new Helpers();

int[] currentPosition = {0,0};
Directions currentDirection = Directions.North;

char[] userInput = helper.GetUserInput();
for(int i = 0; i<userInput.Length;i++){
    helper.ExecuteInput(instruction:helper.ConvertInput(userInput[i]),currentDirection:currentDirection,currentPosition:currentPosition);
}
System.Console.WriteLine($"{String.Join(',',currentPosition)}");

/* System.Console.WriteLine(helper.ConvertInput('A'));
helper.ConvertInput('A'); */
