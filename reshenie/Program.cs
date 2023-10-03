/*Написать программу, которая из имеющегося массива строк
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

string[] array = {"one", "two", "three", "four", "five"};

string [] GetArray(string[] array)
{
  int n = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i].Length <=3)
    n++;
  };

    string [] rezArr = new string [n];
    int j = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if(array[i].Length <=3)
        {
            rezArr[j] = array[i];
            j++;
        }
    }
   return rezArr;
};

string[] resultArray = GetArray(array);
