namespace CQRSTest.Queries
{
    public class Query<T>: IQuery
    {
        public T Result { get; set; }
    }

    public interface IQuery
    {
    }
}
