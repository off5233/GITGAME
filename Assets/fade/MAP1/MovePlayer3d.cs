using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer3d : MonoBehaviour
{
    public Rigidbody player;
    public GameObject playerMove;
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
    public static int checkmove = 2;
    bool checkgetitem = true;
    public Slider staminaBar;
    float maxStamina = 10;
    int checkmusic = 0;

    float moveInput;
    bool facingRight = true;


    void Start()
    {
        player = GetComponent<Rigidbody>();
        staminaBar.maxValue = maxStamina;
    }

    void Update()

    {

        if (checkmove == 2)
        {


            player.velocity = new Vector3((Input.GetAxis("Horizontal")* move), (Input.GetAxis("Vertical")* move), player.velocity.z);
            moveInput = Input.GetAxis("Horizontal");


            if (facingRight == false && moveInput > 0)
            {
                Flip();
            }
            else if (facingRight == true && moveInput < 0)
            {
                Flip();
            }

            if (!Input.GetKey("d") && !Input.GetKey("a") && !Input.GetKey("w") && !Input.GetKey("s"))
            {
                chestAnimator.SetBool("move", false);
                chestAnimator.SetBool("run", false);

            }


            if (Input.GetKey("d") || Input.GetKey("a") || Input.GetKey("w") || Input.GetKey("s"))
            {
                chestAnimator.SetBool("move", true);
            }


            if (!Input.GetKey(KeyCode.LeftShift))
            {
                move = 5;
                chestAnimator.SetBool("run", false);
                staminaBar.value += 3 * Time.deltaTime;
                return;
            }
            if (staminaBar.value == 0)
            {
                move = 5;
                chestAnimator.SetBool("run", false);
            }

            if (staminaBar.value != 0)
            {

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    move = 9;
                    chestAnimator.SetBool("run", true);
                    chestAnimator.SetBool("move", true);
                    staminaBar.value -= 3 * Time.deltaTime;
                    staminabarpp.SetActive(true);
                    return;
                }
            }




        }
        if (staminaBar.value == maxStamina)
        {
            staminabarpp.SetActive(false);
        }


    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 lTemp = player.transform.localScale;
        lTemp.x *= -1;
        playerMove.transform.localScale = lTemp;
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
