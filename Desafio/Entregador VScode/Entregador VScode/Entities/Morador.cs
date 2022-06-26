namespace Entregador_VScode.Entities
{
    public class Morador : Moradores_Base
    {
        public Morador(string fone, string numeroCasa) : base(fone, numeroCasa)
        {
        }

        public override string ToString()
        {
            return "Numero do telefone: " + this.fone + "\n"
                + "Numero da casa: " + this.numeroCasa;
        }
    }
}