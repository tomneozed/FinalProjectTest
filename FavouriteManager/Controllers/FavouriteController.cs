using FavouriteManager.Persistence.entity;
using FavouriteManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace FavouriteManager.Controllers
{
    [ApiController]
    [Route("api/favorite")]
    public class FavouriteController : ControllerBase
    {
        private readonly IFavouriteService _favouriteService;
        public FavouriteController(IFavouriteService favouriteService)
        {
            _favouriteService = favouriteService;
            //some changes
        }
        [HttpGet("{id}")]
        public Favourite Test(int id)
        {
            return _favouriteService.Test(id);
        }

        
    }
}