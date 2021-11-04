int inputArraySize = 9;
int[] inputArray = new int[inputArraySize];

Console.WriteLine("Input array");
int index = 0;
while (index < inputArraySize)
{
    inputArray[index] = new Random().Next(10, 100); // [10, 99]
    Console.Write(inputArray[index] + " "); 
    index++;
}
Console.WriteLine();

int sum = 0; 
index = 0;
while (index < inputArraySize)
{
    sum = sum + inputArray[index];
    index++;
}
double average = sum / (double) inputArraySize;
Console.WriteLine($"Average sum is {average}");

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
            inputArray[index] <= average &&
            inputArray[index] % 2 > 0)
    {
        outputArray[outputArraySize] = inputArray[index];
        outputArraySize++;
    }
    index++;
}

Console.WriteLine("Output array");
index = 0;
while (index < outputArraySize)
{
    Console.Write(outputArray[index] + " ");
    index++;
}
Console.WriteLine();
