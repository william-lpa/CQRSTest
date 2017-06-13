using CQRSTest.Domain;

namespace CQRSTest.Events
{
    public class NumeroInvalidoNFChangedEvent : Event
    {
        //        public NotaFiscal Target { get; set; }  //n usar referencia
        public int IdNotaFiscal { get; set; }
        public string OldValue, NewValue;

        public NumeroInvalidoNFChangedEvent(int idNotaFiscal, string oldValue, string newValue)
        {
            IdNotaFiscal = idNotaFiscal;
            OldValue = oldValue;
            NewValue = newValue;

        }

        public override string ToString()
        {
            return $"NumeroNF Changed from {OldValue} to {NewValue}";
        }
    }
}
