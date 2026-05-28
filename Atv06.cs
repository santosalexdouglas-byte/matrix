/*
Atividade 6 — Maior valor Crie uma matriz 2x3 com números 
inteiros e mostre qual é o maior valor da matriz.


int[,] numero = new int[2,3];

int maior = 0;

for (int linha = 0; linha < 2; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.Write("Digite um numero: ");
         numero[linha, coluna] = int.Parse(Console.ReadLine()); 

         if (numero[linha, coluna] > maior)
         {
            maior = numero[linha, coluna];
         }
    }
}

Console.WriteLine("maior valor: " + maior);
*/