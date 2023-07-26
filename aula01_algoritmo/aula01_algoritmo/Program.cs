// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Runtime.InteropServices;

int[] lista = {5,3,4,6,2};
string[] comprasLista = { "ameixa", "abobora", "ovo", "pato", "caixa", "abelha" };

Console.WriteLine(string.Join(", ", lista.ToList()));
OrdenacaoPorInsercaoInt(lista);
Console.WriteLine(string.Join(", ", lista.ToList()));

Console.WriteLine(string.Join(", ", comprasLista.ToList()));
OrdenacaoPorInsercao(comprasLista);
Console.WriteLine(string.Join(", ", comprasLista.ToList()));

void OrdenacaoPorInsercaoInt(int[] array)
{
    for (int i =1; i < array.Length; i++)
    {
        int j = i;

        while (j>0 && array[j] > array[j - 1])
        {
            int temp = array[j];
            array[j] = array[j-1];
            array[j-1] = temp;
            j--;
        }

    }


}

void OrdenacaoPorInsercao <T>(T[] array) where T : IComparable
{
    for(int i = 1; i < array.Length ; i++)
    {
        //i = útima carta da direira a ser ordenada
        //j = guarda essa informação mas vai iterando até chegar na primeira carta (0)
        // esse armazenamento é necessário pois caso contrário alteraríamos o i
        // atrapalhando o for

        int j = i;

        // se j > 0 e posição j é menor que posição anterior a j
        // precisa de verificação se é > 0 pois como o loop vai do final
        // ao início, ele vai parar quando chegar ao índice 0
        // caso contrário ele tentaria compara o índice 0 com o -1 (que não existe)

        while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
        {
            T temp = array[j];
            array[j] = array[j - 1];
            array[j - 1] = temp;
            j--;
        }
    }
}


