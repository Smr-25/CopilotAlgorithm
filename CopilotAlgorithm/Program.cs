// See https://aka.ms/new-console-template for more information

#region Task1

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int temp = a ^ 2 + b ^ 2;
int temp2 = c ^ 2;
if (temp == temp2)
    Console.WriteLine("Duzbucaqli ucbucaq");
else if (temp > temp2)
    Console.WriteLine("Korbucaqli ucbucaq");
else
    Console.WriteLine("Itibucaqli ucbucaq");


#endregion

#region Task2

string str = "salam";
if (str.Length % 2 != 0)
    Console.WriteLine(str[(str.Length - 1) / 2]);
else
{
    Console.Write(str[(str.Length / 2) - 1]);
    Console.WriteLine(str[str.Length / 2]);

}

#endregion

#region Task3

int num = 156287945;
int sum = 0;

while (num > 0)
{
    int digit = num % 10;
    if(digit==2 || digit == 3 || digit == 5 || digit == 7)
        sum += digit;
    num /= 10;
}

Console.WriteLine(sum);

#endregion