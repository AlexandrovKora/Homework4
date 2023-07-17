/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.
*/
/*
int Power(int num, int power)
{   
    int count=1;
    int result=1;
    while(count<=power)
    {
        result=result*num;
        count++;
    }
    return result;
   
}

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a power: ");
int pow = Convert.ToInt32(Console.ReadLine());
int res = Power(number, pow);
Console.WriteLine(res);
*/

/*
Задача 27: Напишите программу, 
которая принимает на вход число и выдаёт сумму цифр в числе.
*/
/*
int Sum(int number)
{
    int result=0;
    while (number > 0)
    {
        result =result+number%10;
        number = number/10;
    }
    return result;

}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = Sum(num);
Console.WriteLine(res);
*/
/*
Задача 29: Напишите программу, которая задаёт массив из m 
элементов и выводит их на экран. Разработать метод 
CreateArray(int size), генерирующий массив на основе данных, 
вводимых пользователем.
*/


