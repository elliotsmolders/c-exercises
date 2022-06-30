public class Helpers
{
    public void Advance(int[]currentPosition,Directions currentDirection){
    
}
    public char[] GetUserInput(){
        Console.WriteLine("Give the robot commands:");
        return Console.ReadLine().ToCharArray();
    }

    
    public Instructions ConvertInput(char input){
        Instructions instruction = (Instructions)Enum.Parse(typeof(Instructions),Convert.ToString(input));
        return instruction;
    }
    public void ExecuteInput(Instructions instruction,Directions currentDirection,int[]currentPosition){
        switch(instruction){
            case Instructions.R:{
                MoveRobot(direction:ChangeDirection(currentDirection:currentDirection,changeDirectionBy:1),currentPosition:currentPosition,amount:1);
                break;
            }
            case Instructions.L:{
                MoveRobot(direction:ChangeDirection(currentDirection:currentDirection,changeDirectionBy:-1),currentPosition:currentPosition,amount:1);
                break;
            }
            case Instructions.A:{
                MoveRobot(direction:currentDirection,currentPosition:currentPosition,amount:1);
                break;
            }
        }
    }
    public Directions ChangeDirection(Directions currentDirection, int changeDirectionBy){
            if ((int)currentDirection + changeDirectionBy > 4){
            currentDirection += changeDirectionBy - 4;
            }
            
            else if((int)currentDirection + changeDirectionBy < 1){
             currentDirection += changeDirectionBy + 4;
            }
            else{
            currentDirection += (changeDirectionBy);
            }
        return currentDirection;
    }
    public int[] MoveRobot(Directions direction,int[]currentPosition, int amount = 1){
        switch(direction){
            case Directions.North:{
                currentPosition[0] += amount;
                break;
            }
            case Directions.East:{
                currentPosition[1] += amount;
                break;
            }
            case Directions.South:{
                currentPosition[0] -= amount;
                break;
            }
            case Directions.West:{
                currentPosition[1] -=amount;
                break;
            }
        }
        return currentPosition;
    }


}
