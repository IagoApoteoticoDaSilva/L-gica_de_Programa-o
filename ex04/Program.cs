// Tipos de dados

string nome = "Rodolfo";
Console.WriteLine("O nome do usuário é: " + nome);

int idade = 38;
//Console.WriteLine("A idade do usuário é: " + idade + " anos");
Console.WriteLine($"A idade do usário é: {idade} anos");

float carteira = 2.63f;

char classificacao = 'A';
Console.WriteLine($"O cliente é do tipo {classificacao}");

bool dinheiroNaConta = true;
Console.WriteLine(dinheiroNaConta);

double limiteCredito = 2000.0;
Console.WriteLine("Seu limite de crédito é: " + limiteCredito);

string sobrenome = " Silva";

string nomeCompleto = nome + sobrenome;
Console.WriteLine(nomeCompleto);

double valorConta = 53.73;
Console.WriteLine($"O valor na conta é: {valorConta}");

double limiteTotal = valorConta + limiteCredito;
Console.WriteLine($"O saldo + Limite é {limiteTotal}");




