using CQRSTest.Commands;
using CQRSTest.Domain;
using CQRSTest.Events;
using CQRSTest.Queries;

namespace CQRSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //controller, caiu na chamada rest
            var eb = EventBroker.Instance;
            var p = new NotaFiscal(); //insere a nota
            eb.Command(new ValidarNumeroPedidoNFCommand(p.Id, "342354678")); //dispara o comando

            var numeroInvalido = eb.Query(new NumeroInvalidoQuery { IdNotaFiscal = p.Id }); // se no futuro alguem quiser consultar os dados.
        }
    }
}
