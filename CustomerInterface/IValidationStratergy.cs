namespace CustomerInterface
{
    public interface IValidationStratergy<in T> //Contravarient type T
    {
        void Validate(T obj);
    }
}
