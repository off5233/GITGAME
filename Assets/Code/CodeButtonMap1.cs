using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CodeButtonMap1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator AnimatorFade;
    public GameObject pasuebutton;
    public GameObject Return;
    public GameObject MainMenu;
    public GameObject Restart;
    public GameObject Quit;
    // Start is called before the first frame update
    public void Breturn()
    {
        Time.timeScale = 1;
        pasuebutton.SetActive(true);
        Return.SetActive(false);
        MainMenu.SetActive(false);
        Restart.SetActive(false);
        Quit.SetActive(false);

    }

    // Update is called once per frame
    public void Bretstart1()
    {
        MOveCilck.checkmove = 1;
        MOveCilck.timestarts1 = 0;
        Looker.getitem = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("MAP1");
    }
    public void Bmainmenu1()
    {
        MOveCilck.checkmove = 1;
        MOveCilck.timestarts1 = 0;
        Looker.getitem = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Clarity");
    }
    public void Bquit1()
    {
        Application.Quit();
    }
    public void DiedFade1()
    {
        Return.SetActive(false);
        MainMenu.SetActive(false);
        Restart.SetActive(false);
        AnimatorFade.SetBool("check", true);
    }
}
