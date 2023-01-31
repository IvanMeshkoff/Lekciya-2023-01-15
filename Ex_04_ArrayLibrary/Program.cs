// Рандомное заполнение массива, печать массива и 
// сравнение элементов массива с искомым

void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while (index < length)
  {
    collection[index] = new Random().Next(1, 10);
    index++;
  }
}

void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    Console.WriteLine(col[position]);
    position++;
  }
}

int IndexOf(int[] sobranie, int find)
{
  int colvo = sobranie.Length;
  int number = 0;
  int position = -1; 
  while (number < colvo)
  {
    if(sobranie[number] == find)
    {
       position = number;
       break;
    }
    number++;
  }
  return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);