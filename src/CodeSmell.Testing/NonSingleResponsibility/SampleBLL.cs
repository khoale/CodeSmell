namespace CodeSmell.Testing.NonSingleResponsibility
{
    using System;

    public class SampleBLL
    {
        private readonly ISampleDAL sampleDAL;

        public SampleBLL(ISampleDAL sampleDAL)
        {
            this.sampleDAL = sampleDAL;
        }

        public void DoSomething(SampleEntity entity)
        {
            if (!this.sampleDAL.IsValidSample1())
            {
                throw new Exception();
            }

            ////if (!this.sampleDAL.IsValidSample2())
            ////{
            ////    throw new Exception();
            ////}

            // Code here
        }
    }
}