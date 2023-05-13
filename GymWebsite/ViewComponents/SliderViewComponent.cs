using GymWebsite.Data;
using Microsoft.AspNetCore.Mvc;

namespace GymWebsite.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private FinalDbContext db;
        public SliderViewComponent(FinalDbContext _db)
        {
            db = _db;

        }
        public IViewComponentResult Invoke()
        {
            var data = db.Sliders.OrderByDescending(x => x.CreationDate).Take(3);
            return View(data);
        }
    }
}
