﻿const int origin = 343343;
int num = origin;

int rev = 0;
while (num != 0)
{
    rev = rev * 10 + num % 10;
    num /= 10;
}

Console.WriteLine(origin == rev ? "Is Symmetric" : "Is Asymmetric");