using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TargetScript : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Bullet") == true)
        {
            GameController.instance.UpdateTargets();
            Destroy(gameObject);
        }
    }
}
