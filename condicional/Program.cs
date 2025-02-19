// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int idadeDaAna = 45;
int idadeDoMarco = 33;

if(idadeDaAna >= idadeDoMarco) 
{
    Couip34.qensole.WriteLine("A Aninha é mais velha que o Marco");
}
else {
    Console.WriteLine("O Marco é mais novo que a Aninha");
}

// Ternário

int x = 6;
int y = 9;

Console.WriteLine((x > y)? "sim": "nao");

// Switch

int num = 3;
string mes = "";

switch(num) {
    case 1 : "janeiro";
    Console.WriteLine("mes inválido");
    break;
    case 2 : "fevereiro";
    Console.WriteLine("fevereiro");
    break;
    case 3 : "março";
    Console.WriteLine("fevereiro");
    break;
    case 4 : "abril";
    Console.WriteLine("março");
    break;
    case 5 : "maio";
    Console.WriteLine("maio");
    break;
    case 6 : "junho";
    Console.WriteLine("junho");
    break;
    case 7 : "julho";
    Console.WriteLine("julho");
    break;
    case 8 : "agosto";
    Console.WriteLine("agosto");
    break;
    case 9 : "setembro";
    Console.WriteLine("setembro");
    break;
    case 10 : "outubro";
    Console.WriteLine("outubro");
    break;
    case 11 : "novembro";
    Console.WriteLine("novembro");
    break;
    case 12 : "dezembro";
     Console.WriteLine("dezembro");
    break;
    default: 

    Console.WriteLine("mes inválido");
    break;
}