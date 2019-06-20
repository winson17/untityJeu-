using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finished : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Sphere").SendMessage("finish");
    }
}
