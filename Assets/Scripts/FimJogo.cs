using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FimJogo : MonoBehaviour
{
    private GameObject aviso;

    
    void Start()
    {
        aviso = GameObject.Find("FimJogo");
        aviso.SetActive(false);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player") == true)
        {
            aviso.SetActive(true);
        }
    }
}
