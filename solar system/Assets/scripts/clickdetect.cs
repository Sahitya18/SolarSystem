using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickdetect : MonoBehaviour
{
    public static clickdetect instance;
    private void Awake()
    {
        instance = this;
    }
    private void OnMouseDown()
    {
        camerafollow.instance.follow = gameObject;
    }
    
}
