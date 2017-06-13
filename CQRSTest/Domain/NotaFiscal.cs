using CQRSTest.Events;
using CQRSTest.Commands;
using CQRSTest.Queries;
using System;

namespace CQRSTest.Domain
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        private string numero;

        public string Numero
        {
            get { return numero; }
        }

        public NotaFiscal()
        {
            EventBroker.Instance.Commands += ValidarNumeroPedidoCommand;
            EventBroker.Instance.Queries += BrokerOnQuery;
        }

        private void ValidarNumeroPedidoCommand(object sender, ICommand e)
        {
            var cac = e as ValidarNumeroPedidoNFCommand;
            if (cac?.IdNF == Id && cac.Numero != "1")//não está contido no repositorio
            {
                EventBroker.Instance.Events.Add(new NumeroInvalidoNFChangedEvent(Id, numero, cac.Numero)); // pedido Incorreto
                numero = cac.Numero;
            }
        }

        private void BrokerOnQuery(object sender, IQuery e)
        {
            var ac = e as NumeroInvalidoQuery;
            if (ac?.IdNotaFiscal == Id)
                ac.Result = Numero;

        }
    }
}
