using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreProject;
using StoreProject.Entities;
using StoreProject.Models;
using StoreProject.Repository;

namespace StoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : Controller
    {
        public IGroupRepository groupRepository;
        public GroupsController(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository; //DI
        }

        [HttpGet]
        public IList<Group> GetAllGroups()
        {
            return groupRepository.GetAllGroups();
        }

        // POST: Groups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> CreateGroup([Bind("No,Name,Colour")] Group group)
        {
            if (ModelState.IsValid)
            {
                await groupRepository.CreateGroup(group);
            }
            return Ok();
        }

        //    // GET: Groups/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var @group = await _context.Groups.FindAsync(id);
        //        if (@group == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(@group);
        //    }

        // POST: Groups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        public async Task<IActionResult> EditGroup([Bind("id,No,Name,Colour")] Group group)
        {
            
            if (ModelState.IsValid)
            {
                await groupRepository.EditGroup(group);
            }

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGroup([Bind("id,No,Name,Colour")] Group group)
        {
            if (ModelState.IsValid)
            {
                if (groupRepository.DeleteGroup(group) == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        //    // GET: Groups/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var @group = await _context.Groups
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (@group == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(@group);
        //    }

        //    // POST: Groups/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var @group = await _context.Groups.FindAsync(id);
        //        _context.Groups.Remove(@group);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool GroupExists(int id)
        //    {
        //        return _context.Groups.Any(e => e.Id == id);
        //    }
        //}
    }
}
