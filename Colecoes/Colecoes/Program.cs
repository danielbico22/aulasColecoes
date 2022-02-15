using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumeros = new int[12] { 1, 25, 36, 75, 31, 22, 8, 96, 8, 75, 14, 9 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            Console.WriteLine();
            Console.WriteLine($"O valor mínimo é: {minimo}");
            Console.WriteLine($"O vamor máximo é: {maximo}");
            Console.WriteLine($"O valor médio é: {medio}");
            Console.WriteLine($"A soma dos elementos é: {soma}");
            Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");
            Console.WriteLine();



            //var numerosPares = 
            //    from num in arrayNumeros
            //    where num % 2 ==0
            //    orderby num
            //    select num;
            
            //var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            //Console.WriteLine();
            //Console.WriteLine("Números pares query: " + String.Join(", ", numerosPares));
            //Console.WriteLine("Números pares métodos: " + string.Join(", ", numerosParesMetodo));
            //Console.WriteLine();
            
            
            //Dictionary<string, string> estados = new Dictionary<string, string>();
            //estados.Add("PR", "Paraná");
            //estados.Add("SC", "Santa Catarina");
            //estados.Add("RS", "Rio Grande do Sul");

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
            //}

            //string valorProcurado = "SC";

            //estados.Remove(valorProcurado);

            //Console.WriteLine($"Removendo o valor: {valorProcurado}");

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
            //}
            
          

            //Console.WriteLine("Valor original:");
            //Console.WriteLine(estados[valorProcurado]);

            //estados[valorProcurado] = "SC - teste atualização";

            //Console.WriteLine("Valor atualizado:");
            //Console.WriteLine(estados[valorProcurado]);



            //Stack<string> pilha = new Stack<string>();

            //pilha.Push("Física");
            //pilha.Push("Cálculo");
            //pilha.Push("Algoritmos");

            //Console.WriteLine($"Livros na fila: {pilha.Count}");

            //while (pilha.Count > 0)
            //{
            //    Console.WriteLine($"Retiro o livro {pilha.Peek()} dessa pilha.");
            //    Console.WriteLine($"Livro {pilha.Pop()} removido para leitura.");
            //}

            //Console.WriteLine($"Livros na fila: {pilha.Count}");


            //Queue<string> fila = new Queue<string>();

            //fila.Enqueue("Daniel");
            //fila.Enqueue("Ana Paula");
            //fila.Enqueue("Isabele");
            //fila.Enqueue("Ana Carolina");

            //Console.WriteLine($"Pessoas na fila: {fila.Count}");
            //while (fila.Count > 0)
            //{
            //    Console.WriteLine($"Vez de: {fila.Peek()}");
            //    Console.WriteLine($"{fila.Dequeue()} atendido.");
            //}
            //Console.WriteLine($"Pessoas na fila: {fila.Count}");


            //OperacoesLista opLista = new OperacoesLista();  
            //List<string> estados = new List<string> { "PR", "SC", "RS" };
            //string[] estadosArray = new string[2] { "MS", "GO" };

            ////estados.Add("PR");
            ////estados.Add("SC");
            ////estados.Add("RS");

            //Console.WriteLine($"Quantidade de elementos contidos na lista: {estados.Count}");

            //opLista.ImprimirListaString(estados);

            ////Console.WriteLine("Removendo elemento:");
            ////estados.Remove("SC");

            //Console.WriteLine("Novos estados adicionados:");
            ////estados.AddRange(estadosArray);
            //estados.Insert(1, "SP");
            //opLista.ImprimirListaString(estados);


            //for (int i = 0; i < estados.Count; i++)
            //{
            //    Console.WriteLine($"Índice {i}, Valor: {estados[i]}");
            //}



            //operacoesarray op = new operacoesarray();
            //int[] array = new int[5] { 9, 6, 2, 4, 8 };
            //int[] arrayCopia = new int[10];
            //string[] arrayString = op.ConvertendoArray(array);



            //int valorProcurado = 3;


            //Console.WriteLine($"Capacidade atual do ARRAY: ");
            //op.RedimensionarArray(ref array, array.Length * 2);
            //Console.WriteLine($"Nova capacidade do ARRAY: {array.Length}");


            //int indice = op.ObterIndice(array, valorProcurado);

            //if (indice > -1)
            //{
            //    Console.WriteLine("O índice do elemento {0} é: {1}", valorProcurado, indice);
            //}
            //else
            //{
            //    Console.WriteLine("Valor não existente no conjunto do array.");
            //}


            //int valorAchado = op.ObterValor(array, valorProcurado);
            //if (valorAchado > 0)
            //{
            //    Console.WriteLine("Valor encontrado!");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não encontrado!");
            //}



            //bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            //if (todosMaiorQue)
            //{
            //    Console.WriteLine("Todos os valores são maiores que {0}.", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Existem valores que não são maiores que {0}.", valorProcurado);
            //}




            //bool Existe = op.Existe(array, valorProcurado);

            //if (Existe)
            //{
            //    Console.WriteLine("Valor encontrado! {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Valor não encontrado. {0}", valorProcurado);
            //}


            //Console.WriteLine("Array Original: ");
            //op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            //Console.WriteLine("Array ordenado: ");
            //op.ImprimirArray(array);

            //Console.WriteLine("Array antes da cópia: ");
            //op.ImprimirArray(arrayCopia);

            //op.Copiar(ref array, ref arrayCopia);
            //Console.WriteLine("Array após cópia: ");
            //op.ImprimirArray(arrayCopia);




            //int[,] matriz = new int[4, 2]
            //{
            //    {9, 6},
            //    {10, 15},
            //    {11, 21},
            //    {12, 32}
            //};

            //Console.WriteLine("Mostrando a matriz no terminal.");
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine(matriz[i, j]);
            //    }
            //}


            //    int[] arrayInteiros = new int[3];
            //    arrayInteiros[0] = 11;
            //    arrayInteiros[1] = 22;
            //    arrayInteiros[2] = 33;

            //Console.WriteLine("Percorrendo o array pelo for");
            //for (int i = 0; i < arrayInteiros.Length; i++)
            //{
            //    Console.WriteLine(arrayInteiros[i]);
            //}

            //Console.WriteLine("Percorrendo o array pelo foreach");
            //foreach (int item in arrayInteiros)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}