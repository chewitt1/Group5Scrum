using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector2 change;
    private Animator animator;

    [SerializeField] private StatsUI statsUI;
    public StatsUI StatsUI => statsUI;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(statsUI.isOpen) return; //Don't move while stats dialogue is there

        change = Vector2.zero;   
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        // Debug.Log(change);

        /// Boot Into the Character Selection Screen ///
        if(Input.GetAxis("RT") == 1)
        {
            SceneManager.LoadScene("Character_Selection");
        }
        else
        {
            Debug.Log("Right Trigger Not Pressed");
        }


        UpdateAnimMove();
    }

    void UpdateAnimMove()
    {
        if(change != Vector2.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
        
    }

    void MoveCharacter()
    {
        float origSpeed = 4;
        if(Input.GetButton("Fire2"))
        {
            origSpeed = speed;
            speed = 8;
        }
        else
            speed = origSpeed;

        myRigidbody.MovePosition((Vector2)transform.position  + change * speed * Time.fixedDeltaTime);
    }
}
