using ContainerStar.Contracts.Entities;
using CoreBase.Entities;
using CoreBase.ManagerInterfaces;
using System;

namespace ContainerStar.Contracts.Managers
{
    public partial interface ITransportPositionsManager: IEntityManager<TransportPositions, int>
    {
    }
}
