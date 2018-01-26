using Autofac;
using DiExmple.Services;
using DiExmple.Services.Impl;

namespace DiExmple.CompositionRoot
{
    public static class ContainerRegistrations
    {
        public static void Register(this ContainerBuilder builder)
        {
            builder.RegisterType<MessageReader>()
                   .As<IMessageReader>();
        }
    }
}
