using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        //propriedades da classe
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI  { get; set; }
        private int Memoria { get; set; }

        //Cria um construtor paramentrizado
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }

        //Método que faz ligação
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        //Método para receber a ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        //Método de instalar o aplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}