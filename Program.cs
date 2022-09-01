// Task 47

Console.WriteLine("Task 47: Specify a two-dimensional array of size m x n filled with random real numbers.");



Console.Write("Enter number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array_47 = new double[m, n];

CreateArrayDouble(array_47);

WriteArray(array_47);

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}

// Task 50
Console.WriteLine();
Console.WriteLine("Task 50: Write a program that takes as input the positions of an element in a two-dimensional array, and returns the value of this element or indicates that there is no such element.");
Console.WriteLine("Generating an Array.");
int m1 = 5;
int n1 = 5;
double[,] array_50 = new double[m1, n1];
CreateArrayDouble_50(array_50);
WriteArray_50 (array_50);

int[] ParserString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}

Console.Write("Please, enter the coordinates of the number, divided by a comma: ");
;

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= m1 
&& position[1] <= n1 
&& position[0] >= 0 
&& position[1] >= 0) 
{
  double result = array_50[position[0]-1, position[1]-1];
  Console.Write($"Element value is: {result}");
}
else Console.Write($"No position found");

void CreateArrayDouble_50(double[,] array_50)
{
  for (int i = 0; i < m1; i++)
  {
    for (int j = 0; j < n1; j++)
    {
      array_50[i, j] = new Random().NextDouble() * 10;
    }
  }
}

void WriteArray_50 (double[,] array_50){
for (int i = 0; i < m1; i++)
  {
      for (int j = 0; j < n1; j++)
      {
        double alignNumber = Math.Round(array_50[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}
// Task 52

Console.WriteLine();
Console.WriteLine("Task 50. Specify a two-dimensional array of integers. Find the arithmetic mean of the elements in each column.");
Console.WriteLine("Generating a 4 x 4 array");

int [,] array_52 = new int[4, 4];

  for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 4; j++)
    {
        var RND_52 = new Random ();
      array_52[i, j] = RND_52.Next(0,11);
    }
  };
  for (int i = 0; i < 4; i++)
  {
      for (int j = 0; j < 4; j++)
      {
        Console.Write(array_52[i, j] + " ");
      }
      Console.WriteLine();
  };
Console.WriteLine("Arithmetic mean");
for (int i = 0; i < 4; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < 4; j++)
  {
    arithmeticMean += array_52[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / 4, 1);
  Console.WriteLine($"of the column # {i+1} {arithmeticMean}");
};