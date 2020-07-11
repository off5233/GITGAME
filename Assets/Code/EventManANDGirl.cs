using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManANDGirl : MonoBehaviour
{
    public Animator AnimatorFadeManGirl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
                AnimatorFadeManGirl.SetBool("CheckEvent", true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
                AnimatorFadeManGirl.SetBool("CheckEvent", false);

        }
    }
}
