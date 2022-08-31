int count = 0;
double distance = 10000;
int speed1 = 1;
int speed2 = 2;
int speeddog = 5;
double T = 0;
bool friend = 1;

while (distance < 10000)
{
    if (friend = 0)
    {
        T = distance / (speed1 + speeddog);
        friend = 1;
    }
    else
    {
        T = distance / (speed2 + speeddog);
        friend = 0;
    }
    distance = distance - (speed1 + speed2) * T;
    count = count + 1;
}
Console.Write("count = ");
Console.WriteLine(count);