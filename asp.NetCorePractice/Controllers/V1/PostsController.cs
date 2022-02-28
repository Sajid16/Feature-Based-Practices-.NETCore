using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebApi.Contracts.V1;
using WebApi.Helpers.V1;
using WebApi.Models;
using WebApi.Services.Abstractions;

namespace WebApi.Controllers
{
    //[Route(ApiRoutes.Posts.PostBase)]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ResponseObject _responseObject;
        private readonly IPostServices _postServices;
        public PostsController(IPostServices postServices)
        {
            _responseObject = new ResponseObject();
            _postServices = postServices;
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        //[HttpGet]
        //[Route("get-all")]
        public IActionResult GetAll()
        {
            try
            {
                var response = _postServices.GetAll(out string error);
                if (response.Count > 0)
                {
                    _responseObject.apiData = response;
                    _responseObject.message = "Success";
                    _responseObject.isExexute = true;
                    return Ok(_responseObject);
                }
                else
                {
                    _responseObject.apiData = response;
                    _responseObject.message = error;
                    _responseObject.isExexute = false;
                    return Conflict(_responseObject);
                }
            }
            catch (System.Exception exception)
            {
                _responseObject.message = exception.ToString();
                _responseObject.isExexute = false;
                return Conflict(_responseObject);
            } 
        }

        [HttpGet(ApiRoutes.Posts.GetById)]
        public IActionResult GetById(string postId)
        {
            try
            {
                var response = _postServices.GetById(postId, out string error);
                if (response != null)
                {
                    _responseObject.apiData = response;
                    _responseObject.message = "Success";
                    _responseObject.isExexute = true;
                    return Ok(_responseObject);
                }
                else
                {
                    _responseObject.apiData = response;
                    _responseObject.message = error;
                    _responseObject.isExexute = false;
                    return NotFound(_responseObject);
                }
            }
            catch (System.Exception exception)
            {
                _responseObject.message = exception.ToString();
                _responseObject.isExexute = false;
                return Conflict(_responseObject);
            }
        }


        [HttpPost(ApiRoutes.Posts.Create)]
        //[Route("create")]
        public IActionResult Create([FromBody] Posts model)
        {
            try
            {
                var response = _postServices.Add(model, out string error);
                if (response)
                {
                    _responseObject.apiData = response;
                    _responseObject.message = "Success";
                    _responseObject.isExexute = true;
                    return Ok(_responseObject);
                }
                else
                {
                    _responseObject.apiData = response;
                    _responseObject.message = error;
                    _responseObject.isExexute = false;
                    return Conflict(_responseObject);
                }
            }
            catch (System.Exception exception)
            {
                _responseObject.message = exception.ToString();
                _responseObject.isExexute = false;
                return Conflict(_responseObject);
            }
        }

        [HttpPost(ApiRoutes.Posts.Update)]
        //[Route("create")]
        public IActionResult Update(string postId, [FromBody] Posts model)
        {
            try
            {
                var response = _postServices.Update(postId, model, out string error);
                if (response)
                {
                    _responseObject.message = "Success";
                    _responseObject.isExexute = response;
                    return Ok(_responseObject);
                }
                else
                {
                    _responseObject.message = error;
                    _responseObject.isExexute = response;
                    return NotFound(_responseObject);
                }
            }
            catch (System.Exception exception)
            {
                _responseObject.message = exception.ToString();
                _responseObject.isExexute = false;
                return Conflict(_responseObject);
            }
        }

        [HttpGet(ApiRoutes.Posts.Delete)]
        public IActionResult Delete(string postId)
        {
            try
            {
                var response = _postServices.Delete(postId, out string error);
                if (response)
                {
                    _responseObject.message = "Success";
                    _responseObject.isExexute = response;
                    return Ok(_responseObject);
                }
                else
                {
                    _responseObject.message = error;
                    _responseObject.isExexute = response;
                    return NotFound(_responseObject);
                }
            }
            catch (System.Exception exception)
            {
                _responseObject.message = exception.ToString();
                _responseObject.isExexute = false;
                return Conflict(_responseObject);
            }
        }
    }
}
