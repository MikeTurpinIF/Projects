using Autodesk.Forge;
using Autodesk.Forge.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.Http;

namespace forgesample.Controllers
{
    public class BucketController : ApiController
    {
        [HttpPost]
        [Route("api/forge/bucket/delete")]
        public async Task DeleteBucket([FromBody]DeleteObjectModel objModel)
        {
            dynamic oauth = await OAuthController.GetInternalAsync();


            var apiInstance = new BucketsApi();
            var bucketKey = objModel.bucketKey;  // string | URL-encoded bucket key

            try
            {
                apiInstance.DeleteBucket(bucketKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BucketsApi.DeleteBucket: " + e.Message);
            }
        }

        /// <summary>
        /// Model for DeleteObject method
        /// </summary>
        public class DeleteObjectModel
        {
            public string bucketKey { get; set; }
        }
    }
}
