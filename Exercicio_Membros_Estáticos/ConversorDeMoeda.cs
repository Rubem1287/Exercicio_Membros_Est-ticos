using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Membros_Estáticos
{
    class ConversorDeMoeda
    {

        public static double Dolar;
        public static double Quantidade;

        public static double Conversao()
        {
            double iof = 0;

            double porcentagem = 6.0/100.0;

            double valortotal = 0;

            iof = (Dolar * Quantidade)*porcentagem;

            valortotal = (Dolar * Quantidade) + iof;

            return(valortotal);
        }

    }
}
