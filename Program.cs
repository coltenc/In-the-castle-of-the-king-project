 //randomizes the outcome of each door and the amount of doors.
 Random random = new Random();
int door = random.Next(5, 10);
int king = random.Next(1, door);
int treasure = random.Next(1, door);
int streasure = random.Next(1, door);
int ttreasure = random.Next(1, door);
 //makes sure that the treasure isnt the same as the king door.
while (king == treasure)
{
    treasure = random.Next(1, door);
}
while (king == streasure)
{
    streasure = random.Next(1, door);
}
while (king == ttreasure)
{
    ttreasure = random.Next(1, door);
}
//picking the door the person wants.
Console.WriteLine($"There are {door} amount of doors");
Console.WriteLine($"one door will lead to the king, some may lead to treasure");
Console.WriteLine("but the rest will lead to your demise");
Console.WriteLine("which door will you choose (has to be a number)");
string x = Console.ReadLine() + "";
switch (x)
{
    case "1":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
        case "2":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
        case "3":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
        case "4":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
        case "5":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
        case "6":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
        case "7":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
        case "8":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
        case "9":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
        case "10":
        if (x == "king")
        {
            Console.WriteLine("Congradulations you found the king!!!!!!!!!!!");
        }
        else
        {
            if (x == "treasure" || x == "streasure" || x == "ttreasure")
            {
                Console.WriteLine("congradulations you found some treasure!!!!!");
            }
            else
            {
                Console.WriteLine("Sorry you have found your demise would you like to play again?");
            }
        }
        break;
    default:
        Console.WriteLine("Sorry please pick a knumber");
        break;
    }
