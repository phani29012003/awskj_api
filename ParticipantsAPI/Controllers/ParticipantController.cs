using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ParticipantsAPI.Entity;
using ParticipantsAPI.Manager;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Web.Http.Cors;
namespace ParticipantsAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ParticipantController : ApiController
    {
        ParticipantManager participantManager;
        public ParticipantController()
        {
            participantManager = new ParticipantManager();
        }
        [HttpPost]
        [Route("AddParticipant")]
        public async Task<IHttpActionResult> AddParticipant(AddParticipantInput model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Regex.IsMatch(model.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                    bool isMobileNumber =Regex.IsMatch(model.MobileNumber,"[0-9]+");
                    
                    bool isTpwd = Regex.IsMatch(model.Tpwd, "[0-9]+");
                    if (!isEmail)
                    {
                        return Content(HttpStatusCode.OK, "Please enter a valid Email address");
                    }
                    else if(!isMobileNumber || model.MobileNumber.Length != 10)
                    {
                        return Content(HttpStatusCode.OK, "Please enter valid mobile number");
                    }
                    else if(!isTpwd || model.Tpwd.Length != 4)
                    {
                        return Content(HttpStatusCode.OK, "Please enter valid Transaction pin");
                    }
                    else
                    {
                        AddParticipantOutput rsData = await Task.FromResult(participantManager.AddParticipant(model));

                        return Content(rsData.RespCode, rsData.Message);
                    }
                }
                else
                {
                    return Content(HttpStatusCode.OK, "Please fill all the mandatory fields");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        [Route("GetParticipantsList")]
        public async Task<IHttpActionResult> GetParticipantsList()
        {
            try
            {
                Console.WriteLine(Task.FromResult(participantManager.GetParticipantsList()));
                return Ok(await Task.FromResult(participantManager.GetParticipantsList()));
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        [Route("CheckParticipant")]
        public async Task<IHttpActionResult> CheckParticipant(CheckParticipantInput model)
        {
            try
            {
                return Ok(await Task.FromResult(participantManager.CheckParticipant(model.UserName, model.Password)));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        [Route("GetParticipant")]
        public async Task<IHttpActionResult>GetParticipant(GetParticipantInput model)
        {
            try
            {
                return Ok(await Task.FromResult(participantManager.GetParticipant(model.Email)));
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        

        [HttpPut]
        [Route("UpdateParticipant")]
        public async Task<IHttpActionResult>UpdateParticipant(UpdateParticipantInput model)
        {
            try
            {
                UpdateParticipantOutput rsData = await Task.FromResult(participantManager.UpdateParticipant(model));
                return Content(rsData.RespCode, rsData);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
