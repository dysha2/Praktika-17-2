// See https://aka.ms/new-console-template for more information
bool IsNumber(string s)
{
    foreach(char ch in s)
    {
        if (char.IsDigit(ch)) return true;
    }
    return false;
}
string ChangeRegistr(string s)
{
    char[] c = s.ToCharArray();
    for (int i=0;i<c.Length;i++)
    {
        if (char.IsUpper(c[i])) c[i] = char.ToLower(c[i]);
        else c[i] = char.ToUpper(c[i]);
    }
    s = new string(c);
    return s;
}
int n;
while(true)
{
    try
    {
        Console.WriteLine("Введите кол-во строк в массиве");
        n = int.Parse(Console.ReadLine());
        break;
    }
    catch { Console.WriteLine("Введите целое положительное число"); }
}
int count = 0;
string[] lines = new string[n];
Console.WriteLine($"Введите {n} строк");
int index = n;
for (int i=0;i<n;i++)
{
    lines[i] = Console.ReadLine();
    if (lines[i].Contains('/')) index = i;
}
Console.WriteLine($"Преобразованные строки");
count = lines.Where(x => IsNumber(x)).Count();
lines.Take(index+1).ToList().ForEach(x => Console.WriteLine(x));
lines.Skip(index+1).ToList().ForEach(x => Console.WriteLine(ChangeRegistr(x)));
Console.WriteLine($"Строк имеющих числа {count} штук");

