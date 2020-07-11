using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TRIGERDIEDRED : MonoBehaviour
{
    public Animator FadeEvent;

    public AudioClip dIED;
    public AudioSource audioSource;
    public GameObject audioSource1;

    public GameObject BAR;
    public GameObject BGRED;
    public GameObject black;
    float timestarts1 = 0;
    float checkevent = 0;
    public static int checkdied =  0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (checkevent == 1)
        { timestarts1 = 0.45f * Time.deltaTime + timestarts1;
            if (timestarts1 >= 1)
            {
                CHARDIED.checkinputpp = 1;
                CHARDIED.checkeventrun = 1;
                checkdied += 1;
                CHARDIED.Numberdied = checkdied;
                checkevent = 0;
                timestarts1 = 0;


                FadeEvent.SetBool("FadeCheck", true);
                return;

            }
        }

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            audioSource1.SetActive(true);
            audioSource.PlayOneShot(dIED);
            BAR.SetActive(false);
            black.SetActive(true);
            BGRED.SetActive(true);
            MOveCilck.checkmove = 0;
            checkevent = 1;
            return;

        }
    }
}
