using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //exercicio 1

            //double m, cm, mm;

            //Console.WriteLine("Digite uma distância em metros");

            //m = double.Parse(Console.ReadLine());

            //cm = m * 100;
            //mm = m * 1000;

            //Console.WriteLine("A distÂmcia em cm é: " + cm);
            //Console.WriteLine("A distância em mm é: " + mm);

            // Console.ReadKey();

            /*exercicio 2

            /*a)

            float f, c;

            Console.WriteLine("Escreva um valor em Farenheint");

            f = float.Parse(Console.ReadLine());

            c = (float)((f - 32.0) * (5.0 / 9.0));

            Console.WriteLine("O número que voce digitou em Celsius é igual a: " + c);

            Console.ReadKey(); */

            /*b)

            int f, c;

            Console.WriteLine("Escreva um valor em Farenheint");

            f = int.Parse(Console.ReadLine());

            c = (f - 32) * (5 / 9);

            Console.WriteLine("O número que você digitou em Celsius é igual a: " + c);

            Console.ReadKey();

            //Resulta em 0 pois como é uma variável int, as casas depois da vírgula não são  consideradas.*/

            /*exercicio 3
            
            float p, alt, imc;

            Console.WriteLine("Digite seu peso em  kg.");

            p = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura em metros.");

            alt = float.Parse(Console.ReadLine());

            imc = p / (alt * alt);

            Console.WriteLine("Seu IMC é igual a: " + imc + "kg/m2");

            Console.ReadKey(); */

            /*exercicio 4

            double n1, n2, n3, p1, p2, p3, mp;

            Console.WriteLine("Digite a nota 1. ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2. ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3. ");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso 1. ");
            p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso 2. ");
            p2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso 3. ");
            p3 = double.Parse(Console.ReadLine());

            mp = (n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);

            Console.WriteLine("A média ponderada entre os números citados é igual a " + mp); 
            Console.ReadKey(); */

            /*ecercicio 5

            //fórmula do cálculo da velocidade da onda

            double f, co, v;

            Console.WriteLine("Digite o comprimento da onda. ");
            co = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a frequência da onda. ");
            f = double.Parse(Console.ReadLine());

            v = f * co;

            Console.WriteLine("A velociddade da onda é igual a: " + v);
            Console.ReadKey(); */

            /*exercicio 6

            double s, au, ns;

            Console.WriteLine("Digite o seu salário. ");
            s = double.Parse(Console.ReadLine());

            au = 25 % s;

            ns = s + au;

            Console.WriteLine("Seu novo salário é igual a " + ns);
            Console.ReadKey(); */

            /*exercicio 7
            
            double v, c, vd;

            Console.WriteLine("Digite um valor em real. ");
            v = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da cotação do dólar. ");
            c = double.Parse(Console.ReadLine());

            vd = v / c;

            Console.WriteLine("O valor digitado, em dólares, é igual a: " + vd);

            Console.ReadKey(); */

            /*exercicio 8

            int n, st, ad, s;

            Console.WriteLine("Digite um número. ");
            n = int.Parse(Console.ReadLine());

            st = (n + 3) + 1;
            ad = (n * 2) - 1;

            s = st + ad;

            Console.WriteLine("A soma entre o sucessor do triplo e o antecessor do dobro de seu número é igual a: " + s);
            Console.ReadKey(); */

            /*exercicio 9
            
            int n, l1, l2, l3, l4;

            Console.WriteLine("Digite um número inteiro de 4 dígitos:");
            n = int.Parse(Console.ReadLine());

            l1 = n / 1000;
            l2 = (n / 100) % 10;
            l3 = (n / 10) % 10;
            l4 = n % 10;
           
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);
            Console.WriteLine(l4);

            Console.ReadKey(); */

            /*exercicio 10
            
            double p, f1, f2, f3, f4;

            p = 1000;

            f1 = p - p * 0.034;
            f2 = f1 + f1 * 0.028;
            f3 = f2 + f2 * 0.14;
            f4 = f3 - f3 * 0,085;

            Console.WriteLine("Após a alteração dos valores, o investimento terminou em " + f4);
            Console.ReadKey(); */

            /*exercicio 11

            double n, nc, nq;

            Console.WriteLine("Escreva um número. ");
            n = double.Parse(Console.ReadLine());

            nc = n * n * n;
            nq = n * n;

            Console.WriteLine("Seu número ao cubo é igual a: " + nc);
            Console.WriteLine("Seu número ao quadrado é igual a: " + nq);
            Console.ReadKey(); */

            /*exercício 12
            
            double h, pih, pim;

            Console.WriteLine("Digite sua altura em metros. ");
            h = double.Parse(Console.ReadLine());

            pih = (72.7 * h) - 58;
            pim = (62.1 * h) - 44.7;

            Console.WriteLine("Se você for do sexo masculinoo, seu peso ideal é de " + pih + ". Se você for do sexo feminino, seu peso ideal é " + pim);
            Console.ReadKey(); */

            /*exercicio 13
            
            GIT é um sistema de controle de versão de software que permite aos desenvolvedores trabalhar em projetos de forma colaborativa,
            mantendo um histórico de alterações, permitindo a coordenação de diferentes versões e possibilitando o trabalho em equipe de forma mais eficiente.

            GitHub é uma plataforma web que oferece serviços de hospedagem de repositórios GIT, além de outras ferramentas para gerenciamento de projetos de software. 

            10 exemplos de comandos presentes no GIT:

            git init: Inicializa um repositório GIT em um diretório local.
            git add: Adiciona um arquivo ou uma pasta ao controle de versão do GIT.
            git commit: Cria um novo snapshot do código com as alterações feitas, criando um registro permanente no histórico de versões.
            git status: Mostra o status atual dos arquivos em relação ao controle de versão, indicando quais foram modificados, quais estão prontos para serem commitados, entre outras informações.
            git log: Mostra o histórico de commits do repositório, incluindo informações como o autor, a data, o hash do commit, a mensagem de commit, entre outras.
            git diff: Mostra as diferenças entre o código atual e a última versão commitada.
            git branch: Cria uma nova ramificação do código, permitindo que diferentes versões do código sejam desenvolvidas simultaneamente.
            git checkout: Altera a ramificação atual do código para outra existente no repositório.
            git merge: Combina duas ou mais ramificações do código em uma única versão, unificando as alterações realizadas em cada uma delas.
            git clone: Cria uma cópia do repositório remoto em um repositório local, permitindo que o desenvolvimento do projeto seja feito de forma colaborativa. */

        }
    }
}
