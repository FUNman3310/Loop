int num = 1784;
int count = 1;
for (int i = 0; i < num; i++)
{
    num /= 10;
    if (num > 0)
    {
        count++;
    }
}
Console.WriteLine(count);