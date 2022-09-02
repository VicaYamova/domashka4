
Console.Write("Введите число : ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{
int numberA = Convert.ToString(numberN).Length;
int numberB = 0;
int result = 0;

for (int i = 0; i < numberA; i++)
{
numberB = numberN - numberN % 10;
result = result + (numberN - numberB);
numberN = numberN / 10;
}
return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);