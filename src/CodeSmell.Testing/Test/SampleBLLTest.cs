namespace CodeSmell.Testing.Test
{
    using CodeSmell.Testing.NonSingleResponsibility;

    using Moq;

    using Xunit;

    public class SampleBLLTest
    {
        [Fact]
        public void DoSomething()
        {
            var sampleEntity = new SampleEntity();

            var mocking = new Mock<ISampleDAL>();
            mocking.Setup(x => x.IsValidSample1()).Returns(true);

            var sampleBLL = new SampleBLL(mocking.Object);

            sampleBLL.DoSomething(sampleEntity);
        }
    }
}