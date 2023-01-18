using UnityEngine;

/// <summary>
/// This script deals with all the URL related things
/// </summary>
public class URLs : MonoBehaviour
{

    public string download_Pdf;
   
    

    public void Dialnumber1()
    {
        Application.OpenURL("tel://[2067480909]");
       
    }

    public void Dialnumber2()
    {
        Application.OpenURL("tel://[18002667155]");
    }



    public void DownloadPdf()
    {
#if PLATFORM_ANDROID
        Application.OpenURL(download_Pdf);
#else
        Application.OpenURL(download_Pdf);
#endif
    }

    
}
