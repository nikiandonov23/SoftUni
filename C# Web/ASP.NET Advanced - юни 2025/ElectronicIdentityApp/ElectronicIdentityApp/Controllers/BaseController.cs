﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicIdentityApp.Web.Controllers
{
    
    public abstract class BaseController : Controller
    {



        protected bool IsUserAuthenticated()
        {
            //Ako identiti e null return false
            return this.User.Identity?.IsAuthenticated ?? false;
        }


        protected string? GetUserId()
        {
            if (IsUserAuthenticated())
            {
                //Ako e Autenticated returns userId
                return User.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            return null;
        }

    }
    //DA NE ZABRAVQ DA NASLEDQ BASE CONTROLLER-a V OSTANALITE KONTROLERI 
}
