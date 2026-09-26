
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LvtLesson11.Models;

public class LvtEmployeesController : Controller
{
    private readonly LvtLesson11Context _context;

    public LvtEmployeesController(LvtLesson11Context context)
    {
        _context = context;
    }

    // GET: LVTEMPLOYEES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.LvtEmployees.ToListAsync());
    }

    // GET: LVTEMPLOYEES/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lvtemployee = await _context.LvtEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (lvtemployee == null)
        {
            return NotFound();
        }

        return View(lvtemployee);
    }

    // GET: LVTEMPLOYEES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: LVTEMPLOYEES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,LvtName,LvtGender,LvtBirthDay,LvtEmail,LvtPhone,LvtActive")] LvtEmployee lvtemployee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(lvtemployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(lvtemployee);
    }

    // GET: LVTEMPLOYEES/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lvtemployee = await _context.LvtEmployees.FindAsync(id);
        if (lvtemployee == null)
        {
            return NotFound();
        }
        return View(lvtemployee);
    }

    // POST: LVTEMPLOYEES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,LvtName,LvtGender,LvtBirthDay,LvtEmail,LvtPhone,LvtActive")] LvtEmployee lvtemployee)
    {
        if (id != lvtemployee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(lvtemployee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LvtEmployeeExists(lvtemployee.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(lvtemployee);
    }

    // GET: LVTEMPLOYEES/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lvtemployee = await _context.LvtEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (lvtemployee == null)
        {
            return NotFound();
        }

        return View(lvtemployee);
    }

    // POST: LVTEMPLOYEES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var lvtemployee = await _context.LvtEmployees.FindAsync(id);
        if (lvtemployee != null)
        {
            _context.LvtEmployees.Remove(lvtemployee);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LvtEmployeeExists(long? id)
    {
        return _context.LvtEmployees.Any(e => e.Id == id);
    }
}
