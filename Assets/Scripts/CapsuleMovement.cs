using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
        CheckJump();
    }
    private void checkMovement()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.back * speed* Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.forward * speed*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed* Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed* Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Choque detectado"+ collision.gameObject.name);
        canJump = true;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detectado"+other.gameObject.name);
    }
    private void CheckJump()
    {
        if (Input.GetKeyDown(KeyCode.Space)& canJump)
        {
            Debug.Log("Espacio pulsado");
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer==LayerMask.NameToLayer("ground"))
        {
            canJump = false;
        }
    }

}
