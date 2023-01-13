namespace KronosExpress
{
    public class TrackAndTraceResultResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The track and traces
        /// </summary>
        [XmlElement(ElementName = "TrackAndTraceClass")]
        public IEnumerable<TrackAndTraceClassResponseModel> TrackAndTraceClasses { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackAndTraceResultResponseModel()
        {

        }

        #endregion
    }
}
