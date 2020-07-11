using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnbarEvent : MonoBehaviour
{
    public AudioClip HIT;
    public AudioSource audioSource;
    public GameObject audioSource1;

    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;

    public GameObject spacebarB;

    public GameObject SliderBarDoor;
    public Slider DOORBAR;
    public static int checkevent1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkevent1 == 1) {
            SliderBarDoor.SetActive(true);
            DOORBAR.value -= 75 * Time.deltaTime;
            spacebarB.SetActive(true);
            if (Input.GetKeyDown("space"))
            {
                audioSource1.SetActive(true);
                audioSource.PlayOneShot(HIT);
                DOORBAR.value += 15;
            }

        if (DOORBAR.value >= 100)
        {
                RUNEVENTMONSTER.checkrunevent = 7;
                spacebarB.SetActive(false);
                SliderBarDoor.SetActive(false);
                CHAT.NumberChat = 40;
                Textbox.SetActive(true);
                Textchar.SetActive(true);
                BGBLACK.SetActive(true);
                CHAT.checkinputpp = 1;
                MOveCilck.checkmove = 0;
                checkevent1 = 2;
                return;

        }
    }


    }
}
