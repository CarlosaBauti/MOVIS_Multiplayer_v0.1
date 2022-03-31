using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class UserTypeManager : MonoBehaviour
{
    public static bool userType; //true is tablet user and false is HMD user

    public void ClickedHeadset()
    {
        userType = false; //set as HMD user
    }
    
    public void ClickedTablet()
    {
        userType = true; // set as Tablet user
    }

}
