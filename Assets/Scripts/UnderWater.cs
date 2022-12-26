using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderWater : MonoBehaviour
{
    public GameObject underWaterEffect;
    public GameObject volume;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "UnderWater") { 
            underWaterEffect.SetActive(true); 
            volume.SetActive(false); }
        if (collision.gameObject.tag == "air") { 
            underWaterEffect.SetActive(false); 
            volume.SetActive(true); }
    }
}
