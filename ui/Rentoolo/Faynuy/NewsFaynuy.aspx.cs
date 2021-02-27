using Rentoolo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rentoolo.Faynuy
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Rentoolo.Model.NewsFaynuy> ListNews;

        protected void Page_Load(object sender, EventArgs e)
        {
            ListNews = DataHelperFaynuy.GetActiveNews();
        }
    }
}