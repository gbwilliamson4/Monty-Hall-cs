System.Random random = new System.Random();

int swapWins = 0;
int swapLosses = 0;
int stayWins = 0;
int stayLosses = 0;
int totalPlays = 1000000;
int showGoatDoor = 0;
int totalSwaps = 0;
int totalStays = 0;
double swapSuccess = 0.00;
double staySuccess = 0.00;
bool validPick = false;
string swap;

//while (i <= 50)
//{
//    int rand = random.Next(1, 4);
//    Console.WriteLine(rand);
//    i = i + 1;
    
//}

for(int i = 1; i < totalPlays; i++)
{
    // Determine which door has a car
    int doorThatHasCar = random.Next(1, 4);

    // "player" picks a door
    int doorPick = random.Next(1, 4);

    while(validPick == false)
    {
        // Select a door that is not the players door and not the goat door
        showGoatDoor = random.Next(1, 4);
        if (showGoatDoor != doorPick && showGoatDoor != doorThatHasCar)
        {
            break;
        }
    }

    // swapping doors.
    if (i <= totalPlays / 2)
    {
        swap = "Y";
    }
    else
    {
        swap = "N";
    }

    if (swap == "Y")
    {
        if(doorPick == 1 && showGoatDoor == 2)
        {
            doorPick = 3;
        }
        else if(doorPick == 1 && showGoatDoor == 3)
        {
            doorPick = 2;
        }
        else if(doorPick == 2 && showGoatDoor == 1)
        {
            doorPick = 3;
        }
        else if(doorPick == 2 && showGoatDoor == 3)
        {
            doorPick = 1;
        }
        else if(doorPick == 3 && showGoatDoor == 1)
        {
            doorPick = 2;
        }
        else if(doorPick == 3 && showGoatDoor == 2)
        {
            doorPick = 1;
        }
    }
    else
    {

    }

    if(doorPick == doorThatHasCar)
    {
        //Console.WriteLine("You win!");
        if(swap == "Y")
        {
            swapWins = swapWins + 1;
        }
        else if(swap == "N")
        {
            stayWins = stayWins + 1;
        }
    }
    else
    {
        //Console.WriteLine("Sorry you lost");
        if (swap == "Y")
        {
            swapLosses = swapLosses + 1;
        }
        else if (swap == "N")
        {
            stayLosses = stayLosses + 1;
        }
    }

    totalSwaps = swapWins + swapLosses;
    if (totalSwaps != 0)
    {
        swapSuccess = (double)swapWins / totalSwaps * 100;
    }
    else
    {
        swapSuccess = 0.0;
    }

    totalStays = stayWins + stayLosses;
    if (totalStays != 0)
    {
        staySuccess = (double)stayWins / totalStays * 100;
    }
    else
    {
        staySuccess = 0.0;
    }


    Console.WriteLine(i);

}



Console.WriteLine("Swapping: ");
Console.Write(swapWins + " wins, " + swapLosses + " losses. Success rate: " + swapSuccess + "%");

Console.WriteLine("");

Console.WriteLine("Staying: ");
Console.Write(stayWins + " wins, " + stayLosses + " losses. Success rate: " + staySuccess + "%");

Console.WriteLine("");