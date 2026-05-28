
double[,] notas = new double[3,2];

for (int linha = 0; linha < 3; linha++)
{
    double soma = 0;

    for (int coluna = 0; coluna < 2; coluna++)
    {
        Console.Write("Digite a nota: ");
        notas[linha, coluna] = int.Parse(Console.ReadLine());

        soma += notas[linha, coluna];
    }

    double media = soma / 2;

    Console.WriteLine("Média do aluno" + linha + ":" + media);
}
