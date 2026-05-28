/*
Atividade 1 — Matriz de nomes
Matrizes em C# 9 Crie uma matriz 2x2 de nomes (digitado pelo usuário) 
e exiba todos os nomes usando for aninhado.


string[,] nome = new string[2,2];

for (int linha = 0; linha < 2; linha++)
{
    for (int coluna = 0; coluna < 2; coluna++)
    {
      Console.WriteLine("Digite um nome: ");
      nomes[linha, coluna] = Console.ReadLine(); 
    }
}

Console.WriteLine("Nomes digitado: ");

for (int linha = 0; linha < 2; linha++)
{
    for (int coluna = 0; coluna < 2; coluna++)
    {
      Console.WriteLine(nome[linha, coluna]);
    }
}
*/