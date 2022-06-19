using Lab3_HyNhatHao.DTOs;
using Lab3_HyNhatHao.Models;
using System.Linq;
using System.Web.Http;

using Microsoft.AspNet.Identity;

using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Lab3_HyNhatHao.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");
            var Folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId
            };

            _dbContext.Followings.Add(Folowing);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}