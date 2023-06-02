using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlPagamento
    {
        Pagamento pgto;
        private short opcao;
        
        public ControlPagamento()
        {
            pgto = new Pagamento();
        }//fim do construtor

        //Get e Set
        public short ModificarOpcao
        {
            get { return opcao; }
            set { this.opcao = value; }
        }//fim do método
        public void EscolherFormaDePagamento()
        {
            Console.WriteLine(pgto.MenuFormaDePagamento());//Mostrando o menu na tela
            ModificarOpcao = Convert.ToInt16(Console.ReadLine());//Coletando a resposta
        }//fim do registrarPagamento

        public void Operacao()
        {
            EscolherFormaDePagamento();
           
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Pagamento com Dinheiro: \n\n");
                    Console.WriteLine("Valor Inserido na máquina: ");
                    double valorInserido = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\nValor do Produto: ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    //Utilizar o método efetuar pagamento dinheiro
                    pgto.EfetuarPagamentoDinheiro(valorInserido, valorProduto);
                    Console.WriteLine(pgto.imprimir());
                    break;
                case 2:
                    Console.WriteLine("Pagamento com Cartão: \n\n");
                    Console.WriteLine("\n\nValor do Produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\nCódigo do Cartão: ");
                    int codCartao = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nBandeira do Cartão: \n1. Visa\n2. Mastercard\n3. Elo");
                    short bandeiraCartao = Convert.ToInt16(Console.ReadLine());

                    //Utilizar o método efetuar pagamento dinheiro
                    pgto.EfetuarPagamentoCartao(valorProduto, codCartao, bandeiraCartao);
                    Console.WriteLine(pgto.imprimir());
                    break;
                default:
                    Console.WriteLine("Impossível realizar a operação, tente novamente!");
                    break;
            }//fim do switch
        }//fim do método operação

    }//fim da classe
}//fim do método
