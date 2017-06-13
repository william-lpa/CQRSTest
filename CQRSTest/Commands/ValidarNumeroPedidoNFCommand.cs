using CQRSTest.Domain;

namespace CQRSTest.Commands
{
    public class ValidarNumeroPedidoNFCommand : Command<string>
    {
        public int IdNF { get; set; } //use id not reference
        public string Numero { get; }

        public ValidarNumeroPedidoNFCommand(int idNF, string numero)
        {
            IdNF = idNF;
            Numero = numero;
        }
    }
}
