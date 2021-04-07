using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGlowManager : MonoBehaviour
{
    public Material glow, nonGlow;
    public bool isGlowing = true;

    public void ToggleGlow()
    {
        if (isGlowing)
        {
            gameObject.GetComponent<MeshRenderer>().material = nonGlow;
            isGlowing = false;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = glow;
            isGlowing = true;
        }
    }
}
