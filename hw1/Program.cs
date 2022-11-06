//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int FiveDigitNumber = InputFiveDigitNumber ();
int reverse = ReverseNumber (FiveDigitNumber);
CompareNumbers (reverse, FiveDigitNumber);

int InputFiveDigitNumber()
{

    int FiveDigitNumber = int.Parse(Console.ReadLine()!);

    return FiveDigitNumber;

}

int ReverseNumber(int Number)
{

    int reverse = 0, rem;
    while (Number != 0)
    {
        rem = Number % 10;
        reverse = reverse * 10 + rem;
        Number = Number / 10;
    }

    return reverse;
}

void CompareNumbers(int reverse, int Number)
{

    if (reverse == Number)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}

 
