using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollectMyNewFeedFacebook.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollectMyNewFeedFacebook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewFeedsController : ControllerBase
    {
        NewFeedCollectionContext NewFeedCollectionContext;
        public NewFeedsController(NewFeedCollectionContext NewFeedContext){
            this.NewFeedCollectionContext = NewFeedContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<NewFeed>> Get()
        {

            return this.NewFeedCollectionContext.NewFeeds.ToList();
        }

        [HttpPost]
        public ActionResult<bool> Post(){
            try
            {
                var newFeedOne = new NewFeed{ Name = "Test", Comment="Test Comment"};
                this.NewFeedCollectionContext.NewFeeds.Add(newFeedOne);
                this.NewFeedCollectionContext.SaveChanges();
                return true;
            }
            catch (System.Exception e)
            {
                
                throw;
            }
        }

    }
}
