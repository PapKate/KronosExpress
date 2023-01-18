namespace KronosExpress
{
    /// <summary>
    /// Provides abstractions for the body
    /// </summary>
    public interface IBodyResponseModel<T>
        where T : class
    {
        #region Public Properties

        /// <summary>
        /// The response
        /// </summary>
        public T ResponseModel { get; set; }

        #endregion
    }
}
