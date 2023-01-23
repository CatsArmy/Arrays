static bool debug()
{
    return false;
}
Console.WriteLine("please enter how many student to evaluate: ");
int count = int.Parse(Console.ReadLine());
int[] Grades = new int[count];
for (int i = 0; i < Grades.Length; i++)
{
    Console.WriteLine($"Enter Grade for student {i+1}");
    Grades[i] = int.Parse(Console.ReadLine());
}
if (debug())
{
    Console.WriteLine("Before maxIDX");
}
int max_idx = FindMaxIndex(Grades, 0);
if (debug())
{
    Console.WriteLine("After MaxIDK");
    Console.WriteLine($"max_idk {max_idx}");
}
Console.WriteLine($"{Grades[max_idx]} is the highest grade at index: {max_idx}");
static int FindMaxIndex(int[] g, int minVal) 
{
    //minVal is the lowest value if there is a value that is bigger then it it becomes the new minVal Untill we reach the highst value we can 
    int minVal_idx = 0;
    for (int i = 0; i < g.Length; i++)
    {
        if (g[i] > minVal)
        {
            minVal = g[i];
            minVal_idx = i;
            if (debug())
            {
                Console.WriteLine($"minVal {minVal}");
                Console.WriteLine($"minVal_idx {minVal}");
                Console.WriteLine($"i {i}");
                Console.WriteLine($"g[i] {g[i]}");
            }
        }
    }
    if (debug())
    {
        Console.WriteLine("RETURNING");
    } 
    return minVal_idx;
}
