using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatinTextController : MonoBehaviour
{
    private static FloatingText popupText;
    private static GameObject canvas;

    public static void Initialize()
    {
        canvas = GameObject.Find("Canvas");
        if(!popupText)
            popupText = Resources.Load<FloatingText>("Models/PopupTextParent");
    }

    public static void CreateFloatingText(string text, Transform location)
    {
        FloatingText instance = Instantiate(Resources.Load<FloatingText>("Models/PopupTextParent"));
        instance.transform.SetParent(canvas.transform, false);
        instance.SetText(text);
    }
}
