using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Globalization;
/// <summary>
/// Summary description for PageBase
/// </summary>
public class PageBase:System.Web.UI.Page
{
	public PageBase()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    protected override void InitializeCulture()
    {
        string lanName = Session["Language"] as string;
        if (!string.IsNullOrEmpty(lanName))
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lanName);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lanName);
        }
        base.InitializeCulture();
    }

}
