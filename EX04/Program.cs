// Tipos de dados

string nome = "Iago";
Console.WriteLine("O nome do usuario é: " + nome);

int idade = 22;
//Console.WriteLine("A idade do usuario é: " = idade + " anos");
Console.WriteLine($"A idade do usuario é: {idade} anos");

float carteira = 2.63F;

char classificacao = 'A';
Console.WriteLine($"O cliente é do tipo: {classificacao}");

bool dinheiroNaConta = true;
Console.WriteLine($"Tem dinheiro na conta (True/False): {dinheiroNaConta}");

double limiteCredito = 2000.0;
Console.WriteLine($"Seu limite de crédito é: {limiteCredito}");

string sobrenome = " Santos";

string nomeCompleto = nome + sobrenome;
Console.WriteLine($"Nome completo: {nomeCompleto}");

double valorConta = 53.73;
Console.WriteLine($"O valor da conta é: { valorConta}");

double limiteTotal  = valorConta+limiteCredito;
Console.WriteLine($"O limite total é: {limiteTotal}");

