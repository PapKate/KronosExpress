namespace KronosExpress
{
    /// <summary>
    /// Provides abstractions for the body
    /// </summary>
    public interface IBody<T>
        where T : class
    {
        #region Public Properties

        /// <summary>
        /// The response
        /// </summary>
        public T Model { get; set; }

        #endregion
    }
}
