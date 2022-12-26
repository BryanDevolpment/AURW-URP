using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugMode : MonoBehaviour
{
    public Transform player;
    public TMP_Text coords;
    public TMP_Text FPS;
    public TMP_Text underWaterMode;
    public GameObject underWaterVolume;

    float fX, fY, fZ;
    float timer, refresh, avgFramerate;
    string display;
    void Update()
    {
        PositionDebug();
        FPSshower();
        UnderWaterModeCheker();
    }
    public void PositionDebug()
    {
        fX = player.position.x;
        fY = player.position.y;
        fZ = player.position.z;

        coords.text = fX.ToString() + ", " + fY.ToString() + ", " + fZ.ToString();
    }
    public void FPSshower()
    {
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timelapse;
        if (timer <= 0) avgFramerate = (int)(1f / timelapse);
        FPS.text = display + avgFramerate.ToString() + " FPS";
    }
    public void UnderWaterModeCheker(){
        bool volumeStatus;
        volumeStatus = underWaterVolume.activeInHierarchy;
        if (volumeStatus == false)
        {
            underWaterMode.text = "false";
            underWaterMode.color = Color.red;
        }if (volumeStatus == true)
        {
            underWaterMode.text = "true";
            underWaterMode.color = Color.green;
        }
    }
}
