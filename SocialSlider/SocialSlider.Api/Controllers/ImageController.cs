using SocialSlider.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialSlider.Api.Controllers
{
    public class ImageController : ApiController
    {
        private readonly IImageServant ImageServant;

        //temporary
        private readonly IGoogleDriveServant GoogleDriveServant;

        public ImageController(IImageServant imageServant, IGoogleDriveServant googleDriveServant)
        {
            ImageServant = imageServant;
            GoogleDriveServant = googleDriveServant;
        }

        public HttpResponseMessage GetTest()
        {
            GoogleDriveServant.DriveTest();

            return CreateApiResponse(statusCode: HttpStatusCode.NoContent);
        }

        protected virtual HttpResponseMessage CreateApiResponse(HttpStatusCode statusCode, object content = null, Uri locationUrl = null)
        {
            var response = ControllerContext.Request.CreateResponse(statusCode, content);

            if (locationUrl != null)
                response.Headers.Location = locationUrl;

            return response;
        }
    }
}
