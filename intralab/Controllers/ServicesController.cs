using System.Web.Mvc;

namespace intralab.Controllers
{
    public class ServicesController : Controller
    {   
        //Беспроводные сети
        public ActionResult Wireless()
        {
            return View();
        }

        //Подбор, приобретение, запуск в эксплуатацию оборудования
        public ActionResult Equipment()
        {
            return View();
        }

        //Проектирование и организация проводных локальных сетей
        public ActionResult LAN()
        {
            return View();
        }

        //IP-телефония
        public ActionResult IPtelephony()
        {
            return View();
        }

        //Мониторинг деятельности пользователей
        public ActionResult UserMonitoring()
        {
            return View();
        }

        //Видеоконференцсвязь
        public ActionResult Videoconferencing()
        {
            return View();
        }

        //Системы видеонаблюдения
        public ActionResult Videosurveillance()
        {
            return View();
        }

        //Разработка WEB-сайтов
        public ActionResult Develop()
        {
            return View();
        }

        //Консультирование, сопровождение
        public ActionResult Support()
        {
            return View();
        }
    }
}