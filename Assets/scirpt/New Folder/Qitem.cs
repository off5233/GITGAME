using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qitem : MonoBehaviour
{
    public GameObject ItemIn;
    public GameObject Item1;
    public GameObject MainBG;
    public static int checkitem1 = 1;
    public static int checkQuit = 0;
    bool check = true, getitem = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            if (check == true)
            {
                ItemIn.SetActive(true);

                if (checkitem1 == 1)
                {
                    Item1.SetActive(true);
                }
                if (checkitem1 == 0)
                {
                    Item1.SetActive(false);
                }
                MainBG.SetActive(false);
                Time.timeScale = 0;
                check = false;
                return;
            }

            if (check == false && checkQuit == 0)
            {
                MainBG.SetActive(true);
                ItemIn.SetActive(false);
                    Time.timeScale = 1;
                    check = true;
                    return;
            }
        }
    }
}
