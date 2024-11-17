using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEvent : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name.Contains("Key"))
        {
            Debug.Log("OnCollisionEnter");
        }
    }
    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.name.Contains("Key"))
        {
            Debug.Log("OnCollisionStay");
        }
    }
    void OnCollisionExit(Collision col)
    {
        if(col.gameObject.name.Contains("Key"))
        {
            Debug.Log("OnCollisionExit");
        }
    }
}
