using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class HUD : MonoBehaviour
{
    public int healthStat;
    public Text healthText;
    public GameObject player;

    // Start is called before the first frame update
    private void Start()
    {
        player.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        healthStat = player.GetComponent<PlayerHealth>().getHealth();
        //Debug.Log(" stat is " + healthStat);
        healthText.text = "Health: " + healthStat;
        
    }
}
