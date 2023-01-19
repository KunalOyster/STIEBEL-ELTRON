using System.Runtime.InteropServices;
using UnityEngine;

/// <summary>
/// This script deals with all the URL related things
/// </summary>
public class URLs : MonoBehaviour
{

    public string download_Pdf;
    public string redirectLink;


    



    public void Dialnumber1()
    {
        Application.OpenURL("tel://[2067480909]");
       
    }

    public void Dialnumber2()
    {
        Application.OpenURL("tel://[18002667155]");
    }



//    public void RedirectLink()
//    {
//#if (UNITY_WEBGL)
//        Application.OpenURL(redirectLink);
//#endif
//    }

    public void DownloadPdf()
    {
#if PLATFORM_ANDROID
        Application.OpenURL(download_Pdf);
#else
        Application.OpenURL(download_Pdf);
#endif
    }

    
}
