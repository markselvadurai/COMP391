using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip playerJumpSound, playerFireSound, coinCollectSound, playerDeathSound, playerHitSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        playerJumpSound = Resources.Load<AudioClip>("jump");
        playerFireSound = Resources.Load<AudioClip>("playerFire");
        coinCollectSound = Resources.Load<AudioClip>("coined");
        playerDeathSound = Resources.Load<AudioClip>("playerDeath");
        playerHitSound = Resources.Load<AudioClip>("hit");


        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jump":
                audioSrc.PlayOneShot(playerJumpSound);
                break;
            case "coined":
                audioSrc.PlayOneShot(coinCollectSound);
                break;
            case "death":
                audioSrc.PlayOneShot(playerDeathSound);
                break;
            case "fire":
                audioSrc.PlayOneShot(playerFireSound);
                break;
            case "hit":
                audioSrc.PlayOneShot(playerHitSound);
                break;
        }
    }
 
}
