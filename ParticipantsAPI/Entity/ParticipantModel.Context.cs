﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParticipantsAPI.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class INTERNEntities4 : DbContext
    {
        public INTERNEntities4()
            : base("name=INTERNEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
    
        public virtual ObjectResult<AddParticipant_Result> AddParticipant(string email, string mobilenumber, string firstname, string middlename, string lastname, string address1, string address2, string pincode, string city, string state, string country, string gender, string e_q, string tpwd)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var mobilenumberParameter = mobilenumber != null ?
                new ObjectParameter("Mobilenumber", mobilenumber) :
                new ObjectParameter("Mobilenumber", typeof(string));
    
            var firstnameParameter = firstname != null ?
                new ObjectParameter("Firstname", firstname) :
                new ObjectParameter("Firstname", typeof(string));
    
            var middlenameParameter = middlename != null ?
                new ObjectParameter("Middlename", middlename) :
                new ObjectParameter("Middlename", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("Lastname", lastname) :
                new ObjectParameter("Lastname", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var pincodeParameter = pincode != null ?
                new ObjectParameter("Pincode", pincode) :
                new ObjectParameter("Pincode", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var e_qParameter = e_q != null ?
                new ObjectParameter("E_q", e_q) :
                new ObjectParameter("E_q", typeof(string));
    
            var tpwdParameter = tpwd != null ?
                new ObjectParameter("Tpwd", tpwd) :
                new ObjectParameter("Tpwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddParticipant_Result>("AddParticipant", emailParameter, mobilenumberParameter, firstnameParameter, middlenameParameter, lastnameParameter, address1Parameter, address2Parameter, pincodeParameter, cityParameter, stateParameter, countryParameter, genderParameter, e_qParameter, tpwdParameter);
        }
    
        public virtual ObjectResult<CheckParticipant_Result> CheckParticipant(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CheckParticipant_Result>("CheckParticipant", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<GetAllP_Result> GetAllP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllP_Result>("GetAllP");
        }
    
        public virtual ObjectResult<GetParticipant_Result> GetParticipant(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetParticipant_Result>("GetParticipant", emailParameter);
        }
    
        public virtual ObjectResult<UpdateParticipant_Result> UpdateParticipant(string email, string mobilenumber, string firstname, string middlename, string lastname, string address1, string address2, string pincode, string city, string state, string country, string gender, string e_q, string tpwd)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var mobilenumberParameter = mobilenumber != null ?
                new ObjectParameter("Mobilenumber", mobilenumber) :
                new ObjectParameter("Mobilenumber", typeof(string));
    
            var firstnameParameter = firstname != null ?
                new ObjectParameter("Firstname", firstname) :
                new ObjectParameter("Firstname", typeof(string));
    
            var middlenameParameter = middlename != null ?
                new ObjectParameter("Middlename", middlename) :
                new ObjectParameter("Middlename", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("Lastname", lastname) :
                new ObjectParameter("Lastname", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var pincodeParameter = pincode != null ?
                new ObjectParameter("Pincode", pincode) :
                new ObjectParameter("Pincode", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var e_qParameter = e_q != null ?
                new ObjectParameter("E_q", e_q) :
                new ObjectParameter("E_q", typeof(string));
    
            var tpwdParameter = tpwd != null ?
                new ObjectParameter("Tpwd", tpwd) :
                new ObjectParameter("Tpwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateParticipant_Result>("UpdateParticipant", emailParameter, mobilenumberParameter, firstnameParameter, middlenameParameter, lastnameParameter, address1Parameter, address2Parameter, pincodeParameter, cityParameter, stateParameter, countryParameter, genderParameter, e_qParameter, tpwdParameter);
        }
    }
}
