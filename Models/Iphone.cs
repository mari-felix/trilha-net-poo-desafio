namespace DesafioPOO.Models
{
    public class IPhone : Smartphone
    {
        public IPhone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {

        }

    // TODO: Herdar da classe "Smartphone"



        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando {nomeApp} no Celular iPhone...");
            Console.WriteLine("{nomeApp} instalado no Celular Nokia.");
        }
    }
}
