namespace KronosExpress
{
    /// <summary>
    /// The status of the announcement
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Success
        /// </summary>
        Success,

        /// <summary>
        /// General error
        /// </summary>
        GeneralError,

        /// <summary>
        /// Exists
        /// </summary>
        Exists,

        /// <summary>
        /// Invalid waybill
        /// </summary>
        InvalidAWB,

        /// <summary>
        /// Invalid settlement conde
        /// </summary>
        InvalidSettlementCode,

        /// <summary>
        /// Failed to add the customer
        /// </summary>
        FailToAddCustomer,

        /// <summary>
        /// Invalid weight
        /// </summary>
        InvalidWeight,

        /// <summary>
        /// Invalid service code
        /// </summary>
        InvalidServiceCode,

        /// <summary>
        /// Invalid parcel quantity
        /// </summary>
        InvalidParcelQuantity,

        /// <summary>
        /// Invalid cash on delivery amount
        /// </summary>
        InvalidCODAmount,

        /// <summary>
        /// Invalid combination of services
        /// </summary>
        InvalidCombinatioOfServices,

        /// <summary>
        /// Invalid city
        /// </summary>
        InvalidCity,

        /// <summary>
        /// Maximum weight exceeded
        /// </summary>
        MaximumWeightExceeded,

        /// <summary>
        /// Maximum length of waybill
        /// </summary>
        MaxLengthAWB,

        /// <summary>
        /// Phone missing
        /// </summary>
        PhoneMissing,

        /// <summary>
        /// Maximum length recipient code
        /// </summary>
        MaxLengthRecipientCode,

        /// <summary>
        /// Maximum length recipient name
        /// </summary>
        MaxLengthRecipientName,

        /// <summary>
        /// Maximum length recipient surname
        /// </summary>
        MaxLengthRecipientSurname,

        /// <summary>
        /// Maximum length recipient address
        /// </summary>
        MaxLengthRecipientAddress,

        /// <summary>
        /// Maximum length parcel weight
        /// </summary>
        MaxLengthParcelWeight,

        /// <summary>
        /// Maximum length parcel quantity
        /// </summary>
        MaxLengthParcelQuantity,

        /// <summary>
        /// Invalid warehouse code
        /// </summary>
        InvalidWarehouseCode,

        /// <summary>
        /// Invalid email address
        /// </summary>
        InvalidEmailAddress,

        /// <summary>
        /// No permission
        /// </summary>
        NoPermission,

        /// <summary>
        /// Item does not exist
        /// </summary>
        ItemDoesNotExist,

        /// <summary>
        /// Not enough quantity
        /// </summary>
        NotEnoughQuantity
    }
}
