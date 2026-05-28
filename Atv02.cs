/*
Atividade 2 — Matriz de números Crie uma matriz 2x3 com números inteiros (digitado pelo usuário) 
e exiba todos em formato de tabela.


int[,] numero = new int[2,3];

for (int linha = 0; linha < 2; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
      Console.WriteLine("Digite um numero: ");
      nomes[linha, coluna] = Convert.ToInt32(Console.ReadLine()); 
    }
}

Console.WriteLine("Tabela: ");

for (int linha = 0; linha < 2; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
      Console.WriteLine(numero[linha, coluna] + "\t");
    }

    Console.WriteLine();
}
*/