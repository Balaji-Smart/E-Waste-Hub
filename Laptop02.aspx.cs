﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EWasteHub
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName=="ViewDetails")
            {
                Response.Redirect("ViewDetails.aspx?id="+e.CommandArgument.ToString()); 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}