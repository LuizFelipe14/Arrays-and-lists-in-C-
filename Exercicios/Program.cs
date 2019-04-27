using System;
using System.Collections.Generic;
using System.Globalization;

using Class.Pensionato;
using Class.Employee;

namespace Exercicios {
    class Program {
        static void Main(string[] args) {


            #region "Exercicio 1 - Vetores"

            //Console.Write("How many rooms will be rented? ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Pensionato[] vect = new Pensionato[10];



            //for (int i = 1; i <= n; i++) {

            //    Console.WriteLine("Rent #" + i + ":");


            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();

            //    Console.Write("Room: ");
            //    int room = int.Parse(Console.ReadLine());
            //    Console.WriteLine();

            //    // Mandando name, email através do construtor
            //    vect[room] = new Pensionato(name, email);

            //}


            //Console.WriteLine();
            //Console.WriteLine("Busy rooms: ");

            //for (int i = 0; i < 10; i++) {

            //    if (vect[i] != null) {
            //        Console.WriteLine(i
            //            + ": "
            //            + vect[i].Name
            //            + ", "
            //            + vect[i].Email);
            //    }
            //}

            #endregion

            #region"Exemplos Listas"

            //List<string> list = new List<string>();

            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Anna");
            //list.Insert(2, "Marco");

            //foreach(string obj in list) {
            //    Console.WriteLine(obj);
            //}

            ////Exibindo quantos itens tem na lista
            //Console.WriteLine("List count: " + list.Count);


            ////Encontrando o PRIMEIRO item da lista(os values) que tem 'A' como primeiro caracter
            //string s1 = list.Find(x => x[0] == 'A');
            //Console.WriteLine("Find: " + s1);

            ////Encontrando o ULTIMO item da lista(os values) que tem 'A' como primeiro caracter
            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Find Last: " + s2);


            ////Encontrando a POSIÇÃO do PRIMEIRO item da lista que tem 'A' como primeiro caracter
            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine(pos1);

            ////Encontrando a POSIÇÃO do ULTIMO item da lista que tem 'A' como primeiro caracter
            //int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine(pos2);

            //Console.WriteLine("=============================================");

            ////Encontrando todos os itens da lista que tenha 5 caracteres e armazenando em uma nova lista
            //List<string> list2 = list.FindAll(x => x.Length == 5);

            ////Exibindo todos os resultados encontrados que foram armazenados na nova lista
            //foreach(string obj in list2) {
            //    Console.WriteLine(obj);
            //}

            ////Removendo um item da lista (passando como parametro o value da lista)
            ////Passando um string como parametro pq a lista é do tipo string
            //list.Remove("Alex");


            ////Removendo TODOS os itens da lista que COMEÇAM com a letra 'M'
            //list.RemoveAll(x => x[0] == 'M');

            ////Removendo o item da lista que está na posição 3
            //list.RemoveAt(3);


            ////Passando um número de uma posição inicial e uma posição final
            ////Feito isso a função remove oque estiver no intermediário 
            //list.RemoveRange(2, 2);

            #endregion


            #region"Exercicio 2 - Listas"

            //Estaciando a classe, 
            //Employee e = new Employee();

            //List<Employee> list = new List<Employee>();

            //Console.Write("How many employees will be registered ? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) {

            //    Console.WriteLine("Employee #" + i);

            //    Console.Write("Id: ");
            //    int id = int.Parse(Console.ReadLine());

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Salary: ");
            //    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.WriteLine();

            //    list.Add(new Employee(id, name, salary));


            //}



            //Console.Write("Enter the employee id that will have salary increase: ");
            //int increase = int.Parse(Console.ReadLine());

            //Employee pos = list.Find(x => x.Id == increase);


            //if (pos != null) {

            //    Console.Write("Enter the porcentage: ");
            //    double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    e.increaseSalary(porc);


            //    Console.WriteLine();
            //}
            //else {
            //    Console.WriteLine("This id does not exists! ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Update list of employee: ");

            //foreach(Employee obj in list) {
            //    Console.WriteLine(obj);
            //}




            #endregion

            #region "Exemplo 1 Matrizes"

            //int n = int.Parse(Console.ReadLine());

            //int[,] mat = new int[n, n];

            ////========================
            ////Preenchendo matriz
            ////========================
            ////For responsavél para percorrer as linhas
            //for (int i = 0; i < n; i++) {

            //    //Pegando toda a string digitada, recortando baseado em um espaço em brando, e guardando em um vetor
            //    string[] values = Console.ReadLine().Split(' ');

            //    //For responsavél para percorrer as colunas
            //    for (int j = 0; j < n; i++) {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //Console.WriteLine("Main diagonal: ");
            //for (int i = 0; i < n; i++) {

            //    Console.WriteLine(mat[i,i] + " ");
            //}

            //Console.WriteLine();


            //int count = 0;
            ////Percorrendo toda a matriz, para descobrir se tem número negativos
            //for(int i = 0; i < n; i++) {

            //    for(int j = 0; j < n; j++) {

            //        //Verificando quantos números negativos tem dentro na matriz
            //        if(mat[i, j] < 0) {
            //            count++;
            //        }
            //    }
            //}

            //Console.WriteLine("Negative numbers: " + count);


            #endregion

            #region "Exemplo 2 Matrizes"

            //double[,] mat = new double[2, 3];

            ////Função que declara quantos elementos a matriz tem no TOTAL
            //Console.WriteLine(mat.Length);

            ////Função que declara a quantidade de linhas da matriz
            //Console.WriteLine(mat.Rank);

            //Console.WriteLine(mat.GetLength(0));

            #endregion

            #region "Exercicio 3 - Matrizes"


            //string[] line = Console.ReadLine().Split(' ');

            ////Entrada de linhas
            //int m = int.Parse(line[0]);
            ////Entrada de colunas
            //int n = int.Parse(line[1]);


            ////Estanciando a matriz de M linhas e N colunas
            //int[,] mat = new int[m, n];


            ////Entrada dos values da matriz
            //for (int i = 0; i < m; i++) {

            //    //Vetor para pegar as values de entrada da matriz
            //    //recortando a string baseado em um espaço em brando, e guardando no vetor
            //    string[] values = Console.ReadLine().Split(' ');

            //    for (int j = 0; j < n; j++) {

            //        //Transformando os values em inteiros e colocando dentro da matriz
            //        mat[m, n] = int.Parse(values[j]);
            //    }
            //}



            ////Pedindo número existente na matriz
            //int numberExists = int.Parse(Console.ReadLine());

            ////Percorrendo toda a matriz (Percorrendo todos os values)
            //for (int i = 0; i < m; i++) {

            //    for (int j = 0; j < n; j++) {

            //        //SE a matriz da linha i, coluna j for igual ao número digitado
            //        if (mat[i, j] == numberExists) {                         
            //            Console.WriteLine("Position " + i + ", " + j + " : ");

            //            if(j > 0) {
            //                Console.WriteLine("Left: " + mat[i, j -1]);
            //            }
            //            if(i > 0) {
            //                Console.WriteLine("Up: " + mat[i - 1, j]);
            //            }
            //            if(j < n - 1) {
            //                Console.WriteLine("Right: " + mat[i, j + 1]);
            //            }
            //            if(i < m - 1) {
            //                Console.WriteLine("Down: " + mat[i + 1, j);
            //            }
            //        }
            //    }
            //}

            #endregion


            #region "Exemplo - Conjunto"

            //HashSet<int> A = new HashSet<int>();
            //HashSet<int> B = new HashSet<int>();

            ////Adicionando elementos ao conjunto
            //A.Add(3);
            //A.Add(5);
            //A.Add(8);
            //A.Add(9);

            ////Adicionando elementos ao conjunto
            //B.Add(3);
            //B.Add(4);
            //B.Add(5);


            ////Para percorrer todos os elementos do conjunto não pode-se fazer um FOR normal
            ////Conjunto não tem posição 
            ////É necessário fazer um ForEach para percorrer o conjunto
            //foreach (int obj in A) {

            //    Console.WriteLine(obj);
            //}

            //int N = int.Parse(Console.ReadLine());

            ////Verificando se N existe dentro do conjunto
            //if (A.Contains(N)) {
            //    Console.WriteLine(N + " pertence ao conjunto A");
            //}
            //else {
            //    Console.WriteLine(N + " não pertence ao conjunto A");
            //}

            ////Removendo um elemento de dentro do conjunto(Dentro dos aprenteses passar o elemento que deseja remover)
            //A.Remove(4);


            ////Removendo todos os elementos que existem no conjunto A e também existem no conjunto B
            ////=================================================================
            ////Comando: Remover do conjunto A tudo que pertence ao conjunto B
            ////=================================================================
            //A.ExceptWith(B);

            ////União entre conjuntos
            ////=================================================================
            ////Comando: Adicionando no conjunto A tudo que existe no conjunto B mas que ainda não exista no conjunto A
            ////=================================================================
            //A.UnionWith(B);


            ////Mostra a intercecção entre os conjuntos
            ////Mostra os elementos que existem no conjunto A e que também existem no conjunto B
            //A.IntersectWith(B);



            #endregion



            #region "Exercicio - Conjuntos"

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            //Criando um conjunto vazio, para fazer a união com o outros conjuntos
            HashSet<int> U = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos: ");
            int alunosA = int.Parse(Console.ReadLine());

            

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            for (int i = 0; i < alunosA; i++) {
                int codAluno = int.Parse(Console.ReadLine());
                A.Add(codAluno);
            }

            Console.WriteLine();
            Console.Write("Digite os códigos dos alunos do curso B: ");
            int alunosB = int.Parse(Console.ReadLine());

            for (int i = 0; i < alunosB; i++) {
                int codAluno = int.Parse(Console.ReadLine());
                B.Add(codAluno);
            }


            Console.WriteLine();
            Console.Write("Digite os códigos dos alunos do curso C: ");
            int alunosC = int.Parse(Console.ReadLine());

            for (int i = 0; i < alunosC; i++) {
                int codAluno = int.Parse(Console.ReadLine());
                C.Add(codAluno);
            }


            //foreach(int obj in A) {
            //    Console.WriteLine();
            //    Console.WriteLine(obj);
            //}

            //foreach (int obj in B) {
            //    Console.WriteLine();
            //    Console.WriteLine(obj);
            //}

            //foreach (int obj in C) {
            //    Console.WriteLine();
            //    Console.WriteLine(obj);
            //}

            //Declarando união entre os conjuntos
            //================================================================================
            //Obs: Adicionando os elementos dos conjuntos A, B, C dentro de um conjunto vazio
            //Declarando união para que os elementos não se repitam
            //================================================================================
            U.UnionWith(A);
            U.UnionWith(B);
            U.UnionWith(C);

            //Contador para pegar a soma dos elementos que contém dentro do conjunto U
            int count = 0;
            foreach (int obj in U) {
                //Console.WriteLine();
                //Console.WriteLine(obj);

                //Adicionando ao contador, para referenciar quantas vezes o foreach foi repetido
                count++;
            }

            Console.WriteLine();
            Console.WriteLine("Total de alunos: " + count);

            #endregion




        }
    }
}
