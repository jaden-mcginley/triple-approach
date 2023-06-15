using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_DontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
