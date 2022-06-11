/*
  Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
  452 -> 11
  82 -> 10
  9012 -> 12
*/

Console.WriteLine ("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber (numberN);
Console.WriteLine (sumNumber);

int SumNumber (int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int stepNumber = 0;
    int result = 0;

    for (int i = 0; i < counter; i ++)
    {
        stepNumber = numberN - numberN % 10;
        result = result + (numberN - stepNumber);
        numberN = numberN / 10;
    }
    return result;
}
