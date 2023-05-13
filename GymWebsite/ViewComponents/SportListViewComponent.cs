using GymWebsite.Data;
using Microsoft.AspNetCore.Mvc;

namespace GymWebsite.ViewComponents
{
    public class SportListViewComponent:ViewComponent
    {
        private FinalDbContext db;
        public SportListViewComponent(FinalDbContext _db )
        {
            db = _db;
            
        }
        public IViewComponentResult Invoke()
        {
            var data = db.SportLists.OrderByDescending(x => x.CreationDate).Take(4);
            return View(data);
        }
    }
}
