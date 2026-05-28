/*
Atividade 4 — Média geral
Crie uma matriz 3x2 de notas e calcule a média geral de todas as notas. Encontre uma forma que o divisor (do cálculo da média) 
seja uma variável incrementada (não atribuir um valor fixo)


double[,] notas = new double [3,2];

double soma = 0;
int quantidade = 0;

for (int linha = 0; linha < 3; linha++)
{
   for (int coluna = 0; coluna < 2; coluna++)
   {
    Console.Write("Digite a nota: ");
    notas[linha, coluna] = int.Parse(Console.ReadLine());
    
    soma += notas[linha, coluna];
    quantidade++;
   }
}

double media = soma / quantidade;
Console.WriteLine("Médida geral: "+ media);
*/