// faça um programa que nao deixe o vetor 2 se repetir em nenhum numero, e nao pode mexer no vetor original

int size = 10, aux = 0, sizeVetorOrdenado = 0;
int[] vetorOriginal = new int[size];
int[] vetorOrdenado = new int[size];
int[] contrario = new int[size];


for (int i = 0; i < size; i++)
{
    vetorOriginal[i] = new Random().Next(0,5);
    if (i == 0)
    {
        vetorOrdenado[sizeVetorOrdenado] = vetorOriginal[i];
        sizeVetorOrdenado++;
    }
    else
    {
        bool repetido = false;
        for (int j = 0; j < sizeVetorOrdenado; j++)
        {
            if (vetorOrdenado[j] == vetorOriginal[i])
            {
                repetido = true;
            }
        }
        if (!repetido)
        {
            vetorOrdenado[sizeVetorOrdenado] = vetorOriginal[i];
            sizeVetorOrdenado++;
        }
    }
    //Console.Write(vetorOriginal[i] + " ");
    //vetorOrdenado[i] = vetorOriginal[i];
}

for (int i = 0; i < sizeVetorOrdenado; i++)
{
    contrario[i] = vetorOrdenado[i];
}
    //Console.Write(vetorOriginal[i] + " ");

//Console.ReadLine();

for (int i = 0; i < sizeVetorOrdenado; i++)
{
    for (int j = i + 1; j < sizeVetorOrdenado; j++)
    {
        if (vetorOrdenado[i] > vetorOrdenado[j])
        {
            aux = vetorOrdenado[i];
            vetorOrdenado[i] = vetorOrdenado[j];
            vetorOrdenado[j] = aux;
        }
    }
}

for (int i = 0; i < sizeVetorOrdenado; i++)
{
    for (int j = i + 1; j < sizeVetorOrdenado; j++)
    {
        if (contrario[i] < contrario[j])
        {
            aux = contrario[i];
            contrario[i] = contrario[j];
            contrario[j] = aux;
        }
    }
}

Console.WriteLine("Vetor original");
for (int i = 0; i < size; i++)
{
    Console.Write($"{vetorOriginal[i]} ");
}

Console.WriteLine("\nVetor ordenado");
for (int i = 0; i < sizeVetorOrdenado; i++)

{
    Console.Write($"{vetorOrdenado[i]} ");
}

Console.WriteLine("\nVetor Ordenado ao contrario: ");
for (int i = 0; i < sizeVetorOrdenado; i++)
{
    Console.Write($"{contrario[i]} ");
}
    Console.ReadKey();
    // fazer um terceiro vetor que mostre os valores do maior para menor
// faça um programa que sorteie os 6 numeros da mega-sena e grave-os num vetor ordenado e imprima

