﻿int a = 1;
int b = 5;
int c = 3;
int d = 6;
int e = 10;

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
if (d > max ) max = d;
if (e > max)  max = e;

Console.Write ("Здесь большое число, max = ");
Console.WriteLine(max);
