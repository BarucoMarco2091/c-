// See https://aka.ms/new-console-template for more information

// int qdeMin = Int32.Parse(Console.ReadLine());
//int qdeMax = Int32.Parse(Console.ReadLine());
//int estMedio;

//estMedio = (qdeMin + qdeMax) / 2;

//Console.WriteLine(estMedio);

// 2

//float cotacaoDolar = Int32.Parse(Console.ReadLine());
//float valorDolar = Int32.Parse(Console.ReadLine());
//float valorReal;

//valorReal = cotacaoDolar * valorDolar;

//Console.WriteLine(valorReal);

// 3

//float precoUnitarioPeca = Int32.Parse(Console.ReadLine());
//int quantidadeVendida = Int32.Parse(Console.ReadLine());
//float comissao;

//comissao = precoUnitarioPeca * quantidadeVendida * 5 / 100;

//Console.WriteLine(comissao);

// 4

//float celsius = float.Parse(Console.ReadLine());
//float fahrenheit;

//fahrenheit = (9 * celsius + 160) / 5;
//Console.WriteLine(fahrenheit);

// Condicionais

// 1
//int numero = Int32.Parse(Console.ReadLine());
//int modulo;
//if (numero >= 0)
//{
    //modulo = numero;
    //Console.WriteLine(modulo);
//} else {
    //modulo = numero * (-1);
    //Console.WriteLine(modulo);
//}

// 2

//int numeroMaior = Int32.Parse(Console.ReadLine());
//int numeroMenor = Int32.Parse(Console.ReadLine());
//int diferenca;

//if(numeroMaior > numeroMenor)
//{
    //diferenca = numeroMaior - numeroMenor;
    //Console.WriteLine(diferenca);
//} else {
    //Console.WriteLine("operação inválida");
//}

// 3
//float nota1 = float.Parse(Console.ReadLine());
//float nota2 = float.Parse(Console.ReadLine());
//float nota3 = float.Parse(Console.ReadLine());
//float nota4 = float.Parse(Console.ReadLine());
//float media;

//media = (nota1 + nota2 + nota3 + nota4) / 4;
//if(media >= 7) {
    //Console.WriteLine("Aprovado");
//} else {
    //Console.WriteLine("Reprovado");
//}

// 4 

//int numeroPrimeiro = Int32.Parse(Console.ReadLine());
//int numeroSegundo = Int32.Parse(Console.ReadLine());
//if(numeroPrimeiro > numeroSegundo)
//{
    //Console.WriteLine(numeroPrimeiro);
//} else {
    //Console.WriteLine(numeroSegundo);
//}
//if(numeroPrimeiro == numeroSegundo)
//{
    //Console.WriteLine("os numeros são iguais");
//}

// Estrutura de repetição 

// 1
//int i = 0;
//while(i <= 100)
//{
    //i = i + 1;
    //Console.WriteLine(i);
//}

// 2 
//int j = 100;
//while(j <= 200) {
    //j = j + 1;
    //if(j % 2 == 0) {
        //Console.WriteLine(j);
    //}
//}

// 3
//int j = 100;
//while(j <= 200) {
    //j = j + 1;
    //if(j % 2 != 0) {
        //Console.WriteLine(j);
   //}
//}

// 4
int i = 0;
int numero = Int32.Parse(Console.ReadLine());
int tabuada;
while(i < 11) {
    tabuada = numero * (i);
    i = i + 1;
    Console.WriteLine(tabuada);
}
