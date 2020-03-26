using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Customizations.ViewComponents
{
    public class PaginationBarViewComponent : ViewComponent
    {
        //public IViewComponentResult Invoke(CourseListViewModel model)
        public IViewComponentResult Invoke(IPaginationInfo model)
        {
            //Il numero di pagina corrente
            //Il numero di risultati totali
            //Il numero di risultati per pagina
            //Search, OrderBy e Ascending
            return View(model);
        }
    }
}