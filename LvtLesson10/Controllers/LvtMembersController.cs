using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LvtLesson10.Models;

namespace LvtLesson10.Controllers
{
    public class LvtMembersController : Controller
    {
        private readonly LvtK24cnt2lesson01Context _context;

        public LvtMembersController(LvtK24cnt2lesson01Context context)
        {
            _context = context;
        }

        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public async Task<IActionResult> Index()
        {
            return View(await _context.LvtMembers.AsNoTracking().ToListAsync());
        }

        // GET: LvtMembers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
                return NotFound();

            var lvtMember = await _context.LvtMembers
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.MemberId == id);

            if (lvtMember == null)
                return NotFound();

            return View(lvtMember);
        }

        // GET: LvtMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LvtMembers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("LvtUserName,LvtPassword,LvtFullName,LvtEmail,LvtPhone,LvtStatus")]
            LvtMember lvtMember)
        {
            ModelState.Remove("MemberId");

            if (ModelState.IsValid)
            {
                _context.Add(lvtMember);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(lvtMember);
        }

        // GET: LvtMembers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
                return NotFound();

            var lvtMember = await _context.LvtMembers.FindAsync(id);

            if (lvtMember == null)
                return NotFound();

            return View(lvtMember);
        }

        // POST: LvtMembers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            long id,
            [Bind("MemberId,LvtUserName,LvtPassword,LvtFullName,LvtEmail,LvtPhone,LvtStatus")]
            LvtMember lvtMember)
        {
            if (id != lvtMember.MemberId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lvtMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LvtMemberExists(lvtMember.MemberId))
                        return NotFound();
                    else
                        throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(lvtMember);
        }

        // GET: LvtMembers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
                return NotFound();

            var lvtMember = await _context.LvtMembers
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.MemberId == id);

            if (lvtMember == null)
                return NotFound();

            return View(lvtMember);
        }

        // POST: LvtMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var lvtMember = await _context.LvtMembers.FindAsync(id);

            if (lvtMember != null)
            {
                _context.LvtMembers.Remove(lvtMember);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool LvtMemberExists(long id)
        {
            return _context.LvtMembers
                .Any(e => e.MemberId == id);
        }
    }
}