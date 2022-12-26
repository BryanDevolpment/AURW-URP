using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            ScreenCapture.CaptureScreenshot(Application.dataPath + "/Screenshot.png");
        }
    }
}
