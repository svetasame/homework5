
//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
#region
static int Prompt(string message)
{
System.Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int [] GenerateArray (int Length)
{
  int [] array = new int [Length];
  Random ran = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = ran.Next(100, 1000);
  }
  return array;
}

void PrintArray (int[] array)
{
  string sa = string.Join(", ", array);
  System.Console.WriteLine($"[{sa}]");
}

void FindEven (int[] array)
{
int res = 0;
for (int i = 0; i < array.Length; i++)
  {
    if (array [i] % 2 == 0)
    res++;
  }
  System.Console.WriteLine($"Количество четных чисел = {res}");
}

void Task34()
{
int length = Prompt("Длина массива: ");
int [] arrayran = GenerateArray(length);
PrintArray (arrayran);
FindEven (arrayran);
}

//Task34();
#endregion

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
#region
int [] GenerateArrayRan (int Length)
{
  int [] array = new int [Length];
  Random ran = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = ran.Next(1, 100);
  }
  return array;
}

void FindSumOdd(int[] array)
{
int res = 0;
for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 > 0)  
    res = res + array[i];
    else
    res = res + 0;
  }
  System.Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {res}");
}

void Task36() //если мы считаем нечетными позициями нечетные индексы
{
int length = Prompt("Длина массива: ");
int [] arrayran = GenerateArrayRan(length);
PrintArray (arrayran);
FindSumOdd (arrayran);
}

//Task36();
#endregion

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
#region
double [] GenerateArrayRanFloat (int Length)
{
  double [] array = new double [Length];
  Random ran = new Random();

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Math.Round(ran.NextDouble() * 100,2);

  }
  return array;
}

void PrintArrayFloat (double[] array)
{
  string sa = string.Join(" ", array);
  System.Console.WriteLine($"[{sa}]");
}

void DiffMaxMin (double[] array)
{
int i = 0;
double max = array[i];
double min = array[i];
while (i < array.Length)
{
if (array[i] > max)
max = array[i];
i++;
if (array[i] < min)
min = max = array[i];
i++;
}
double diff = Math.Round((max-min),2);
System.Console.WriteLine($"Разница между {max} и {min} = {diff}");
}

void Task38()
{
int length = Prompt("Длина массива: ");
double [] arrayran = GenerateArrayRanFloat(length);
PrintArrayFloat (arrayran);
DiffMaxMin (arrayran);
}

//Task38();
#endregion

void TaskNumber()
{
  int number = Prompt("Введите номер задачи: ");
  if (number == 34) Task34();
  else if (number == 36) Task36();
  else if (number == 38) Task38();
  else System.Console.WriteLine("Ошибка, введите номер заново");
}

TaskNumber();