using Microsoft.AspNetCore.Mvc;
using UploadImageInAsp.netCore.Models;
using UploadImageInAsp.netCore.Repository.IRepository;

namespace UploadImageInAsp.netCore.Controllers
{
    public class UserController : Controller
    {
        #region Constractor

        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion
        public IActionResult Index()
        {
            List<User> users = _unitOfWork.User.GetAll().ToList();
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
    }
}
