int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int count = 0;
int t = 0;
while (distance>1000)
{
    if (friend==1)
    {
        t = distance/(firstFriendSpeed+dogSpeed);
        friend=2;
        
    }
    else
    {
        t = distance/(secondFriendSpeed+dogSpeed);
        friend=1;
    }
    distance=distance-(firstFriendSpeed+secondFriendSpeed)*t;
    count=count+1;
}
Console.WriteLine(count);