int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpead = 5;
int friend = 1;

while(distance > 10)
{
    if(friend == 1)
    {
        int time = distance / (secondFriendSpeed + dogSpead);
        friend = 2;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
    if(friend == 2)
    {
        int time = distance / (firstFriendSpeed + dogSpead);
        friend = 1;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }

}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");
