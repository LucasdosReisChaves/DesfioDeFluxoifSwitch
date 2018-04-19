using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //comentario in-line(em linha)
            /*
               Comentario in-block(em bloco) 
             */
             //Declaração da variável da operação. Ela será do tipo inteira 
             int operacao;
             
             //Declaração das variáveis n1 e n2. Elas serão do tipo double
             double n1, n2;

            /*
            Para limpar a tela de comando a cada execução, utilizaremos o comando Console.Clear();
            obs.:Clear->Limpar
            
            */
            Console.Clear();
            Console.WriteLine("Escolha uma das operções abaixo:");
            /*Para a exibição das opções de operação, vamos usar  o comando Console.WriteLine e, nele usaremos um comandos de quebra de line \n(contra-barra n(new line)).
            Assim, as opções ficarão uma abaixo da outra.
            */
            Console.WriteLine("n1-soma\n2-subtrair\n3-multiplicar\n4-dvidir");
            operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite outro número");
            n2 = double.Parse(Console.ReadLine());

            


        }
    }
}
