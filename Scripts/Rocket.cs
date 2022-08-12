using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Transform rocketSpawnPoint;
    public GameObject rocketPrefab;
    public float rocketSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Shoot();
        }
    }

    void Shoot() {
        GameObject rocket= Instantiate(rocketPrefab, rocketSpawnPoint.position, rocketSpawnPoint.rotation);
        rocket.GetComponent<Rigidbody>().velocity = rocketSpawnPoint.forward * rocketSpeed;
    }
}
