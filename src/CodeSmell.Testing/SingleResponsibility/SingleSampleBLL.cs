namespace CodeSmell.Testing.SingleResponsibility
{
    using System;

    using CodeSmell.Testing;

    public class SingleSampleBLL
    {
        private readonly ISampleValidator validator;

        public SingleSampleBLL(ISampleValidator validator)
        {
            this.validator = validator;
        }

        public void DoSomething(SampleEntity entity)
        {
            if (!this.validator.IsValid())
            {
                throw new Exception();
            }

            // Code here
        }
    }
}