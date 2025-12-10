public static class EnumerableExtensions
{
    extension<T>(IEnumerable<T> src)
    {
        public bool IsEmpty => !src.Any();
        public int Count => src.Count();
        public T PrimeiraPalavraENaoNumeros => src.First();
    }
}