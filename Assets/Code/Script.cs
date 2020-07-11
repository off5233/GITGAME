using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject Player;
    public SpriteRenderer BGITEM; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Player.transform.position.y > BGITEM.transform.position.y)
        {
            BGITEM.sortingOrder = 2;
            return;
        }
        else
        {
            BGITEM.sortingOrder = 0;
            return;
        }
        
    }
}
