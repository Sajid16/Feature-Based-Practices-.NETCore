using Consume_REST_API.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using static Consume_REST_API.Helpers.ConstantClass;

namespace Consume_REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumeRestApiController : ControllerBase
    {
        private readonly IRestApiConsumeServices _restApiConsumeServices;
        private readonly ApiReturnObj returnObj;
        public ConsumeRestApiController(IRestApiConsumeServices restApiConsumeServices)
        {
            _restApiConsumeServices = restApiConsumeServices;
            returnObj = new ApiReturnObj();
        }

        [HttpGet]
        [Route("consume-rest-api")]
        //[Authorize]
        public IActionResult GetAllWithPaging()
        {
            try
            {
                var data = _restApiConsumeServices.ConsumeApi();
                returnObj.ApiData = data;
                //if (data.Any())
                //{
                //    returnObj.IsExecute = true;
                //    returnObj.ApiData = data;
                //    return Ok(returnObj);
                //}
                //else
                //{
                //    returnObj.IsExecute = false;
                //    returnObj.ApiData = null;
                //    return Ok(returnObj);
                //}
                return Ok(returnObj);
            }
            catch (Exception ex)
            {
                //returnObj.IsExecute = false;
                //returnObj.Message = ex.Message;
                //returnObj.ApiData = null;
                return Conflict(ex);
            }
        }
    }
}
