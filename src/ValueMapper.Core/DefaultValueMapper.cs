namespace ValueMapper.Core
{
    public class DefaultValueMapper : IValueMapper
    {
        public void MapFrom(object source, object target, MappingOptions options = MappingOptions.None, object state = null)
        {
            throw new System.NotImplementedException();
        }

        public T MapFrom<T>(object source, MappingOptions options = MappingOptions.None, object state = null)
        {
            throw new System.NotImplementedException();
        }
    }
}