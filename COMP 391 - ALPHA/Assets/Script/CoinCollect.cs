using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        SoundManagerScript.PlaySound("coined");
        if (collider2D.gameObject.CompareTag("Coin"))
        {
            SoundManagerScript.PlaySound("coined");
            Destroy(collider2D.gameObject);
            Debug.Log("DESTROYED");
        }
    }
}
