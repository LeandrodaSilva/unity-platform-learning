using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public GameObject MegaMan;
    public float yOffset = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(MegaMan.transform.position.x, MegaMan.transform.position.y + yOffset, -10);   
    }
}
