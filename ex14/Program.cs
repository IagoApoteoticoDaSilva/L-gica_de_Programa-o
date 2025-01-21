/*
Ex14. Soma de Números
   Escreva um programa que permita ao usuário inserir números inteiros. O programa deve continuar solicitando números até que o usuário digite 0. Ao final, quando 0 for digitado, o programa deve calcular e exibir a soma de todos os números inseridos (exceto o 0). Utilize um laço while para realizar essa tarefa.
*/



/*Console.WriteLine("Digite numero");
int i = int.Parse(Console.ReadLine());

while (i =! 0)
{
    Console.WriteLine("Digite numero");
    int.Parse(Console.ReadLine());

}
*/

int numero;
int soma = 0;

Console.WriteLine("Digite numeros inteiros paa somar. Digite 0 para sair.");

numero = int.Parse(Console.ReadLine());

while (numero != 0)
{
    soma += numero;
    numero = int.Parse(Console.ReadLine());
}
Console.WriteLine("Soma total: " + soma);