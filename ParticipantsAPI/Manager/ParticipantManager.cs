using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ParticipantsAPI.Entity;
using ParticipantsAPI.Repository;

namespace ParticipantsAPI.Manager
{
    public class ParticipantManager
    {
        IParticipantRepository participantRepository;
        public ParticipantManager()
        {
            participantRepository = new ParticipantRepository(new INTERNEntities4());
        }
        public AddParticipantOutput AddParticipant(AddParticipantInput objIp)
        {
            AddParticipantOutput rsOutput = new AddParticipantOutput();
            try
            {
                AddParticipantInput rsInput = new AddParticipantInput();
                rsInput.Email = objIp.Email;
                rsInput.MobileNumber = objIp.MobileNumber;
                rsInput.Firstname = objIp.Firstname;
                rsInput.Middlename = objIp.Middlename;
                rsInput.Lastname = objIp.Lastname;
                rsInput.Address1 = objIp.Address1;
                rsInput.Address2 = objIp.Address2;
                rsInput.Pincode = objIp.Pincode;
                rsInput.City = objIp.City;
                rsInput.State = objIp.State;
                rsInput.Country = objIp.Country;
                rsInput.Gender = objIp.Gender;
                rsInput.E_q = objIp.E_q;
                rsInput.Tpwd = objIp.Tpwd;

                AddParticipant_Result rsData = participantRepository.AddParticipant(rsInput);
                if (rsData != null)
                {
                    if ((bool)rsData.ParticipantAlreadyexist == false)
                    {
                        rsOutput.Message = "Participant added succesfully";
                        rsOutput.RespCode = HttpStatusCode.OK;
                    }
                    else
                    {
                        rsOutput.Message = "Failed to add Participant, Participant already exists";
                        rsOutput.RespCode = HttpStatusCode.OK;
                    }
                }
                else
                {
                    rsOutput.Message = "Failed to add particpant,Please try again";
                    rsOutput.RespCode = HttpStatusCode.NotFound;
                }
            }
            catch (Exception e)
            {
                rsOutput.Message = e.ToString();
                rsOutput.RespCode = HttpStatusCode.InternalServerError;
            }
            return rsOutput;
        }

        public List<GetAllP_Result> GetParticipantsList()
        {
            try
            {
                List<GetAllP_Result> rsData = participantRepository.GetParticipantsList();
                return rsData;
            }
            catch (Exception)
            {
                return new List<GetAllP_Result>();
            }
        }
        public List<CheckParticipant_Result> CheckParticipant(string UserName, string Password)
        {
            try
            {
                List<CheckParticipant_Result> rsData = participantRepository.CheckParticipant(UserName, Password);
                return rsData;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public GetParticipant_Result GetParticipant(string Email)
        {
            try
            {
                GetParticipant_Result rsData = participantRepository.GetParticipant(Email);
                return rsData;
            }
            catch (Exception)
            {
                return new GetParticipant_Result();
            }
        }

        public UpdateParticipantOutput UpdateParticipant(UpdateParticipantInput objIp)
        {
            UpdateParticipantOutput rsOutput = new UpdateParticipantOutput();
            try
            {
                Participant rsInput = new Participant();
                rsInput.Email = objIp.Email;
                rsInput.Mobilenumber = objIp.MobileNumber;
                rsInput.Firstname = objIp.Firstname;
                rsInput.Middlename = objIp.Middlename;
                rsInput.Lastname = objIp.Lastname;
                rsInput.Address1 = objIp.Address1;
                rsInput.Address2 = objIp.Address2;
                rsInput.Pincode = objIp.Pincode;
                rsInput.City = objIp.City;
                rsInput.State = objIp.State;
                rsInput.Country = objIp.Country;
                rsInput.Gender = objIp.Gender;
                rsInput.E_q = objIp.E_q;
                rsInput.Tpwd = objIp.Tpwd;

                UpdateParticipant_Result rsData = participantRepository.UpdateParticipant(rsInput);
                if (rsData != null)
                {
                    if ((bool)rsData.ParticipantAlreadyExists == false)
                    {
                        rsOutput.Message = "Participant Updated sucessfully";
                        rsOutput.RespCode = HttpStatusCode.OK;
                    }
                    else
                    {
                        rsOutput.Message = "Failed to Update details participant, Please try again!";
                        rsOutput.RespCode = HttpStatusCode.NotFound;
                    }
                }
                else
                {
                    rsOutput.Message = "Failed to update, Please try again";
                    rsOutput.RespCode = HttpStatusCode.NotFound;
                }
            }
            catch (Exception e)
            {
                rsOutput.Message = e.ToString();
                rsOutput.RespCode = HttpStatusCode.InternalServerError;
            }
            return rsOutput;
        }

    }
}