﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Quanlytrotdmune.Models;
namespace Quanlytrotdmune.Controllers
{
    public class UserController : Controller
    {
        QUANLYTROEntities1 ql=new QUANLYTROEntities1();
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            try {
                
                if(ModelState.IsValid)
                {
                    USERTRO usertro=new USERTRO();
                    usertro.address = user.address;
                    usertro.email = user.email;
                    usertro.full_name = user.full_name;
                    usertro.phone = user.phone;
                    usertro.password= user.password;
                    usertro.password =GetMD5(user.password);
                    ql.USERTROes.Add(usertro);   
                    ql.SaveChanges();
                    return View();
                }            
            }
            catch(Exception)
            {
                return View();
            }
           return View();
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
    }


}