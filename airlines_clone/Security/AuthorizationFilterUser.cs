﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace airlines_clone.Security
{
    public class AuthorizationFilterUser : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true)
            || filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true))
            {
                // Don't check for authorization as AllowAnonymous filter is applied to the action or controller
                return;
            }
            // Check for authorization
            if (HttpContext.Current.Session["user"] == null)
            {
                filterContext.Result = filterContext.Result =
                new HttpUnauthorizedResult();

            }
        }
    }
}
