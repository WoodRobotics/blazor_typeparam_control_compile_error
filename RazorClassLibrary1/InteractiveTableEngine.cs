namespace RazorClassLibrary1
{
    public class InteractiveTableEngine<T>
    {
        public List<InteractiveColumn<T>> Columns { get; private set; } = [];
    }
}