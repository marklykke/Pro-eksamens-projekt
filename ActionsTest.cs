using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ActionsTest : MonoBehaviour
{
    public SteamVR_Input_Sources handType; 
    public SteamVR_Action_Boolean teleportAction; 
    public SteamVR_Action_Boolean grabAction; 

    // Update is called once per frame
    void Update()
    {
        bool GetTeleportDown()
        {
            return teleportAction.GetStateDown(handType);
        }

        bool GetGrab()
        {
            return grabAction.GetState(handType);
        }

        if (GetTeleportDown())
        {
            print("Teleport " + handType);
        }

        if (GetGrab())
        {
            //print("Grab " + handType);
        }

    }
}
