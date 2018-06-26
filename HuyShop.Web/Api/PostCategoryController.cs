using HuyShop.Service;
using HuyShop.Web.Infrastructure.Core;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace HuyShop.Web.Api
{
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService)
            : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        public HttpResponseMessage Create(HttpRequestMessage request, IPostCategoryService postCategoryService)
        {

           
        }

    }
}