using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantsAPI.Models
{
    public partial class Participant
    {
        public string Email { get; set; }
        public string Mobilenumber { get; set; }
        public string MobileNumber { get; internal set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string E_q { get; set; }
        public string Tpwd { get; set; }
    }
    public  class AddParticipantOutput
    {
       public string Message { get; set; }
       public string RespCode { get; set; }
    }
    public class UpdateParticipantOutput
    {
        public string Message { get; set; }
        public string RespCode { get; set; }
    }
    public  class AddParticipantInput
    {
        public string Email { get; set; }
        public string Mobilenumber { get; set; }
        public string MobileNumber { get; internal set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string E_q { get; set; }
        public string Tpwd { get; set; }
    }
    public  class UpdateParticipantInput
    {
        public string Email { get; set; }
        public string Mobilenumber { get; set; }
        public string MobileNumber { get; internal set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string E_q { get; set; }
        public string Tpwd { get; set; }
    }
    public class GetParticipantInput
    {
        public string Email { get; set; }
    }
    public class CheckParticipantInput
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
