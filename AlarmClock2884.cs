using System;
//AlarmClock2884
class AlarmClock
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] inputSplit = input.Split(' ');
        int[] intSplit;
        intSplit = Array.ConvertAll<string, int>(inputSplit, Convert.ToInt32);
        if (intSplit[0] != 0)
        {
            if (intSplit[1] >= 45)
            {
                intSplit[1] -= 45;
            }
            else
            {
                intSplit[1] -= 45;
                intSplit[1] += 60;
                intSplit[0] -= 1;
            }
        }
        else if(intSplit[0] == 0)
        {
            if (intSplit[1] >= 45) //분 45이상??
            {
                intSplit[1] -= 45;
            }
            else //분 45이하랑 시간
            {
                intSplit[1] -= 45;
                intSplit[1] += 60;
                intSplit[0] = 23;
            }
        }

        Console.WriteLine($"{intSplit[0]} {intSplit[1]}");

    }
}
