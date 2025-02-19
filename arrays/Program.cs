// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// arrays
int[] numeros = new int[4];
numeros[0] = 1;

int[] inteiros = new int[4] {1, 2 ,3 ,4};
Console.WriteLine(inteiros[1]);

string[] nomes = {"Claudia", "Cris", "Ana"};
Console.WriteLine(nomes[1]);

int[] valor = {1, 22, 77, 33, 99};
for(var i = 0; i <= valor.Length; i++)
{
    Console.WriteLine(valor[i]);
}