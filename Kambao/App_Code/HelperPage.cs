using System.Web.Mvc;
using System.Web.WebPages;

namespace Kambao.App_Code
{
    public class HelperPage : System.Web.WebPages.HelperPage
    {
        public static new HtmlHelper Html
        {
            get { return ((System.Web.Mvc.WebViewPage)WebPageContext.Current.Page).Html; }
        }
    }
}