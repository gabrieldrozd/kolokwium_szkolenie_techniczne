using kolokwium.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kolokwium
{
    public partial class Rozgrywki : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitDruzyny();
                InitTypyRozgrywek();
            }
        }

        protected void InitDruzyny()
        {
            ApiMethods api = new ApiMethods();
            var druzyny = api.GetDruzyna();
            ddlDruzyna1.DataSource = druzyny;
            ddlDruzyna1.DataTextField = "Name";
            ddlDruzyna1.DataValueField = "Id";
            ddlDruzyna1.DataBind();

            ddlDruzyna2.DataSource = druzyny;
            ddlDruzyna2.DataTextField = "Name";
            ddlDruzyna2.DataValueField = "Id";
            ddlDruzyna2.DataBind();
        }

        protected void InitTypyRozgrywek()
        {
            ApiMethods api = new ApiMethods();
            var typyRozgrywek = api.GetTypRozgrywek();
            ddlTypRozgrywek.DataSource = typyRozgrywek;
            ddlTypRozgrywek.DataTextField = "Name";
            ddlTypRozgrywek.DataValueField = "Id";
            ddlTypRozgrywek.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}