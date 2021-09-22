using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // rotation

    [SerializeField]
    float Rotation_speed;
    [SerializeField]
    float Revolving_speed;
    [SerializeField]
    GameObject planet;
    [SerializeField]
    GameObject Sun;

    private void Update()
    {
        rotation();
        revolving();
    }
    void revolving()
    {
        planet.transform.RotateAround(Sun.transform.position, Vector3.up, Revolving_speed * Time.deltaTime);
    }

    void rotation()
    {
        planet.transform.Rotate(Vector3.up * Rotation_speed * Time.deltaTime);
    }
}
