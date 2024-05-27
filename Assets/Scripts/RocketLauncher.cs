using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    public GameObject rocketPrefab;
    public Transform launchPoint;
    public float launchForce = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchRocket();
        }
    }

    void LaunchRocket()
    {
        GameObject rocketInstance = Instantiate(rocketPrefab, launchPoint.position, launchPoint.rotation);

        Rigidbody rb = rocketInstance.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = launchPoint.right * launchForce; //Aplica la fuerza de disparo para que dispare al eje x
        }
    }
}