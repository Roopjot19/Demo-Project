using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipRocket : MonoBehaviour
{
    public GameObject inventory;

    public GameObject[] rockets;

    GameObject currentRocket;
     

    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        inventory.SetActive(true);

        else if(Input.GetKeyUp(KeyCode.Tab))
        inventory.SetActive(false);
    }

    public void SelectRocket(int choice) {
        if (currentRocket = null)
        currentRocket.SetActive(true);
    }
}
