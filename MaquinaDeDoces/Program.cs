﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conecta com a classe Control Produto
            ControlPagamento controlPgto = new ControlPagamento();

            //Chamar o método principal daquela classe
            controlPgto.Operacao();            

            Console.ReadLine();//Manter a janela aberta
        }//fim do método main
    }//fim da classe
}//fim do projeto
