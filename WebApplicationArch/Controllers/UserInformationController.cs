﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntity;
using BusinessServices;
using Marlabs.Tool.Business.Core;

namespace WebApplicationArch.Controllers
{
    [RoutePrefix("UserInfo")]
    public class UserInformationController : ApiController
    {

        private readonly IUserInfoServices _userInfoServices;

        #region Public Constructor

        /// <summary>
        /// Public constructor to initialize user service instance
        /// </summary>
        public UserInformationController()
        {
            _userInfoServices = new UserInformationServices();
        }

        #endregion


        [HttpGet]
        [Route("{userId}")]
        public HttpResponseMessage Get(int userId)
        {
            var userInformationList = _userInfoServices.getUserInformationByUserId(userId);
            if (userInformationList != null)
                return Request.CreateResponse(HttpStatusCode.OK, userInformationList);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No userinformation List Available");
        }
    }
}
