﻿int a1 = 14;
int b1 = 222;
int c1 = 5;
int a2 = 36;
int b2 = 12;
int c2 = 44;
int a3 = 2456;
int b3 = 33;
int c3 = 19;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);