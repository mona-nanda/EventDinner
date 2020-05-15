using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleMaps.LocationServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NerdDinner.Data;
using NerdDinner.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NerdDinner.Controllers
{
    public class DinnerController : Controller
    {
        private readonly NerdDinnerContext _context;

        public DinnerController(NerdDinnerContext context)
        {
            _context = context;
        }
        //
        // HTTP-GET: /Dinners/

        public async Task<IActionResult> Index()
        {
            var dinners = from m in _context.BookDinner
                          select m;
            var rsvp = from n in _context.Rsvp
                       group n by n.DinnerId into g
                       select new
                       {
                           DinnerId = g.Key,
                           rsvps = g.Count()
                       };
            var rsvplist = new Dictionary<int, int>();
            foreach (var num in rsvp)
            {
                rsvplist.Add(num.DinnerId, num.rsvps);
            }
            ViewData["rsvp"] = rsvplist;
            return View(await dinners.ToListAsync());
        }
        //
        // HTTP-GET: /Dinners/Logged
        public async Task<IActionResult> Logged()
        {
            ViewData["session"] = HttpContext.Session.GetString("userId");
            var dinners = from m in _context.BookDinner
                          select m;
            var rsvp = from n in _context.Rsvp
                       group n by n.DinnerId into g
                       select new
                       {
                           DinnerId = g.Key,
                           rsvps = g.Count()
                       };
            var rsvplist = new Dictionary<int,int>();
            foreach (var num in rsvp)
            {
                rsvplist.Add(num.DinnerId, num.rsvps);
            }
            ViewData["rsvp"] = rsvplist;
            return View(await dinners.ToListAsync());
        }
        //
        // HTTP-GET: /Dinners/Details/2

        public async Task<IActionResult> Details(int? id)
        {
            ViewData["session"] = HttpContext.Session.GetString("userId");
            var uid = 0;
            if (ViewData["session"] != null)
            {
                uid = int.Parse(HttpContext.Session.GetString("Uid"));
            }
            if (id == null)
            {
                return View("NotFound");
            }

            var dinner = await _context.BookDinner
                .FirstOrDefaultAsync(m => m.DinnerId == id);
            var flag = await _context.BookDinner.Where(m => m.DinnerId == id &&
                m.CreatorId == uid).ToListAsync();
            ViewData["flag"] = flag.Capacity;
            if (dinner == null)
            {
                return View("NotFound");
            }
            return View(dinner);
        }
        // GET: Dinner/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["session"] = HttpContext.Session.GetString("userId");
            if (id == null)
            {
                return View("NotFound");
            }

            var dinner = await _context.BookDinner.FindAsync(id);
            if (dinner == null)
            {
                return View("NotFound");
            }
            return View(dinner);
        }

        // POST: Dinner/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DinnerId,Title,EventDate,Description,HostedBy,ContactPhone,Address,Country,Latitude,Longitude")] BookDinner dinner)
        {
            ViewData["session"] = HttpContext.Session.GetString("userId");
            if (id != dinner.DinnerId)
            {
                return View("NotFound");
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dinner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DinnerExists(dinner.DinnerId))
                    {
                        return View("NotFound");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Logged));
            }
            return View(dinner);
        }

        // GET: Dinner/Create
        public IActionResult Create()
        {
            ViewData["session"] = HttpContext.Session.GetString("userId");
            return View();
        }

        // POST: Dinner/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DinnerId,Title,EventDate,Description,HostedBy,ContactPhone,Address,Country,Latitude,Longitude")] BookDinner dinner)
        {
            ViewData["session"] = HttpContext.Session.GetString("userId");
            var uid = int.Parse(HttpContext.Session.GetString("Uid"));
            if (ModelState.IsValid)
            {   
                dinner.CreatorId = uid;
                _context.Add(dinner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Logged));
            }
            return View(dinner);
        }

        private bool DinnerExists(int id)
        {
            return _context.BookDinner.Any(e => e.DinnerId == id);
        }

        // POST: Dinner/Rsvp/4
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Rsvp([Bind("DinnerId")]Rsvp rsvp)
        {
            var session = HttpContext.Session.GetString("userId");
            rsvp.AttendeeName = session;
            ViewData["session"] = session;
            if (RsvpExists(session, rsvp.DinnerId))
            {
                return View("RsvpDone");
            }
            
            _context.Add(rsvp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new { id = rsvp.DinnerId });
        }
        private bool RsvpExists(string uname, int rid)
        {
            return _context.Rsvp.Any(e => e.AttendeeName == uname && e.DinnerId == rid);
        }
    }
}
