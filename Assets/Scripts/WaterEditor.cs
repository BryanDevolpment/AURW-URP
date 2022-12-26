using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterEditor : MonoBehaviour
{
    public Material mat;
    public Slider smoothness;
    public Slider normalStrength;
    public TMP_Text smoothnessValue;
    public TMP_Text normalStrengthValue;
    public Texture2D textureF1;
    public Texture2D textureF2;
    public Texture2D textureF3;
    public Texture2D textureS1;
    public Texture2D textureS2;
    public Texture2D textureS3;
    //
    int normalC = 0;
    float normalMapping = 1;
    float secondNormal = 1;
    float foamRender = 1;
    float foamTexture = 1;
    float alpha = 1;
    void Update()
    {
        //
        mat.SetFloat("_Normal_Mapping", normalMapping);
        mat.SetFloat("_Second_Normal_Render", secondNormal);
        mat.SetFloat("_FoamRender", foamRender);
        mat.SetFloat("_Foam_Texture", foamTexture);
        mat.SetFloat("_Alpha", alpha);
        if(normalMapping == 2) normalMapping = 0.0f;
        if(secondNormal == 2) secondNormal = 0.0f;
        if(foamRender == 2) foamRender = 0.0f;
        if(foamTexture == 2) foamTexture = 0.0f;
        if(alpha == 2) alpha = 0.0f;
        ///
        if (normalC == 0)
        {
            mat.SetTexture("_First_Normal", textureF1);
            mat.SetTexture("_Second_Normal", textureS1);
        }
        if (normalC == 1)
        {
            mat.SetTexture("_First_Normal", textureF2);
            mat.SetTexture("_Second_Normal", textureS2);
        }
        if (normalC == 2)
        {
            mat.SetTexture("_First_Normal", textureF3);
            mat.SetTexture("_Second_Normal", textureS3);
        }
        mat.SetFloat("_Smoothness", smoothness.value);
        mat.SetFloat("_Normal_Strength", normalStrength.value);
        smoothnessValue.text = smoothness.value.ToString();
        normalStrengthValue.text = normalStrength.value.ToString();
    }
    public void ChangeNormalMapping()
    {
        normalMapping += 1.0f;
    }
    public void ChangeSecondNormal()
    {
        secondNormal += 1.0f;
    }
    public void ChangeFoamRender()
    {
        foamRender += 1.0f;
    }
    public void ChangeFoamTexture()
    {
        foamTexture += 1.0f;
    }
    public void ChangeAlpha()
    {
        alpha += 1.0f;
    }
    public void ResetValues()
    {
        normalMapping = 1.0f;
        secondNormal = 1.0f;
        foamRender = 1.0f;
        foamTexture = 1.0f;
        alpha = 1.0f;
        normalC = 0;
        mat.SetFloat("_Smoothness", 0.85f);
        mat.SetFloat("_Normal_Strength", 0.72f);
    }
    public void Change1() {
        normalC = 1;
    }
    public void Change2()
    {
        normalC = 2;
    }
}
