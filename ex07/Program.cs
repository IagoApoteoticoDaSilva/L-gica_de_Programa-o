// Exercício: Crie um programa que solicite ao usuário um número e imprima todos os números a partir do número informado até 10, decrementando de 5 em 5, usando um laço `do-while`.

Console.Write("Digite um número: ");
// Solicitar um número ao usuário
int numero = int.Parse(Console.ReadLine());
int contador = 10;


// Usar do-while para imprimir números de 10 até o número informado (decrementando de 2 em 2)
do
{
    Console.WriteLine(contador);
    contador -= 5; // Decrementa o contador em 2
}

while (contador >= numero);
{

}
