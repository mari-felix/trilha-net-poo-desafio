namespace DesafioPOO.Models
{
    // Implementado: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Implementado: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Celular Nokia...");
            Console.WriteLine($"{nomeApp} instalado no Celular Nokia.");
        }
    }

}
