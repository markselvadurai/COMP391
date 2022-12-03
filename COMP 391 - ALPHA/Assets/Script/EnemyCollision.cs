using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{
    public int deaths = 0;
    public Transform respawnPoint;
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            HealthManager.health--;
            if (HealthManager.health <= 0)
            {
                PlayerManager.isGameOver = true;
                gameObject.SetActive(false);
            }
            else
            {
                StartCoroutine(GetHurt());
                Debug.Log("Player hit");
                SoundManagerScript.PlaySound("hit");
            }
        }
        if (other.gameObject.CompareTag("Boundary"))
        {
            HealthManager.health--;
            if (HealthManager.health <= 0)
            {
                PlayerManager.isGameOver = true;
                gameObject.SetActive(false);
            }
            else
            {
                StartCoroutine(GetHurt());
                Debug.Log("Player Respawned");
                SoundManagerScript.PlaySound("death");
                Player.transform.position = respawnPoint.position;
            }
        }
    }
    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(7, 9);
        yield return new WaitForSeconds(3);
        Physics2D.IgnoreLayerCollision(6, 8, false);
    }
}