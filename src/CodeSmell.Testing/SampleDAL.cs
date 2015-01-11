namespace CodeSmell.Testing
{
    public class SampleDAL : ISampleDAL
    {
        public bool IsValidSample1()
        {
            return true;
        }

        public bool IsValidSample2()
        {
            return true;
        }
    }

    public interface ISampleDAL
    {
        bool IsValidSample1();

        bool IsValidSample2();
    }
}