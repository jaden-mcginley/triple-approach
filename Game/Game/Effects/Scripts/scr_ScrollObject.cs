using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ScrollObject : MonoBehaviour
{
    [SerializeField] internal scr_GameSettings gameSettings;

    private void Start()
    {
        gameSettings = GameObject.FindGameObjectWithTag("GameSettings").GetComponent<scr_GameSettings>();
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, gameSettings.objectScrollSpeed), Space.World);
        if (gameObject.transform.position.z <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
