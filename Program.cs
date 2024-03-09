// 1) 
// Linguagem C#

int indice = 13;
int k = 0;
int soma = 0;

while (k < indice)
{
    k = k + 1;
    soma = soma + k;
}

Console.WriteLine($"A soma é: {soma}");






/*
2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores 
anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, 
informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado
 pertence ou não a sequência. 

Linguagem C#
*/

int numeroAnterior = 0;
int numeroAtual = 1;
int fibo;
bool numEhFib = false;

Console.WriteLine("Digite o numero para saber se pertence ou não a sequência de Fibonacci:");
var inputNumber = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i <= inputNumber; i++)
{
    fibo = numeroAnterior + numeroAtual;
    numeroAnterior = numeroAtual;
    numeroAtual = fibo;
    if (fibo == inputNumber)
    {
        numEhFib = true;
        break;
    }
}

if (numEhFib)
{
    Console.WriteLine($"O numero {inputNumber} esta presente na sequencia Fibonacci");
}
else
{
    Console.WriteLine($"O numero {inputNumber} NÃO esta presente na sequencia Fibonacci");
}





/* 3) Descubra a lógica e complete o próximo elemento:  

a) 1, 3, 5, 7, ___  
R = 9  (an + 2)

b) 2, 4, 8, 16, 32, 64, ____  
R = 128  (an * 2)

c) 0, 1, 4, 9, 16, 25, 36, ____  
R = 49  (a3 = a1 + (p1+2))

d) 4, 16, 36, 64, ____ 
R = 128   (4 * 2^n) n = posicao do numero

e) 1, 1, 2, 3, 5, 8, ____ 
R = 13   Sequência de Fibonacci 

f) 2, 10, 12, 16, 17, 18, 19, ____ 
R = 22  (20 + 2)
*/



/* 4) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente. 
Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes 
quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.

Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor
 controla cada lâmpada?  */

/* R = Ligaria dois dos interruptores e deixaria um apagado
entraria uma vez nas 3 salas das lâmpadas, descobrindo assim
qual lâmpada o interruptor desligado pertence.
Desligaria outro interruptor e entraria em uma sala apenas para ver se a lâmpada esta ligada ou desligada, 
sabendo assim qual interrupitor cada uma pertence.
Precisando apenas entrar mais uma vez em uma das salas, ao total visitando apenas uma sala duas vezes. */




// 5) Escreva um programa que inverta os caracteres de um string. 

Console.WriteLine("Digite a palavra a ser invertida: ");
string palavra = Console.ReadLine();

string palavraReversa = "";

for (int i = palavra.Length - 1; i >= 0; i--)
{
    palavraReversa = palavraReversa + palavra[i];
}

// Resultado
Console.WriteLine($"Palavra invertida : {palavraReversa} e palavra original: {palavra}");

