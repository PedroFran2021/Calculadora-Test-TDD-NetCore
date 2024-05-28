using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        { 
            listahistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;

            listahistorico.Insert(0, "Res: " + resultado + " - data: " + data);
            return resultado;
        }
        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            listahistorico.Insert(0, "Res: " + resultado + " - data: " + data);

            return resultado;
        }
        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            listahistorico.Insert(0, "Res: " + resultado + " - data: " + data);

            return resultado;
        }
        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            listahistorico.Insert(0, "Res: " + resultado + " - data: " + data);

            return resultado;

        }

        public List<string> historico()
        {

            listahistorico.RemoveRange(3, listahistorico.Count - 3);

            return listahistorico;
        }

    }
}

