using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.API;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitBookTypes();
            }
        }

        protected void InitBookTypes()
        {
            Kolokwium_API api = new Kolokwium_API();
            var bookTypes = api.GetBookTypes();
            ddlBookType.DataSource = bookTypes;
            ddlBookType.DataTextField = "Name";
            ddlBookType.DataValueField = "Id";
            ddlBookType.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Kolokwium_API api = new Kolokwium_API();

            var book = new Book
            {
                Description = txtDescription.Text,
                Name = txtName.Text,
                TypeId = new BookType { Id = Convert.ToInt32(ddlBookType.DataValueField), Name }
                ReleaseDate = Convert.ToInt32(txtReleaseDate.Text),
                NumberOfPages = Convert.ToInt32(txtNumberOfPages.Text)
            };

            api.AddBook(book);
        }

        /*
         na 3.0 tylko nhibernate konfiguracja, modele i prosty layout
        na 4.0 dropdownlist i to api z metodami, ale nie iwem czy na 3.0 czy na 4.0
         */
    }
}