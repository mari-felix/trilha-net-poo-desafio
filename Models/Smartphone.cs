namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        // TODO: Implementado

        public Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            // Implementado: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        //Adicionado método que mostra especificações do celular
        public void MostrarEspecificacoes()
        {
            Console.WriteLine("===DISPOSITIVO===");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria} GB");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
