long Input()
{
long i = 0;
bool flag = false;
while (!(flag && i > 9999 && i < 1000000))
{
Console.WriteLine("Введите пятизначное число");
string data = Console.ReadLine();
flag = long.TryParse(data, out i);
i = Math.Abs(i);
}
return i;
}

bool Calculation(long per)
{
long new_per = 0;
long old_per = per;
while (old_per > 0)
{
new_per = new_per * 10 + (old_per % 10);
old_per /= 10;
}
return (new_per == per);
}

void Output(bool a)
{
if (a)
{
Console.WriteLine("Число является полиндромом");
}
else
{
Console.WriteLine("Число не является полиндромом");
}
}

Output(Calculation(Input()));
