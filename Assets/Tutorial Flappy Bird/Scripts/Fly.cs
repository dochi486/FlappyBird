using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    // Start is called before the first frame update
    new public Rigidbody2D rigidbody2D;
    public Animator animator;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    public float forceY = 100;
    // Update is called once per frame
    void Update()
    {
        //ï¿½ï¿½ï¿½ì½º Å¬ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½Ì½ï¿½ ï¿½Ô·ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Vector2 force;
            force.x = 0;
            force.y = forceY;
            rigidbody2D.AddForce(force);

            animator.Play("Flap",0,0);
        }
       
    }
     private void OnCollisionEnter2D(Collision2D other) {
            //?ƒˆì£½ìŒ
            //ê²Œì„?˜¤ë²? UI?‘œ?‹œ
            GameManager.instance.ShowGameOver(true);
            //?Š¤?¬ë¡? ëª¨ë‘ ë©ˆì¶”ê¸?
            animator.Play("Die",0,0);
        }

    private void OnTriggerEnter2D(Collider2D other) {
        GameManager.instance.AddScore();
    }
}
