using StoreProject.Entities;
using StoreProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Repository
{
    public interface IGroupRepository
    {
        Task CreateGroup(Group group);
        Task DeleteGroup(Group group);
        List<Group> GetAllGroups();
        Task EditGroup(Group group);
    }
}
