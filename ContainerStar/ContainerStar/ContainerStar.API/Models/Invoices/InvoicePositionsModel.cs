using ContainerStar.API.Validation;
using ContainerStar.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace ContainerStar.API.Models.Invoices
{
    /// <summary>
    ///     Model for <see cref="InvoicePositions"/> entity
    /// </summary>
    [DataContract]
    public partial class InvoicePositionsModel: BaseModel
    {
        [Required]
        [DataMember]
        public double price{ get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public DateTime? fromDate { get; set; }

        [DataMember]
        public DateTime? toDate { get; set; }
    }
}
