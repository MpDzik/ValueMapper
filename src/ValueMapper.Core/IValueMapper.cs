namespace ValueMapper.Core
{
    public interface IValueMapper
    {
        /// <summary>
        /// Copies the contents of the <paramref name="source"/> object to the <see cref="target"/> object.
        /// </summary>
        /// <param name="source">The source object.</param>
        /// <param name="target">The target object.</param>
        /// <param name="options">Optional, specifies mapping options.</param>
        /// <param name="state">Optional, custom state object which can be accessed by mapping system.</param>
        void MapFrom(
            object source, 
            object target, 
            MappingOptions options = MappingOptions.None, 
            object state = null);

        /// <summary>
        /// Creates a new instance of <typeparamref name="T"/> and copies the contents of the <paramref name="source"/>
        /// object to the created object.
        /// </summary>
        /// <param name="source">The source object.</param>
        /// <param name="options">Optional, specifies mapping options.</param>
        /// <param name="state">Optional, custom state object which can be accessed by mapping system.</param>
        /// <returns>The created object.</returns>
        T MapFrom<T>(
            object source,
            MappingOptions options = MappingOptions.None,
            object state = null);
    }
}