//switch ... case example
/*
 * 1: set fan's speed to 1
 * 2: set fan's speed to 2
 * 3: set fan's speed to 3
 * 0 : fan stops
 * other number: invalid speed
 */

Console.Write("Enter fan's speed (0-3): ");
int speed = Convert.ToInt32(Console.ReadLine());
switch (speed)
{
    case 0:   //if
        Console.WriteLine("Fan's speed is 0");
        break;
    case 1:   //else if
        Console.WriteLine("Fan's speed is 1");
        break;
    case 2:    //else if
        Console.WriteLine("Fan's speed is 2");
        break;
    case 3:   //else if
        Console.WriteLine("Fan's speed is 3");
        break;
    default:   //else 
        Console.WriteLine("Invalid speed");
        break;
}