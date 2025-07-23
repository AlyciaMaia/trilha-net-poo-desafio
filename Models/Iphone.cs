namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        //Método subscrito da classe herdada
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app '{nomeApp}' no Iphone");
        }
    }
}