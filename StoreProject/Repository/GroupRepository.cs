using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreProject.Entities;
using StoreProject.Models;

namespace StoreProject.Repository
{
    public class GroupRepository : BaseRepository, IGroupRepository
    {
        public GroupRepository(StoreContext context) : base(context)
        {
        }

        public async Task CreateGroup(Group group)
        {
            var newGroupEntity = new GroupEntity(group.Name,group.Colour,group.No);
            _context.Groups.Add(newGroupEntity);

            await _context.SaveChangesAsync(); 
        }

        public Task DeleteGroup(Group group)
        {
            try
            {
                var deletedElement = _context.Groups.Single((gr) => gr.Id == group.Id);
                _context.Groups.Remove(deletedElement);
                return _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            
        }

        public async Task EditGroup(Group group)
        {
            if (_context.Groups.Where((gr => gr.Id == group.Id)) != null)
            {
                var editedGroup = new GroupEntity(group.Id,group.Name, group.Colour, group.No);
                _context.Groups.Update(editedGroup);
                await _context.SaveChangesAsync();
            }
        }

        public List<Group> GetAllGroups()
        {
            List<Group> groups = new List<Group>();
            var groupEntitiesList = _context.Groups.ToList();
            foreach (var groupEntity in groupEntitiesList)
            {
                groups.Add(new Group(groupEntity.Id, groupEntity.Name, groupEntity.No, groupEntity.Colour));
            }
            return groups;
        }
    }
}
