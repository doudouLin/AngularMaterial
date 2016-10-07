using MVCAngular1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVCAngular1.DAL;
using System.Linq;

namespace MVCAngular1.Controllers.Api
{
    public class BoardController : Controller
    {
        private BoardContext db = new BoardContext();

        [Route("/api/data")]
        public JsonResult GetData()
        {
            List<Board> data = db.data.OrderBy(s => s.Zimmernummer).ToList();

            List<string> groups = new List<string>();
            foreach (var p in data)
            {
                if (groups.Where(s => groups.Contains(p.Zimmernummer)).Count() < 1)
                {
                    p.GroupSize = data.Where(s => s.Zimmernummer == p.Zimmernummer).Count();
                    groups.Add(p.Zimmernummer);
                }
            }

            return Json(data);
        }
    }
}
