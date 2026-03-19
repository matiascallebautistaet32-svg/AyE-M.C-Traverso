using static System.Runtime.InteropServices.JavaScript.JSType;

int a1 = 25;  
int a2 = 14;
int a3 = 0;
int a4=10;
int a5=8;
int a6=15;
int a7=100;
int a8=7;
int a9=0;
int a10=-5;

int b1=30;
int b2=14;
int b3=0;
int b4=10;
int b5=3;
int b6=15;
int b7=50;
int b8=7;
int b9=0;
int b10=-2;

int c1a= 5;
int c1b=3;
int c1c=10;
int c1d=20;

int c2a=8;
int c2b=10;
int c2c=5;
int c2d=2;

int c3a=10;
int c3b=10;

int c4a = 15;
int c4b=10;
int c4c=5;
int c4d=10;

int c5a=10;
int c5b=2;
int c5c=10;
int c5d=5;
int c5e=2;
int c5f=8;

bool humedad = false;
int temperatura = 35;


int edad = 16;
int c7b=18;

int c8a=10;
int c8b=3;
int c8c=3;
int c8d=10;
int c8e=3;
int c8f=1;

string nombref= "Ana";
string nombre = "Juan";

int c10a=5;
int c10b=2;
int c10c=10;
int c10d=15;
int c10e=20;
int c10f=4; 
int c10g=5;

if (a1 > b1)
{
  Console.WriteLine("Es verdadero");
}
else
{
   Console.WriteLine("Es falso");
}


if (a2 <= b2)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}


if (a3 == b3)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}


if (a4 != b4)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}


if (a5 >= b5)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}


if (a6 < b6)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}


if (a7 != b7)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}


if (a8 == b8)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}


if (a9 > b9)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}


if (a10 < b10)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}



if (c1a > c1b && c1c < c1d)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}

if (c2a == c2b || c2c != c2d)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");

}
if (!(c3a==c3b))
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");

}
if (c4a>c4b && !(c4c>c4d))
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");

}
if (c5a + c5b > c5c || c5d * c5e < c5f)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");

}
if (temperatura> 30 && humedad==true)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");

}
if (!(edad>=18))
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");

}
if (c8a/c8b==c8c && c8d%c8e==c8f)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");

}
if (nombre=="Juan" || nombref=="Ana")
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");

}
if ((c10a*c10b) + c10c > c10d && c10e/c10f==c10g)
{
    Console.WriteLine("Es verdadero");
}
else
{
    Console.WriteLine("Es falso");
}
