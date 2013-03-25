using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Threading;
public partial class Image : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Request.QueryString["name"];
        string language = this.Session["Language"] as string;
        string globalReName = "";
        globalReName = "CommonResource";
        if(string.IsNullOrEmpty(language))
        {
            language="zh-cn";
            
        }

        string culName = Thread.CurrentThread.CurrentCulture.Name.ToString();
        CultureInfo ci = new CultureInfo(language);
        string imgName = language.ToLower().Replace("-","_");
        System.Drawing.Bitmap img = (System.Drawing.Bitmap)GetGlobalResourceObject(globalReName,imgName);
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        if (img!=null)
        {
            
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Response.ClearContent();
            Response.ContentType = "image/jpeg";
            Response.BinaryWrite(ms.ToArray());

            
        }
        img.Dispose();
        ms.Dispose();
        ms.Flush();

        
    }
}
