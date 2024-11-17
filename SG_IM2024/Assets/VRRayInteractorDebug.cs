using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VRRayInteractorDebug : MonoBehaviour
{
    public TMP_Text tmp_text;
    void Start()
    {
        Reset();
    }

    public void Reset()
    {
        tmp_text.text = "";
    }

    public void RayHover()
    {
        tmp_text.text = this.gameObject.name + ":  RayHover";
        Debug.Log(tmp_text.text);
    }

    public void RaySelect()
    {
        tmp_text.text = this.gameObject.name + ": RaySelect";
        Debug.Log(tmp_text.text);
    }

    public void RayFocus()
    {
        tmp_text.text = this.gameObject.name + ": RayFocus";
        Debug.Log(tmp_text.text);
    }

    public void RayActivate()
    {
        tmp_text.text = this.gameObject.name + ": RayActivate";
        Debug.Log(tmp_text.text);
    }
}
