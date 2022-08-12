using Microsoft.AspNetCore.Mvc;

namespace _08102022_Egitim.Controllers
{
    public class SolidPrinciples : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //SingleResponsibility
        public void TurnRight()
        {
            Ok("TurnRight");
        }
        public void TurnLeft()
        {
            Ok("TurnLeft");
        }
        public void GoStraight()
        {
            Ok("GoStraight");
        }
        public void GoPark()
        {
            TurnRight();
            GoStraight();
            GoStraight();
            TurnLeft();
            GoStraight();
        }
    }
}
