using Microsoft.AspNetCore.Mvc;
using report_project.Models;

namespace report_project.Controllers
{
    public class ReportController : Controller
    {
        private readonly Context _context;
        public ReportController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var value = _context.reports.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult add()
        {

            return View();
        }
        [HttpPost]
        public ActionResult add(report p)
        {

            _context.reports.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Detail(int id)
        {
            var value = _context.reports.Find(id);

            return View(value);
        }
        public ActionResult reportUpdate(report r)
        {
            var value = _context.reports.Find(r.reportID);
            value.FinishDate = r.FinishDate;
            value.StartDate = r.StartDate;
            value.reportTitle = r.reportTitle; 
            value.ReportSubject = r.ReportSubject;
            value.Employee=r.Employee;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult reportDelete(int id)
        {
            var value = _context.reports.Find(id);
            _context.reports.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
