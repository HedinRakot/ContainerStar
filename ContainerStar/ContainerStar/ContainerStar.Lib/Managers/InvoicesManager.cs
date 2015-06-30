using ContainerStar.Contracts;
using ContainerStar.Contracts.Entities;
using ContainerStar.Contracts.Managers;
using ContainerStar.Lib.Managers.Base;
using System;

namespace ContainerStar.Lib.Managers
{
    public partial class InvoicesManager: EntityManager<Invoices, int>
        ,IInvoicesManager
    {

        public InvoicesManager(IContainerStarEntities context): base(context){}

    }
}
