using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ScrollParticle : MonoBehaviour
{
    [SerializeField] internal scr_GameSettings gameSettings;

    private void Start()
    {
        gameSettings = GameObject.FindGameObjectWithTag("GameSettings").GetComponent<scr_GameSettings>();
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, gameSettings.particleScrollSpeed), Space.Self);
        if (gameObject.transform.position.z >= 300f)
        {
            Destroy(gameObject);
        }
    }
}
