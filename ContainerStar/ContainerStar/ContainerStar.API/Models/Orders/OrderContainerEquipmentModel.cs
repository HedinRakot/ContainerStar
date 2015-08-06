using ContainerStar.API.Validation;
using ContainerStar.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace ContainerStar.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrderContainerEquipment"/> entity
    /// </summary>
    [DataContract]
    public partial class OrderContainerEquipmentModel : BaseModel
    { 
        [Required]
        [DataMember]
        public int orderId{ get; set; }

        [Required]
        [DataMember]
        public int containerId { get; set; }

        [Required]
        [DataMember]
        public int equipmentId { get; set; }

        [Required]
        [DataMember]
        public int amount { get; set; }
    }
}
