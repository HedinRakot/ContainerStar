using ContainerStar.Contracts;
using ContainerStar.Contracts.Entities;
using ContainerStar.Contracts.Managers;
using ContainerStar.Lib.Managers.Base;
using System;

namespace ContainerStar.Lib.Managers
{
    public partial class TaxesManager: EntityManager<Taxes, int>
        ,ITaxesManager
    {

        public TaxesManager(IContainerStarEntities context): base(context){}

    }
}
