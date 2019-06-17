using SS.Annotator.Models;
using System;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SS.Annotator.Controllers
{
    public class TextResourcesController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        // GET: TextResources
        public async Task<ActionResult> Index()
        {
            return View(await _db.TextResources.ToListAsync());
        }

        // GET: TextResources/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var textResource = await _db.TextResources.FindAsync(id);
            if (textResource == null)
            {
                return HttpNotFound();
            }
            return View(textResource);
        }

        // GET: TextResources/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TextResources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TextResourceId,Text,AnnotationMode,Language")] TextResource textResource)
        {
            if (ModelState.IsValid)
            {
                textResource.TextResourceId = Guid.NewGuid();
                _db.TextResources.Add(textResource);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(textResource);
        }

        // GET: TextResources/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TextResource textResource = await _db.TextResources.FindAsync(id);
            if (textResource == null)
            {
                return HttpNotFound();
            }
            return View(textResource);
        }

        // POST: TextResources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TextResourceId,Text,AnnotationMode,Language")] TextResource textResource)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(textResource).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(textResource);
        }

        // GET: TextResources/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TextResource textResource = await _db.TextResources.FindAsync(id);
            if (textResource == null)
            {
                return HttpNotFound();
            }
            return View(textResource);
        }

        // POST: TextResources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            TextResource textResource = await _db.TextResources.FindAsync(id);
            _db.TextResources.Remove(textResource);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
