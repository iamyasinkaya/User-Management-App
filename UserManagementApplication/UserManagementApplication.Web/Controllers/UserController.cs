using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManagementApplication.Application.FluentValidation;
using UserManagementApplication.Application.Interfaces;
using UserManagementApplication.Application.Models;

namespace UserManagementApplication.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #region List Method

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _userService.GetAll());
        }
        #endregion

        #region Create Method
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserModel model)
        {
            UserValidator userValidator = new UserValidator();

            var result = userValidator.Validate(model);

            if (result.IsValid)
            {
                await _userService.CreateAsync(model);
            }

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Details Method


        public async Task<IActionResult> Details(UserModel model)
        {
            var entity = await _userService.GetByIdAsync(model);
            return View(entity);
        }

        #endregion

        #region Home

        public async Task<IActionResult> Home()
        {
            return View(await _userService.GetAll());
        }

        #endregion

        [HttpGet]
        public async Task<IActionResult> Delete(UserModel userModel,int Id)
        {
            var entity = await _userService.GetByIdAsync(userModel);

            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                await _userService.DeleteAsync(userModel);
                
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(UserModel userModel, int Id)
        {
            var entity = await _userService.GetByIdAsync(userModel);

            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                await _userService.UpdateAsync(userModel);

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
