
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script deals with all the things related to the UI
/// </summary>

public class UI_Manager : MonoBehaviour
{

    [Header("feartures")]
    public GameObject features;
    public GameObject features_Pnael_Close;
    //Features btn
    public Sprite features_Btn_W, features_Btn_R;
    public Button features_Btn;

    [Header("Functionality")]
    public GameObject functionality;
    //Functionality btn
    public Sprite functionality_Btn_W, functionality_Btn_R;
    public Button functionality_Btn;


    [Header("Gallery 3 btn")]
    public GameObject gallery;
    private Animator animator_gallery;
    //Gallery btn
    public Sprite gallery_Btn_W, gallery_Btn_R;
    public Button gallery_Btn;
    public GameObject img_Gallery_Close;

    [Header("TECHNICAL  Data")]
    public GameObject technical_Details_Close;
    public GameObject technical_Data;
    //Technical Details btn
    public Sprite technicaldetails_Btn_W, technicaldetails_Btn_R;
    public Button technicaldetails_Btn;


    [Header("Installation Recommendation Gallery")]
    public GameObject installationRecGalleryObj;
    //installation Recommendation btn
    public Sprite installationRCGallery_Btn_W, installationRCGallery_Btn_R;
    public Button installationRCGallery_Btn;

    [Header("Installation REC Video")]
    public GameObject installationVideoObj;
    public Sprite installationRCVideo_Btn_W, installationRCVideo_Btn_R;
    public Button installationRCVideo_Btn;


    [Header("MRP Price")]
    public GameObject Mrp_price;
    //MRP price btn
    public Sprite MRP_Btn_W, MRP_Btn_R;
    public Button MRP_Btn;

    [Header("Contact US")]
    public GameObject contact_Us;
    public GameObject contact_Us_Close;
    //Contact us btn
    public Sprite contactUs_Btn_W, contactUs_Btn_R;
    public Button contactUs_Btn;



    [Header(" Actual Installation Gallery")]
    public GameObject actInsGallery;
    public Sprite actualInsGal_Btn_W, actualInsGal_Btn_R;
    public Button actualInsGal_Btn;

    [Header("Product image gallery")]
    public GameObject Product_Img_Gallery;
    //Product image gallery btn
    public Sprite productImgGallery_Btn_W, productImgGallery_Btn_R;
    public Button productImgGallery_Btn;




    public GameObject info_Panel;                   
   
    
 

    /// <summary>
    /// Fuction to hide and unhide Information buttons panel
    /// </summary>
    /// 

    private void Start()
    {
        animator_gallery = gallery.GetComponent<Animator>();
       
    }


    /// <summary>
    /// UI all buttons panel open close function
    /// </summary>
    public void InfoPanelOpen()
    {
       if(info_Panel != null)
       {
            Animator animator = info_Panel.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }

       }

       if (animator_gallery != null)
       {
          bool isOpen = animator_gallery.GetBool("open");
          if (isOpen == true)
          {
              animator_gallery.SetBool("open", false);
          }

       }

        features_Btn.image.sprite = features_Btn_W;
        gallery_Btn.image.sprite = gallery_Btn_W;
        contactUs_Btn.image.sprite = contactUs_Btn_W;
        technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
        productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
        functionality_Btn.image.sprite = functionality_Btn_W;
        installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
        MRP_Btn.image.sprite = MRP_Btn_W;
        actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
        installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;

    }

    
    

    /// <summary>
    /// Function to hide and unhide Price Information
    /// </summary>
    public void Features_Info()
    {
        if (features.activeInHierarchy == false)
        {
            features.SetActive(true);

            features_Btn.image.sprite = features_Btn_R;
            gallery_Btn.image.sprite = gallery_Btn_W;
            contactUs_Btn.image.sprite = contactUs_Btn_W;
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
            functionality_Btn.image.sprite = functionality_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
            MRP_Btn.image.sprite = MRP_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;

            if (animator_gallery != null)
            {
                bool isOpen = animator_gallery.GetBool("open");
                if(isOpen == true)
                {
                    animator_gallery.SetBool("open", false);
                }
                
            }


            technical_Data.SetActive(false);
            contact_Us.SetActive(false);
            Product_Img_Gallery.SetActive(false);
            Mrp_price.SetActive(false);
            installationRecGalleryObj.SetActive(false);
            actInsGallery.SetActive(false);
            installationVideoObj.SetActive(false);
            functionality.SetActive(false);
        }
        else
        {
            features.SetActive(false);
            features_Btn.image.sprite = features_Btn_W;
        }

    }


    /// <summary>
    /// Function to hide and unhide Dimension iformaton
    /// </summary>
    public void Gallery_Info()
    {
        if (gallery != null)
        {
            features.SetActive(false);
            technical_Data.SetActive(false);
            contact_Us.SetActive(false);
            Product_Img_Gallery.SetActive(false);
            Mrp_price.SetActive(false);
            installationRecGalleryObj.SetActive(false);
            actInsGallery.SetActive(false);
            installationVideoObj.SetActive(false);
            functionality.SetActive(false);

            features_Btn.image.sprite = features_Btn_W;
            gallery_Btn.image.sprite = gallery_Btn_R;
            contactUs_Btn.image.sprite = contactUs_Btn_W;
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
            functionality_Btn.image.sprite = functionality_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
            MRP_Btn.image.sprite = MRP_Btn_W;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
            if (animator_gallery != null)
            {
                if (animator_gallery != null)
                {
                    bool isOpen = animator_gallery.GetBool("open");
                    animator_gallery.SetBool("open", !isOpen);
                }

            }
        }


        if (animator_gallery != null)
        {
            bool isOpen = animator_gallery.GetBool("open");
            if (isOpen == false)
            {
                gallery_Btn.image.sprite = gallery_Btn_W;
            }

        }
        
    }

    /// <summary>
    /// Function to hide and unhide Parts Information
    /// </summary>
    public void TechnicalData_Info()
    {
        if (technical_Data.activeInHierarchy == false )
        {
            if (animator_gallery != null)
            {
                bool isOpen = animator_gallery.GetBool("open");
                if (isOpen == true)
                {
                    animator_gallery.SetBool("open", false);
                }
            }
            features.SetActive(false);

            technical_Data.SetActive(true);
            contact_Us.SetActive(false);
            Product_Img_Gallery.SetActive(false);
            Mrp_price.SetActive(false);
            installationRecGalleryObj.SetActive(false);
            actInsGallery.SetActive(false);
            installationVideoObj.SetActive(false);
            functionality.SetActive(false);

            technicaldetails_Btn.image.sprite = technicaldetails_Btn_R;
            features_Btn.image.sprite = features_Btn_W;
            gallery_Btn.image.sprite = gallery_Btn_W;
            contactUs_Btn.image.sprite = contactUs_Btn_W;
            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
            functionality_Btn.image.sprite = functionality_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
            MRP_Btn.image.sprite = MRP_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
        }
        else
        {
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            technical_Data.SetActive(false);
        }

    }

    /// <summary>
    /// Function to hide and unhide Working Information
    /// </summary>
    public void ContactUs_Info()
    {
        if (contact_Us.activeInHierarchy == false)
        {
            if (animator_gallery != null)
            {
                bool isOpen = animator_gallery.GetBool("open");
                if (isOpen == true)
                {
                    animator_gallery.SetBool("open", false);
                }
            }
            features.SetActive(false);
            technical_Data.SetActive(false);
            contact_Us.SetActive(true);
            Product_Img_Gallery.SetActive(false);
            Mrp_price.SetActive(false);
            installationRecGalleryObj.SetActive(false);
            actInsGallery.SetActive(false);
            installationVideoObj.SetActive(false);
            functionality.SetActive(false);


            features_Btn.image.sprite = features_Btn_W;
            gallery_Btn.image.sprite = gallery_Btn_W;
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            contactUs_Btn.image.sprite = contactUs_Btn_R;
            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
            functionality_Btn.image.sprite = functionality_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
            MRP_Btn.image.sprite = MRP_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
        }
        else
        {
            contact_Us.SetActive(false);
            contactUs_Btn.image.sprite = contactUs_Btn_W;
        }

    }

    /// <summary>
    /// Product Images Gallery open close function
    /// </summary>
    public void ProductImgGallery()
    {
        if (Product_Img_Gallery.activeInHierarchy == false)
        {
           
            Product_Img_Gallery.SetActive(true);
            features.SetActive(false);
            technical_Data.SetActive(false);
            contact_Us.SetActive(false);
            Mrp_price.SetActive(false);
            installationRecGalleryObj.SetActive(false);
            actInsGallery.SetActive(false);
            installationVideoObj.SetActive(false);
            functionality.SetActive(false);


            productImgGallery_Btn.image.sprite = productImgGallery_Btn_R;
            features_Btn.image.sprite = features_Btn_W;
            gallery_Btn.image.sprite = gallery_Btn_W;
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            contactUs_Btn.image.sprite = contactUs_Btn_W;
            functionality_Btn.image.sprite = functionality_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
            MRP_Btn.image.sprite = MRP_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
        }
        else
        {
            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
            Product_Img_Gallery.SetActive(false);
        }
    }




    public void ActualInstallationGallery()
    {
        if (actInsGallery.activeInHierarchy == false)
        {
            
            installationRecGalleryObj.SetActive(false);
            features.SetActive(false);
            technical_Data.SetActive(false);
            contact_Us.SetActive(false);
            Mrp_price.SetActive(false);
            installationVideoObj.SetActive(false);
            actInsGallery.SetActive(true);
            Product_Img_Gallery.SetActive(false);
            functionality.SetActive(false);


            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
            features_Btn.image.sprite = features_Btn_W;
            gallery_Btn.image.sprite = gallery_Btn_W;
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            contactUs_Btn.image.sprite = contactUs_Btn_W;
            functionality_Btn.image.sprite = functionality_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
            MRP_Btn.image.sprite = MRP_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_R;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
        }
        else
        {
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
            actInsGallery.SetActive(false);
        }
    }




    public void InstallationGuidelinesGallery()
    {
        if (installationRecGalleryObj.activeInHierarchy == false)
        {
           
            actInsGallery.SetActive(false);
            features.SetActive(false);
            technical_Data.SetActive(false);
            contact_Us.SetActive(false);
            Mrp_price.SetActive(false);
            installationRecGalleryObj.SetActive(true);
            installationVideoObj.SetActive(false);
            Product_Img_Gallery.SetActive(false);
            functionality.SetActive(false);


            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
            features_Btn.image.sprite = features_Btn_W;
            gallery_Btn.image.sprite = gallery_Btn_W;
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            contactUs_Btn.image.sprite = contactUs_Btn_W;
            functionality_Btn.image.sprite = functionality_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_R;
            MRP_Btn.image.sprite = MRP_Btn_W;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
        }
        else
        {
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
            installationRecGalleryObj.SetActive(false);
        }
    }





    public void Functionality()    // functionality image open
    {
        if (functionality.activeInHierarchy == false)
        {
            if (animator_gallery != null)
            {
                bool isOpen = animator_gallery.GetBool("open");
                if (isOpen == true)
                {
                    animator_gallery.SetBool("open", false);
                }
            }
            functionality.SetActive(true);
            features.SetActive(false);
            technical_Data.SetActive(false);
            contact_Us.SetActive(false);
            Mrp_price.SetActive(false);
            installationRecGalleryObj.SetActive(false);
            actInsGallery.SetActive(false);
            installationVideoObj.SetActive(false);
            Product_Img_Gallery.SetActive(false);

            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
            features_Btn.image.sprite = features_Btn_W;
            gallery_Btn.image.sprite = gallery_Btn_W;
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            contactUs_Btn.image.sprite = contactUs_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
            functionality_Btn.image.sprite = functionality_Btn_R;
            MRP_Btn.image.sprite = MRP_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
        }
        else
        {
            functionality_Btn.image.sprite = functionality_Btn_W;
            functionality.SetActive(false);
        }
    }


    public void InstallationRecommendationVideo()    // InstallationRecommendation video open
    {
        if (installationVideoObj.activeInHierarchy == false)
        {
            if (animator_gallery != null)
            {
                bool isOpen = animator_gallery.GetBool("open");
                if (isOpen == true)
                {
                    animator_gallery.SetBool("open", false);
                }
            }
            installationVideoObj.SetActive(true);
            features.SetActive(false);
            technical_Data.SetActive(false);
            contact_Us.SetActive(false);
            Mrp_price.SetActive(false);
            actInsGallery.SetActive(false);
            functionality.SetActive(false);
            Product_Img_Gallery.SetActive(false);
            installationRecGalleryObj.SetActive(false);


            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
            features_Btn.image.sprite = features_Btn_W;
            gallery_Btn.image.sprite = gallery_Btn_W;
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            contactUs_Btn.image.sprite = contactUs_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_W;
            functionality_Btn.image.sprite = functionality_Btn_W;
            MRP_Btn.image.sprite = MRP_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_R;
        }
        else
        {
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
            installationVideoObj.SetActive(false);
        }
    }


    public void MrpPrice()    // MRP price image open
    {
        if (Mrp_price.activeInHierarchy == false)
        {
            if (animator_gallery != null)
            {
                bool isOpen = animator_gallery.GetBool("open");
                if (isOpen == true)
                {
                    animator_gallery.SetBool("open", false);
                }
            }
            Mrp_price.SetActive(true);
            features.SetActive(false);
            technical_Data.SetActive(false);
            contact_Us.SetActive(false);
            installationRecGalleryObj.SetActive(false);
            actInsGallery.SetActive(false);
            installationVideoObj.SetActive(false);
            functionality.SetActive(false);


            productImgGallery_Btn.image.sprite = productImgGallery_Btn_R;
            features_Btn.image.sprite = features_Btn_W;
            gallery_Btn.image.sprite = gallery_Btn_W;
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
            contactUs_Btn.image.sprite = contactUs_Btn_W;
            installationRCGallery_Btn.image.sprite = installationRCGallery_Btn_R;
            functionality_Btn.image.sprite = functionality_Btn_W;
            actualInsGal_Btn.image.sprite = actualInsGal_Btn_W;
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
            MRP_Btn.image.sprite = MRP_Btn_R;
        }
        else
        {
            MRP_Btn.image.sprite = MRP_Btn_W;
            Mrp_price.SetActive(false);
        }
    }





    public void Fetaures_Close()
    {
        if (features_Pnael_Close.activeInHierarchy == true)
        {
            features_Pnael_Close.SetActive(false);
            features_Btn.image.sprite = features_Btn_W;

        }

    }

    public void Technical_details_Close()
    {
        if (technical_Details_Close.activeInHierarchy == true)
        {
            technical_Details_Close.SetActive(false);
            technicaldetails_Btn.image.sprite = technicaldetails_Btn_W;
        }

    }

    public void Contact_Us_Close()
    {
        if (contact_Us_Close.activeInHierarchy == true)
        {
            contact_Us_Close.SetActive(false);
            contactUs_Btn.image.sprite = contactUs_Btn_W;
        }

    }

   
    public void ProductImg_Gallery_Close()
    {
        if (img_Gallery_Close.activeInHierarchy == true)
        {
            img_Gallery_Close.SetActive(false);
            productImgGallery_Btn.image.sprite = productImgGallery_Btn_W;
        }

    }

    public void MRP_Prrice_Close()
    {
        if (Mrp_price.activeInHierarchy == true)
        {
            Mrp_price.SetActive(false);
            MRP_Btn.image.sprite = MRP_Btn_W;
        }

    }

    // change it to product img gallery function
    public void InstallationVideo_Close()
    {
        if (installationVideoObj.activeInHierarchy == true)
        {
            installationVideoObj.SetActive(false);
            installationRCVideo_Btn.image.sprite = installationRCVideo_Btn_W;
        }

    }

    public void Functionality_Close()
    {
        if (functionality.activeInHierarchy == true)
        {
            functionality.SetActive(false);
            functionality_Btn.image.sprite = functionality_Btn_W;
        }

    }


    
}
