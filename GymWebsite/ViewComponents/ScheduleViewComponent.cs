using GymWebsite.Data;
using Microsoft.AspNetCore.Mvc;

namespace GymWebsite.ViewComponents
{
    public class ScheduleViewComponent : ViewComponent
    {
        private FinalDbContext db;
        public ScheduleViewComponent(FinalDbContext _db)
        {
            db = _db;

        }
        public IViewComponentResult Invoke()
        {
            var data = db.Sliders.OrderByDescending(x => x).Take(3);
            return View(data);
        }
    }
}

