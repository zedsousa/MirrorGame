using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinScript : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 3, 0);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player") == true)
        {
            GameController.instance.UpdateCoins();
            Destroy(gameObject);
        }
    }
}
