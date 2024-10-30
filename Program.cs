Console.WriteLine("Calculate days of years \n Input: ");

int year = Convert.ToInt32(Console.ReadLine());
int dif = 2023 - year;
int days_dif = dif*365;
Console.WriteLine($"Output: {days_dif}");