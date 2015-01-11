namespace CodeSmell.Testing.SingleResponsibility
{
    using System;

    using CodeSmell.Testing;

    public class SampleValidator : ISampleValidator
    {
        private readonly ISampleDAL sampleDAL;

        public SampleValidator(ISampleDAL sampleDAL)
        {
            this.sampleDAL = sampleDAL;
        }

        public bool IsValid()
        {
            if (!this.sampleDAL.IsValidSample1())
            {
                return false;
            }

            if (!this.sampleDAL.IsValidSample2())
            {
                return false;
            }

            return true;
        }
    }

    public interface ISampleValidator
    {
        bool IsValid();
    }
}