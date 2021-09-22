using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public static camerafollow instance;
    public GameObject Default;
    public GameObject follow;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        camera();
    }

    public void camera()
    { 
        transform.LookAt(follow.transform);
    }

   
}
