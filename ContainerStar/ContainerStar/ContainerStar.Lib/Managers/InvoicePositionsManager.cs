using ContainerStar.Contracts;
using ContainerStar.Contracts.Entities;
using ContainerStar.Contracts.Managers;
using ContainerStar.Lib.Managers.Base;
using System;

namespace ContainerStar.Lib.Managers
{
    public partial class InvoicePositionsManager: EntityManager<InvoicePositions, int>
        ,IInvoicePositionsManager
    {

        public InvoicePositionsManager(IContainerStarEntities context): base(context){}

    }
}