using ProjectTemplate.Core.Interface.Service;
using ProjectTemplate.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectTemplate.Web
{
    public partial class _Default : Page
    {
        public ISampleService _sampleService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                gvList.DataSource = _sampleService.GetAll().ToList();
                gvList.DataBind();
            }
        }
    }
}