//Задача №0
//Напишите программу, которая на вход принимает
//число и выдаёт его квадрат (число умноженное на
//само себя).
//Например: 4 -> 16 -3 -> 9 -7 -> 49
Console.WriteLine("Enter your number: ");
// Jdem dannie ot polzovatelya
string? inputNum = Console.ReadLine();//??"0";
// Proveryaem, chto dannie ne pustie
if (inputNum != null)
{
    /*
        // Perevodim vvedennuyu stroku v chislo = parsim
        int num = int.Parse(inputNum);
        // Vozvodim v kvadrat poluchennoe chislo
        int result = num * num;
        // Vivod resultata
        Console.WriteLine(result);
    */
    Console.WriteLine("Kvadrat chisla: " + Math.Pow(int.Parse(inputNum), 2));
}

