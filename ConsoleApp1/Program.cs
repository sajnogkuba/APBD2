// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int age = 21;
string name = "Kuba";
int x = 12;

int[] arr = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine(getAvg(arr));
Console.WriteLine(maxValue(arr));

static double getAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}

static int maxValue(int[] arr)
{
    int max = arr[0];
    foreach (var j in arr)
    {
        if (j > max)
        {
            max = j;
        }
    }
    return max;
    int y = 0;
}