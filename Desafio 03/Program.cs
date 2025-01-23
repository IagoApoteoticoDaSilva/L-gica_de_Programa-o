/*
 *inclua nesse programa uma solicitação de nome completo do usuario.
    A cada impressão no console deve ser exibido nome completo do usuario, a mensagem sobre se é maior, menor ou possui autorização e tambem a idade digitada pelo usuario.

 *Se usuario tiver até 10 anos aparecer uma mensagem "Você é uma criança", entre 10 e 14, "Você é pré adolescente, entre 15 e 17 "Você é adolescente", entre 18 e 60 "Você é um adulto", maiores que 60 "Você está na melhor idade". Você não pode apagar o código a baixo
 */


Console.WriteLine("Qual sue nome completo?");
string nome = Console.ReadLine();


Console.WriteLine("Qual o sua idade?");
int idade = int.Parse(Console.ReadLine());



if (idade >= 18)
{
    Console.WriteLine($"Prazer {nome} Você tem {idade} anos, portanto é maior de idade");
}
else if (idade >= 16)
{
    Console.WriteLine($"Prazer {nome} Você tem {idade} anos, portanto você precisa de autorização");
}
else if (idade >= 10 && idade <= 14)
{
    Console.WriteLine($"Prazer {nome} Você tem {idade} anos, portanto você é uma criança");
}
else if (idade >= 15 && idade <= 17)
{
    Console.WriteLine($"Prazer {nome} Você tem {idade} anos, portanto você é um adolescente");
}
else if (idade >= 18 && idade <= 60)
{
    Console.WriteLine($"Prazer {nome} Você tem {idade} anos, portanto você precisa de autorização");
}
else
{
    Console.WriteLine($"Prazer {nome} Você tem {idade} anos, portanto é menor de idade");
}