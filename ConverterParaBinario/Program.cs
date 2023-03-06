Console.WriteLine("Informe o número a ser convertido para binário:");
int numero = int.Parse(Console.ReadLine());
if (numero < 0)
{
    numero = numero * -1;
    Console.Write("-");
}

int[] resposta = converterBinario(numero, new int[8]);

foreach (int digito in resposta)
{
    Console.Write(digito);
}
int[] converterBinario(int numero, int[] aux, int i = 0)
{
    if (numero == 0) return aux;
    aux[7 - i] = (numero % 2);
    return converterBinario((numero / 2), aux, ++i);
}