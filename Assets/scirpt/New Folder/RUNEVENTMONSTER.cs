using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RUNEVENTMONSTER : MonoBehaviour
{
    public Animator FadeEvent;

    public AudioClip dIED;
    public AudioSource audioSource;
    public GameObject audioSource1;
    public GameObject audioSourceMonster;

    public GameObject BAR;
    public GameObject BGRED;
    public GameObject black;

    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    public GameObject Textchar1;
    public GameObject FaceStart;

    [SerializeField]
    Animator chestAnimator;
    public static int checkrunevent = 1;
    public GameObject CheckpointCamera;
    public GameObject CAMERA;
    public GameObject MonsterAnimation;
    int checkdied = 0;
    float timestarts1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        CheckpointCamera.transform.position  = CAMERA.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (checkdied == 1)
        {
            CHARDIED.Numberdied = 4;
            CHARDIED.checkinputpp = 1;
            CHARDIED.checkeventrun = 1;
            CHARDIED.NumberdiedMON = 0;
            BAR.SetActive(false);
            black.SetActive(true);
            BGRED.SetActive(true);
            timestarts1 = 0.45f * Time.deltaTime + timestarts1;
            if (timestarts1 >= 1)
            {
                FadeEvent.SetBool("FadeCheck", true);
                return;

            }
        }


        if(checkrunevent == 2)
        {
            if (CAMERA.transform.position.x >10 )
            {
                CAMERA.transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * 100f;
            }
            if (CAMERA.transform.position.x <= 10 && CAMERA.transform.position.x >= -2)
            {
                CAMERA.transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * 3f;
                return;
            }
            if (CAMERA.transform.position.x <= -2)
            {
                checkrunevent = 3;
                return;
            }
        }
        if (checkrunevent == 3)
        {
            MonsterAnimation.transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * 2f;
            if(MonsterAnimation.transform.position.x >= -3 )
            {
                CHAT.NumberChat = 30;
                Textbox.SetActive(true);
                Textchar.SetActive(true);
                BGBLACK.SetActive(true);
                CHAT.checkinputpp = 1;
                MOveCilck.checkmove = 0;
                checkrunevent = 0;
                return;
            }

        }
        if(  checkrunevent  == 4)
        {
            MonsterAnimation.transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * 50f;
            if (MonsterAnimation.transform.position.x >= 10)
            {
                CAMERA.transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * 150f;
                if(CAMERA.transform.position.x >= 160.2264)
                {
                    checkrunevent = 5;
                    return;
                }
                
            }

        }

        if (checkrunevent == 5)
        {
            CHAT.NumberChat = 34;
            Textbox.SetActive(true);
            Textchar1.SetActive(true);
            BGBLACK.SetActive(true);
            FaceStart.SetActive(true);
            CHAT.checkinputpp = 1;
            MOveCilck.checkmove = 0;
            checkrunevent = 0;
        }

        if (checkrunevent == 6)
        {
            chestAnimator.SetBool("CHECKRUNMOVE",true);
            audioSourceMonster.SetActive(true);
            MonsterAnimation.transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * 10f;
        }
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.name == "LOCKERDROP2")
        {
            Destroy(GameObject.Find("LOCKERDROP2"));

        }
        if (other.gameObject.name == "player")
        {
            audioSource1.SetActive(true);
            audioSource.PlayOneShot(dIED);
            checkdied = 1;
            BAR.SetActive(false);
            black.SetActive(true);
            BGRED.SetActive(true);
            return;
        }

    }

}
