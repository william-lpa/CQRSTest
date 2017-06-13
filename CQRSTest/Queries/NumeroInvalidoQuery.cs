using CQRSTest.Domain;

namespace CQRSTest.Queries
{
    public class NumeroInvalidoQuery: Query<string>
    {
        public int IdNotaFiscal { get; set; }
    }
}
