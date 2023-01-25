Console.Write ("Введите имя пользователя ");
string name = Console.ReadLine();
if(name.ToLower() == "маша")
{
    Console.WriteLine("УРА! Это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.Write(name);
}