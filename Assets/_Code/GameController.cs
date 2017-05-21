using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


    private Animator animator;

    public int Speed;


    private float translation;

	void Start () {

        animator = this.gameObject.GetComponent<Animator>();

    }
	
	void Update ()
    {


        if (Input.GetButton("Horizontal"))
        {
            translation = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

            if (translation < 0)
            {
                animator.SetBool("Idle_01", false);
                animator.SetBool("Run_02", true);
                transform.localScale = new Vector2(1, 1);
            }
            else if (translation > 0)
            {
                transform.localScale = new Vector2(-1, 1);
                animator.SetBool("Run_02", true);
                animator.SetBool("Idle_01", false);
            }
            
            transform.position += new Vector3(translation, 0, 0);
        }
        else
        {
            animator.SetBool("Run_02", false);
            animator.SetBool("Idle_01", true);
        }

    }
}
