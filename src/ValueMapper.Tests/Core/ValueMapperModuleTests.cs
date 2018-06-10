using Autofac;
using ValueMapper.Autofac;
using ValueMapper.Core;
using Xunit;

namespace ValueMapper.Tests.Core
{
    public class ValueMapperModuleTests
    {
        private IContainer _container;

        public ValueMapperModuleTests()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ValueMapperModule>();
            _container = builder.Build();
        }

        [Fact]
        public void ShouldResolveValueMapper()
        {
            var mapper = _container.Resolve<IValueMapper>();

            Assert.NotNull(mapper);
        }
    }
}