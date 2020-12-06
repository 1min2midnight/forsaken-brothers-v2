using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerHit, powerUp, playerDead, enemyDead, enemyAttack, backgroundMusic1;
    static AudioSource audioScr;
    void Start()
    {
        playerHit = Resources.Load<AudioClip>("attack");
        powerUp = Resources.Load<AudioClip>("powerupp");
        playerDead = Resources.Load<AudioClip>("playerdead");
        enemyDead = Resources.Load<AudioClip>("enemydead");
        enemyAttack = Resources.Load<AudioClip>("enemyattack");
        backgroundMusic1 = Resources.Load<AudioClip>("initial_song");

        audioScr = GetComponent<AudioSource>();

    }

    
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip) { 
            case "attack":
                audioScr.PlayOneShot(playerHit);
                break;
            case "powerupp":
                audioScr.PlayOneShot(powerUp);
                break;
            case "playerdead":
                audioScr.PlayOneShot(playerDead);
                break;
            case "enemydead":
                audioScr.PlayOneShot(enemyDead);
                break;
            case "enemyattack":
                audioScr.PlayOneShot(enemyAttack);
                break;
            case "inital_song":
                audioScr.PlayOneShot(backgroundMusic1);
                break;
        }

    }
}
