using System;

namespace ControleBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            String cliente;
            Double saldo_inicial, vrmovimento;
            Int32 opcao = 0;

            Console.Clear();
            Console.WriteLine("Digite o Nome do cliente: ");
            cliente = Console.ReadLine();

            Console.WriteLine("Digite o Valor inicial:" );
            saldo_inicial =Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Conta c = new Conta(cliente, saldo_inicial);

            while(opcao!=4)
            {
                Console.Clear();
                Console.WriteLine("1 - Consultar Saldo");
                Console.WriteLine("2 - Depositar Valoro");
                Console.WriteLine("3 - Sacar Valor");
                Console.WriteLine("4 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine().ToUpper());
                
                if (opcao ==1)
                {
                    Console.Clear();
                    Console.WriteLine("Seu saldo é: "+c.saldo);
                    Console.ReadKey();
                }
                else if (opcao ==2)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o valor do deposito: ");
                    vrmovimento = Convert.ToDouble(Console.ReadLine());
                    c.Depositar(vrmovimento);
                    
                }
                else if (opcao ==3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o Valor do Saque: ");
                    vrmovimento = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    c.Sacar(vrmovimento);   
                }else if (opcao ==4)
                {
                    Console.Clear();
                    Console.WriteLine("Até Mais :)");
                    Console.ReadKey();
                    Console.Clear();
                }else{
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                    Console.ReadKey();
                }
            }
            
        }
    }
}
