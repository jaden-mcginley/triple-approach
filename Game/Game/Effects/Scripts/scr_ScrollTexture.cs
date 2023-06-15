using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ScrollTexture : MonoBehaviour
{
    public float speed = .5f;

    void FixedUpdate()
    {
        float offset = Time.time * speed;
        Vector2 offsetVecor = new Vector2(1, -offset);
        GetComponent<Renderer>().material.mainTextureOffset = offsetVecor;
    }
}
