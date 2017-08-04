using Xunit;
using Autofac;

namespace ServerlessApp.Tests
{
    public class MyService_Tests
    {
        [Fact]
        public void Execute_Writes_Request_And_Returns_Success()
        {
            // arrange
            var request = new Request();

            var fooServiceEntry = new FooServiceEntry();
            
            // act
            var result = fooServiceEntry.Run(request);

            // assert
            var writer = (LocalRequestWriter)ServiceProvider<FooService>.Container.Resolve<IRequestWriter>();
            Assert.Equal(1, writer.WriteCount);
            Assert.Equal("Success", result.Message);
        }
    }
}
