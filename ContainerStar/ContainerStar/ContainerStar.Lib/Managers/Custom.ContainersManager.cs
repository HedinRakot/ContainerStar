﻿
using System;
using System.Collections.Generic;
using System.Linq;
using ContainerStar.Contracts.Entities;

namespace ContainerStar.Lib.Managers
{
    public partial class ContainersManager
    {
        public List<Positions> GetActualPositions(DateTime dateFrom, DateTime dateTo)
        {
            return DataContext.GetSet<Positions>()
                .Where(r => r.ContainerId.HasValue)
                .Where(r =>
                    (r.FromDate >= dateFrom && r.FromDate <= dateTo) || //from date inside period
                    (r.ToDate >= dateFrom && r.ToDate <= dateTo) || // to date inside period
                    (r.FromDate <= dateFrom && r.ToDate >= dateTo)).ToList(); //period is a part of an existing one
        }

        public IQueryable<Containers> GetFreeContainers(IEnumerable<int> usedIds, int? typeId, string name, List<int> equipmentIds)
        {
            if (equipmentIds == null || equipmentIds.Count == 0)
            {
                return DataContext.GetSet<Containers>()
                    .Where(r => !usedIds.Contains(r.Id))
                    .Where(r => (!typeId.HasValue || r.ContainerTypeId == typeId.Value))
                    .Where(r => (String.IsNullOrEmpty(name) || r.Number.ToLower().Contains(name.ToLower())));
            }
            else
            {
                return DataContext.GetSet<Containers>()
                    .Where(r => !usedIds.Contains(r.Id))
                    .Where(r => (!typeId.HasValue || r.ContainerTypeId == typeId.Value))
                    .Where(r => (String.IsNullOrEmpty(name) || r.Number.ToLower().Contains(name.ToLower()))).ToList()
                    .Where(r => equipmentIds.All(o => r.ContainerEquipmentRsps.Select(t => t.EquipmentId).Contains(o))).AsQueryable();
            }
        }        
    }
}
