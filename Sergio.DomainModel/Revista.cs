using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{

    /*
     * Classe POCO nao herda de nimguem
     * dados para trafegar entre as camadas view e a dal
     * nao tem tratamento relacionamento e nada mais que uma classe representando os dados da tabela
     * DTO leve
     */

    public class Revista
    {
        public int NUM_EDICAO { get; set; }
        public string CAPA { get; set; }
        public double NIVEL { get; set; }
    }
}