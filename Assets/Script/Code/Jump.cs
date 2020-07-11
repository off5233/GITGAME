using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private LayerMask platformslayerMask;
    private Rigidbody2D rigidbody2D;
    private BoxCollider2D boxCollider2D;
    private void Awake()
    {
       
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if(IsGrounded()&& Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 50f;
            rigidbody2D.velocity = Vector2.up * jumpVelocity;
        }
    }
    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down * .1f,platformslayerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }
   
        
    }

