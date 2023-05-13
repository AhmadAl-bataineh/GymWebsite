using GymWebsite.Data;
using Microsoft.AspNetCore.Mvc;

namespace GymWebsite.ViewComponents
{
    public class TrainerViewComponent : ViewComponent
    {
        private FinalDbContext db;
        public TrainerViewComponent(FinalDbContext _db)
        {
            db = _db;

        }
        public IViewComponentResult Invoke()
        {
            var data = db.Trainers.OrderByDescending(x => x.TrainerName).Take(4);
            return View(data);

        }
    }
}