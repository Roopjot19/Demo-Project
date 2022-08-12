using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
     
    [SerializeField]
    private GameObject[] cubeReference;


    [SerializeField]
    private GameObject ObjectToBeSpawned;

    private GameObject spawnedCube;

    [SerializeField]
    private Transform leftPos, rightPos;

    [SerializeField]
    private int randomIndex;
    private int randomSide;

    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCubes());
        
    }

     IEnumerator SpawnCubes()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, cubeReference.Length -1);
            randomSide = Random.Range(0, 2);

            spawnedCube = Instantiate(cubeReference[randomIndex]);

            // left side
            if (randomSide == 0)
            {
                spawnedCube.transform.position = leftPos.position;
                spawnedCube.GetComponent<Cube>().speed = Random.Range(4, 10);

            }
            else
            {
                // right side
                spawnedCube.transform.position = rightPos.position;
                spawnedCube.GetComponent<Cube>().speed = -Random.Range(4, 10);
                spawnedCube.transform.localScale = new Vector3(-1f, 1f, 1f);

            } // while loop

        }







    }

    
}
