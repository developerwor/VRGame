using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARVR_Input : MonoBehaviour
{    
    public enum Button
    {
        One,
        Two,
        Thumbstick,
        indexTrigger,
        HandTrigger
    }

    public enum Controller
    {
        LTouch,
        RTouch
    }


    //public static bool Get(Button virtualMask, Controller controller = Controller.RTouch);
    //public static bool GetDown(Button virtualMask, Controller controller = Controller.RTouch);
    //public static bool GetUp(Button virtualMask, Controller controller = Controller.RTouch);
}
