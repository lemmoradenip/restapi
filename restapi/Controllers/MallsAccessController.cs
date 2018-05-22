using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using restapi.Models;

namespace restapi.Controllers
{
    public class MallsAccessController : Controller
    {
        private readonly restapiContext _context;

        public MallsAccessController(restapiContext context)
        {
            _context = context;
        }

        // GET: MallsAccess
        public async Task<IActionResult> Index()
        {
            return View(await _context.Malls.ToListAsync());
        }

        // GET: MallsAccess/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var malls = await _context.Malls
                .SingleOrDefaultAsync(m => m.Id == id);
            if (malls == null)
            {
                return NotFound();
            }

            return View(malls);
        }

        // GET: MallsAccess/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MallsAccess/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Descriptions,Address,About,TelPhone,Website,Email")] Malls malls)
        {
            if (ModelState.IsValid)
            {
                _context.Add(malls);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(malls);
        }

        // GET: MallsAccess/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var malls = await _context.Malls.SingleOrDefaultAsync(m => m.Id == id);
            if (malls == null)
            {
                return NotFound();
            }
            return View(malls);
        }

        // POST: MallsAccess/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Descriptions,Address,About,TelPhone,Website,Email")] Malls malls)
        {
            if (id != malls.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(malls);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MallsExists(malls.Id))
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
            return View(malls);
        }

        // GET: MallsAccess/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var malls = await _context.Malls
                .SingleOrDefaultAsync(m => m.Id == id);
            if (malls == null)
            {
                return NotFound();
            }

            return View(malls);
        }

        // POST: MallsAccess/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var malls = await _context.Malls.SingleOrDefaultAsync(m => m.Id == id);
            _context.Malls.Remove(malls);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MallsExists(int id)
        {
            return _context.Malls.Any(e => e.Id == id);
        }
    }
}
