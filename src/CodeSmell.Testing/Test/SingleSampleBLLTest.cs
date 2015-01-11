namespace CodeSmell.Testing.Test
{
    using CodeSmell.Testing.SingleResponsibility;

    using Moq;

    using Xunit;

    public class SingleSampleBLLTest
    {
        [Fact]
        public void DoSomething()
        {
            var sampleEntity = new SampleEntity();

            var mocking = new Mock<ISampleValidator>();
            mocking.Setup(x => x.IsValid()).Returns(true);

            var sampleBLL = new SingleSampleBLL(mocking.Object);

            sampleBLL.DoSomething(sampleEntity);
        } 
    }
}