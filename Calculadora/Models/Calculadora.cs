using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDIO
{
    public class Calculadora
    {
        private List<String> historico;
        private string data;
        public Calculadora()
        { }

        public Calculadora(string data)
        {
            historico = new List<String>();
            this.data = data;
        }

        public int Somar(int value1, int value2)
        {
            int result = value1 + value2;

            AddHistorico(value1, value2, result, "+");

            return result;
        }

        public int Subtrair(int value1, int value2)
        {
            int result = value1 - value2;

            AddHistorico(value1, value2, result, "-");

            return result;
        }

        public int Multiplicar(int value1, int value2)
        {
            int result = value1 * value2;

            AddHistorico(value1, value2, result, "*");

            return result;
        }

        public int Dividir(int value1, int value2)
        {
            int result = value1 / value2;

            AddHistorico(value1, value2, result, "/");

            return result;
        }

        public void AddHistorico(int value1, int value2, int result, string signal)
        {
            historico.Add($"{this.data} | {value1} {signal} {value2} = {result}");
        }


        public List<String> Historico()
        {
            historico.RemoveRange(3, historico.Count() - 3);

            return historico;
        }
    }
}