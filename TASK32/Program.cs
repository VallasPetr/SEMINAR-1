// Задайте массив из 10 элементов из промежутка [-9, 9] 
// и положительные элементы замените на соответствующие 
// отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] arrayOfRandomNumbers;

int arraySize = 10;
arrayOfRandomNumbers = new int[arraySize];

int starterOfRandom = -9;

int powerOfRandom = 10;



for (int i = 0; i < arraySize; i++)
{
    arrayOfRandomNumbers[i] = new Random ().Next (starterOfRandom, powerOfRandom);
}

for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
{
    Console.Write (i + ": " + arrayOfRandomNumbers[i] + "| ");
}
Console.WriteLine ();

for (int i = 0; i < arraySize; i++)
{
    arrayOfRandomNumbers[i] *= -1;
}

for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
{
    Console.Write (i + ": " + arrayOfRandomNumbers[i] + "| ");
}
Console.WriteLine ();
