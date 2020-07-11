using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MOveCilck : MonoBehaviour
{
    public AudioClip walk;
    public AudioClip impact;
    public AudioClip stand;
    public AudioSource audioSource;

    public GameObject audioSourceObiject;
    public GameObject playerface3;
    public GameObject BLACKBG;
    public GameObject staminabarpp;
    public GameObject checkpointitem1;
    public GameObject Textbox;
    public GameObject Textchar;
    [SerializeField]
    Animator chestAnimator;
    float move = 5;
    public static float timestarts1 = 0;
    public static int checkmove = 1;
    bool  checkgetitem = true;
    public Slider staminaBar;
    float maxStamina = 10;
    int checkmusic = 0;


    void Start()
    {
        staminaBar.maxValue = maxStamina;
    }

    public void RunAnimation1()
    {

        CHAT.checkinputpp = 1;
        playerface3.SetActive(true);
        BLACKBG.SetActive(true);
        Textbox.SetActive(true);
        Textchar.SetActive(true);
        chestAnimator.SetBool("start", false);
        CHAT.NumberChat = 1;
        checkmove = 0;
        return;
    }

    void Update()

    {
       
        
        if (checkmove == 2)
        {
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                audioSourceObiject.SetActive(true);
                audioSource.clip = walk;
                chestAnimator.SetBool("run", true);
                chestAnimator.SetBool("run", false);
                staminaBar.value += 3 * Time.deltaTime;
            }
            if (staminaBar.value == 0)
            {
                chestAnimator.SetBool("run", false);
            }

            if (staminaBar.value != 0)
            {
                if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("a"))
                {

                    audioSourceObiject.SetActive(true);
                    audioSource.clip = walk;
                    chestAnimator.SetBool("run", true);
                    transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * move * 2.5f;
                    chestAnimator.SetBool("move", true);
                    chestAnimator.SetBool("Right", true);
                    staminaBar.value -= 3 * Time.deltaTime;
                    staminabarpp.SetActive(true);

                }
                else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("d"))
                {
                    audioSourceObiject.SetActive(true);
                    audioSource.clip = walk;
                    chestAnimator.SetBool("run", true);
                    transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * move * 2.5f;
                    chestAnimator.SetBool("move", true);
                    chestAnimator.SetBool("Right", false);
                    staminaBar.value -= 3 * Time.deltaTime;
                    staminabarpp.SetActive(true);

                }
            }
            if (Input.GetKey("a") && !Input.GetKey("d"))
            {

                audioSourceObiject.SetActive(true);
                audioSource.clip = walk;
                transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * move;
                chestAnimator.SetBool("move", true);
                chestAnimator.SetBool("Right", true);

            }
            else if (Input.GetKey("d") && !Input.GetKey("a"))
            {
                audioSourceObiject.SetActive(true);
                audioSource.clip = walk;
                transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * move;
                chestAnimator.SetBool("move", true);
                chestAnimator.SetBool("Right", false);

            }


            else if (!Input.GetKey("d") && !Input.GetKey("a"))
            {
                audioSourceObiject.SetActive(false);
                chestAnimator.SetBool("move", false);
                chestAnimator.SetBool("run", false);

            }
            
           
        }
        if(staminaBar.value == maxStamina)
        {
            staminabarpp.SetActive(false);
        }


    }
    /*void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "LOCKER1")
        {
            if (Input.GetKeyDown("e"))
            {
                if (checkgetitem == true)
                {
                    checkmove = false;
                    checkgetitem = false;
                    return;
                }
            }
        }

    }
    */
    }
