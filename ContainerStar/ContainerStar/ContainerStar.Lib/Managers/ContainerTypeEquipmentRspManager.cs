using ContainerStar.Contracts;
using ContainerStar.Contracts.Entities;
using ContainerStar.Contracts.Managers;
using CoreBase.Managers;
using System;

namespace ContainerStar.Lib.Managers
{
    public partial class ContainerTypeEquipmentRspManager: EntityManager<ContainerTypeEquipmentRsp, int>
        ,IContainerTypeEquipmentRspManager
    {

        public ContainerTypeEquipmentRspManager(IContainerStarEntities context): base(context){}

    }
}
