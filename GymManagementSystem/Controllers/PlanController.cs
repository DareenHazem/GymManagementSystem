using GymManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagementSystem.Controllers
{
    public class PlanController : Controller
    {

        private GymDbContext dbcontext = new GymDbContext();

        public async Task<IActionResult> Index()
        {
            var plans = await dbcontext.Plans.ToListAsync(); // Select * From table plans
            return View(plans); // From controller to view
        }


        public IActionResult IndexTest()
        {
            return View();
        }
    }
}
