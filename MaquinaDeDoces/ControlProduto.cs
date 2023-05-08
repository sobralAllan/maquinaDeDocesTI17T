using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlProduto
    {
        Produto prod;
        private int opcao;

        public ControlProduto()
        {
            prod = new Produto();
            ModificarOpcao = -1;
        }//fim do construtor

        //Método getSet
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do método get e set de opcao

        //Método Menu
        public void Menu()
        {
            Console.WriteLine("\n\n\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n"                         + 
                              "1. Cadastrar um produto\n"         +
                              "2. Consultar um produto\n"         +
                              "3. Atualizar um produto\n"         +
                              "4. Mudar Situação\n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método Menu

        //Realizar a operação
        public void Operacao()
        {
            do
            {
                Menu();//Mostrando o menu na tela
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.Clear();
                        ColetarDados();
                        break;
                    case 2:
                        Console.Clear();
                        Consultar();
                        break;
                    case 3:
                        Console.Clear();
                        Atualizar();
                        break;
                    case 4:
                        Console.Clear();
                        AlterarSituacao();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do switch
            } while (ModificarOpcao != 0);
            
        }//fim do método Operacao



        //Criar um método de solicitação de Dados
        public void ColetarDados()
        {
            //Coletar Dados
            Console.WriteLine("Informe o código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Faça uma breve descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produtos em estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de validade do lote do produto: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a Situação: True - Ativo | False - Inativo");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());

            //Cadastrar o Produto
            prod.CadastrarProduto(codigo, nome, descricao, preco, quantidade, data, situacao);
            Console.WriteLine("Dado Registrado!");
        }//fim do coletarDados

        //Consultar
        public void Consultar()
        {
            Console.WriteLine("\n\n\nInforme o código do produto que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //Escrever o resultado da consulta na tela
            Console.WriteLine("Os dados do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));
        }//fim do método

        //Atualizar
        public void Atualizar()
        {
            //Atualizar Produto
            Console.WriteLine("\n\nInforme o código do produto que deseja atualizar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            short campo = 0;

            do
            {
                Console.WriteLine("Informe o campo que deseja atualizar de acordo com a regra abaixo: \n" +
                                  "1. Nome\n" +
                                  "2. Descrição\n" +
                                  "3. Preço\n" +
                                  "4. Quantidade\n" +
                                  "5. Data de Validade\n" +
                                  "6. Situação\n");
                campo = Convert.ToInt16(Console.ReadLine());
                //Avisar o usuário
                if((campo < 1) || (campo > 6))
                {
                    Console.WriteLine("Erro, escolha um código entre 1 e 6");
                }
            } while ((campo < 1) || (campo > 6));

            Console.WriteLine("Informe o dado para a atualização: ");
            string novoDado = Console.ReadLine();

            //Chamar o método de atualização
            prod.AtualizarProduto(codigo, campo, novoDado);
            Console.WriteLine("Atualizado!");
        }//fim do método Atualizar

        public void AlterarSituacao()
        {
            Console.WriteLine("Informe o código do produto que deseja alterar o status: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Chamar o método alterarSituação - Classe Produto
            prod.AlterarSituacao(codigo);
            Console.WriteLine("Alterado!");
        }//fim do método


    }//fim da classe
}//fim do projeto
