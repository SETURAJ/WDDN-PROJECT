﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.SRC
{
    public partial class user : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindCartNumber();
            if (Session["username"] != null)
            {
                btnlogout.Visible = true;
                btnsignin.Visible = false;
                //lblsuc.Text = "Login Success, Welcome" + Session["username"].ToString();
            }
            else
            {
                btnlogout.Visible = false;
                btnsignin.Visible = true;
                Response.Redirect("~/SRC/home.aspx");
            }
        }
        protected void butlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SRC/home.aspx");
            Session["username"] = null;
        }

        protected void btnsignin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SRC/signIn.aspx");
        }
        public void BindCartNumber()
        {
            if (Request.Cookies["CartPID"] != null)
            {
                string CookiePID = Request.Cookies["CartPID"].Value.Split('=')[1];
                string[] ProductArray = CookiePID.Split(',');
                int ProductCount = ProductArray.Length;
                //pCount.InnerText = ProductCount.ToString();
            }
            else
            {
                //pCount.InnerText = 0.ToString();
            }
        }
    }
}