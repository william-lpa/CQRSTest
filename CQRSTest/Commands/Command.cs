namespace CQRSTest.Commands
{
    public class Command<T>: ICommand
    {
        public T NewValue { get; set; }
    }

    public interface ICommand
    {
    }
}
