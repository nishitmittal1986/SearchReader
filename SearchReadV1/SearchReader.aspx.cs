using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SearchReadV1
{
    public partial class SearchReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void RunBtn_Click(object sender, EventArgs e)
        {
            string GoogleAdd = "https://www.google.com.au/search";
            string BingAdd = "https://www.bing.com/search";
            string SearchThis = SearchTxt.Text;

            string uriString = GoogleRdb.Checked ? GoogleAdd : BingAdd;  
                     

            WebClient webClient = new WebClient();

            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("q", SearchThis);

            webClient.QueryString.Add(nameValueCollection);
            ShowLbl.Text = webClient.DownloadString(uriString);
        }
    }
}