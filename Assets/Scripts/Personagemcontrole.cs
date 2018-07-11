using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class Personagemcontrole : MonoBehaviour {

    public float movementSpeed;
    public float RotationSpeed;
    CharacterController cc;
    public Animator anim;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

     void Update()
    {
        Vector3 Frente = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * movementSpeed;
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime, 0));
        cc.Move(Frente * Time.deltaTime);
        cc.SimpleMove(Physics.gravity);
        
        
        if (cc.isGrounded)
        {

            if (Input.GetAxis("Horizontal") != 0)
            {
                anim.SetBool("Turn", true);

            }
            else
            {
                anim.SetBool("Turn", false);
                                
            }

            if (Input.GetAxis("Vertical") != 0)
            {

              anim.SetBool("Walk", true);
            if (Input.GetKey(KeyCode.Space))
                {
                    anim.SetBool("Jumping", true);
                    this.GetComponent<Transform>().position += new Vector3(0, 2, 0);
                }
            else
            {
              anim.SetBool("Jumping", false);
            }

            }
            else
            {
                anim.SetBool("Walk", false);

            }

            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("JumpingIdle", true);
                this.GetComponent<Transform>().position += new Vector3(0, 2, 0);
            }
            else
            {
                anim.SetBool("JumpingIdle", false);
            }
        }
        

    }
    void OnCollisionEnter(Collision col)
    {
        print("fuck");
        if (col.gameObject.tag == "ini")
        {
            print("a");
            Destroy(col.gameObject);
        }
    }
    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.collider.tag =="ini") {

            Destroy(hit.collider.gameObject);
    

        }
    }

}
