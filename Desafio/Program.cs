/*
 * Escreva um prgrama que solicite o primeiro nome do usuario em seguida solicite o sobrenome do usuario. O Programa deve apresentar uma mensagem de boas vindas e o nome do usuario
 * 
 * 
 */

Console.WriteLine("Qual o seu primeiro nome?");
String nome = Console.ReadLine();

Console.WriteLine("E o seu sobrenome?");
String sobrenome = Console.ReadLine();

Console.WriteLine($"Olá {nome} {sobrenome}, Seja bem vindo");
