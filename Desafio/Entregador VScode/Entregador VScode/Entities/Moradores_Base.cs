namespace Entregador_VScode.Entities
{
    public class Moradores_Base
    {
        private string telefone, numeroResidencia;

        public Moradores_Base(string fone, string numeroCasa)
        {
            this.fone = fone;
            this.numeroCasa = numeroCasa;
        }
        public string fone { get => telefone; set => telefone = value; }
        public string numeroCasa { get => numeroResidencia; set => numeroResidencia = value; }   
    }
}