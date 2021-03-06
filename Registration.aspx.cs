﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void vgRegistration_CreatingUser(object sender, LoginCancelEventArgs e)
    {
        //Find the textbox control UserName.
        TextBox username = vgRegistration.CreateUserStep.ContentTemplateContainer.FindControl("UserName") as TextBox;

        //Make sure the role dosnt exsist
        if (!Roles.RoleExists("Client"))
        {
            //Create a new Roll called Client
            Roles.CreateRole("Client");
        }
        

        Roles.AddUserToRole(username.Text, "Client");
    }
}