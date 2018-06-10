using Autofac;
using ValueMapper.Core;

namespace ValueMapper.Autofac
{
    public class ValueMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DefaultValueMapper>()
                .AsImplementedInterfaces();
        }
    }
}