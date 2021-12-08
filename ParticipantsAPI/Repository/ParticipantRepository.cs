using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParticipantsAPI.Entity;



namespace ParticipantsAPI.Repository
{
    public interface IParticipantRepository : IDisposable
    {
        AddParticipant_Result AddParticipant(AddParticipantInput objIp);
        List<GetAllP_Result> GetParticipantsList();
        GetParticipant_Result GetParticipant(string Email);
        UpdateParticipant_Result UpdateParticipant(Participant objIp);
        List<CheckParticipant_Result> CheckParticipant(string UserName, string Password);
    }
    public class ParticipantRepository : IParticipantRepository,IDisposable
    {
        private INTERNEntities4 context;
        public ParticipantRepository(INTERNEntities4 context)
        {
            this.context = context;
        }
        public AddParticipant_Result AddParticipant(AddParticipantInput objIP)
        {
            try
            {
                AddParticipant_Result rsData = context.AddParticipant(
                    objIP.Email,
                    objIP.MobileNumber,
                    objIP.Firstname,
                    objIP.Middlename,
                    objIP.Lastname,
                    objIP.Address1,
                    objIP.Address2,
                    objIP.Pincode,
                    objIP.City,
                    objIP.State,
                    objIP.Country,
                    objIP.Gender,
                    objIP.E_q,
                    objIP.Tpwd).FirstOrDefault();
                return rsData;
            }
            catch (Exception)
            {
                return new AddParticipant_Result();
            }
        }
       public List<GetAllP_Result> GetParticipantsList()
        {
            try
            {
                List<GetAllP_Result> rsData = context.GetAllP().ToList();
                return rsData;
            }
            catch(Exception)
            {
                return new List<GetAllP_Result>();
            }
        }
        public List<CheckParticipant_Result> CheckParticipant(string UserName, string Password)
        {
            try
            {
                List<CheckParticipant_Result> rsData = context.CheckParticipant(UserName, Password).ToList();
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
                GetParticipant_Result rsData = context.GetParticipant(Email).FirstOrDefault();
                return rsData;
            }
            catch (Exception)
            {
                return new GetParticipant_Result();
            }
        }
        public UpdateParticipant_Result UpdateParticipant(Participant objIP)
        {
            try
            {
                UpdateParticipant_Result rsData= context.UpdateParticipant(
                    objIP.Email,
                    objIP.Mobilenumber,
                    objIP.Firstname,
                    objIP.Middlename,
                    objIP.Lastname,
                    objIP.Address1,
                    objIP.Address2,
                    objIP.Pincode,
                    objIP.City,
                    objIP.State,
                    objIP.Country,
                    objIP.Gender,
                    objIP.E_q,
                    objIP.Tpwd).FirstOrDefault();
                return rsData;
            }
            catch (Exception)
            {
                return new UpdateParticipant_Result();
            }
        }
        public void Save()
        {
            this.context.SaveChangesAsync();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}