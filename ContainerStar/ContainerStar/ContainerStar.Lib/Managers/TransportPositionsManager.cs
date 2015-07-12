using ContainerStar.Contracts;
using ContainerStar.Contracts.Entities;
using ContainerStar.Contracts.Managers;
using ContainerStar.Lib.Managers.Base;
using System;

namespace ContainerStar.Lib.Managers
{
    public partial class TransportPositionsManager: EntityManager<TransportPositions, int>
        ,ITransportPositionsManager
    {

        public TransportPositionsManager(IContainerStarEntities context): base(context){}

    }
}
