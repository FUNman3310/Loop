int number = 16;
int count = 0;
for (int i = 1; i <= number; i++)
{
    if(number%i== 0)
    {
        count++;   
    }
}
if (number == 1)
{
    Console.WriteLine("neither simple nor complex");
}
else if(number > 2)
{
    Console.WriteLine("Number is complex");

}
else
{
    Console.WriteLine("Number is simple");
}
