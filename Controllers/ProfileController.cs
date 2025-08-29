using askfm.Data;
using askfm.Interfaces;
using askfm.Models;
using askfm.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace askfm.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IUser _userService;
        private readonly IComment _commentService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileController(ILogger<ProfileController> logger, IUser userService, UserManager<ApplicationUser> userManager, IComment commentService)
        {
            _logger = logger;
            _userService = userService;
            _userManager = userManager;
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string userId)
        {
            var Result = await this._userService.GetById(userId);

            return View(Result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment([FromBody] CommentModel comment)
        {
            try
            {
                var UserFound = await _userManager.GetUserAsync(User);
                comment.FromUserId = UserFound?.Id;
                await _commentService.Add(comment);
                return Json(new
                {
                    Success = true,
                    Data = comment
                });
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Error = ex.Message });
            }
        }
    }
}
