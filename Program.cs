Console.Write("Введите число ");
int chislo = Convert.ToInt32(Console.ReadLine());

if (chislo < 1)
{
 Console.Write("Введите другое число от 1 до 7");
}
else if (chislo > 7)
{
 Console.Write("Введите другое число от 1 до 7");
}
 else if (chislo > 5 && chislo < 8)
 {
   Console.Write("да, это выходной"); 
}
 else
{
    Console.Write("нет, это рабочий день");
}