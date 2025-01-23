/*
 *Adapte o programa a baico para solicitar a idadedo usuario. Se o usuario for maior de 18 anos exibir a mensagem maior de idade, do contrario exibir a mensagem menor de idade
 */

Console.WriteLine("Qual o sua idade?");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade");
}
else if (idade>=16)
{
    Console.WriteLine("Você pode entrar com autorização");
}
else
{
    Console.WriteLine("Você é menor de idade");
}