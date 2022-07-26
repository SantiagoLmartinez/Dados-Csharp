//Hacer un programa que imprima los numeros de un dado por consola (1 al 6) de manera aleatorea

Random dado = new Random();
int tirarDado = dado.Next(1, 7);
Console.WriteLine(tirarDado);