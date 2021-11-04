int minValue = -10;
int maxValue = 8;
int inputArraySize = 10;
int[] inputArray = new int[inputArraySize];

Console.WriteLine("Input array");
int index = 0;
while (index < inputArraySize)
{
    inputArray[index] = new Random().Next(minValue, maxValue + 1);
    Console.Write(inputArray[index] + " "); 
    index++;
}
Console.WriteLine();

int[] outputArray = new int[inputArraySize];
index = 0;
int outputArraySize = 0;
while (index < inputArraySize)
{
    if (index == 0)
    {
        outputArray[outputArraySize] = inputArray[index];
        outputArraySize++;
    }
    else if (inputArray[index] >= outputArray[outputArraySize - 1] &&
            inputArray[index] <= 8 &&
            Math.Sign(inputArray[index]) != Math.Sign(outputArray[outputArraySize - 1]) && Math.Sign(inputArray[index]) != 0)
    {
        outputArray[outputArraySize] = inputArray[index];
        outputArraySize++;
    }
    index++;
}

Console.WriteLine("Output array");
index = 0;
while (index < outputArraySize) // Всегда от 1 до 2 элементов
{
    Console.Write(outputArray[index] + " ");
    index++;
}
Console.WriteLine();
