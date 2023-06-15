using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_SpawnObject : MonoBehaviour
{
    [SerializeField] internal scr_GameManager gameManager;
    [SerializeField] private GameObject[] pickableObjects;
    private GameObject pickObject;

    private int randomSide; //0 is left, 1 is right
    private int randomObjectIndex;
    private float randomObjectPosition;
    private Vector3 objectLocation;
    [SerializeField] internal float objectSpawnDistance = 500;

    void Start()
    {
        InvokeRepeating("SpawnObject", 1f, .01f);
    }

    private void Update()
    {
        if (gameManager.gameSettings.gameOver)
        {
            CancelInvoke("SpawnObject");
        }
    }

    void SpawnObject()
    {
        randomSide = Random.Range(0, 2);
        randomObjectIndex = Random.Range(0, pickableObjects.Length);
        pickObject = pickableObjects[randomObjectIndex];

        if (randomSide == 0)
        {
            randomObjectPosition = Random.Range(-12.5f, -28f);
        }
        else if (randomSide == 1)
        {
            randomObjectPosition = Random.Range(10.5f, 20f);
        }

        if (pickObject == pickableObjects[0]) //If picked object is grass, spawn at specific location
        {
            objectLocation = new Vector3(randomObjectPosition, 2.2f, objectSpawnDistance);
        }
        else if (pickObject == pickableObjects[1]) //If picked object is grass, spawn at specific location
        {
            objectLocation = new Vector3(randomObjectPosition, 2.7f, objectSpawnDistance);
        }
        else if (pickObject == pickableObjects[2]) //If picked object is grass, spawn at specific location
        {
            objectLocation = new Vector3(randomObjectPosition, 2.8f, objectSpawnDistance);
        }
        else //Any other object should spawn at default height and length away
        {
            objectLocation = new Vector3(randomObjectPosition, 0f, objectSpawnDistance);
        }

        if (randomSide == 0)
        {
            Instantiate(pickObject, objectLocation, Quaternion.Euler(0, Random.Range(-30, -50), 0));
        }
        else if (randomSide == 1)
        {
            Instantiate(pickObject, objectLocation, Quaternion.Euler(0, Random.Range(30, 50), 0));
        }
    }
}
