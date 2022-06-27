using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
   **********************
	Author : Taii
	Company: SuperGame

   **********************
*/

public class CharacterMovement : MonoBehaviour
{
	public float speedMovement;

	public Rigidbody rb;
    private Vector3 direction;

    private void OnValidate()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        //direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speedMovement;
        direction = (transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical")) * speedMovement;
    }

    private void FixedUpdate()
    {
        if (direction != Vector3.zero)
        {
            rb.MovePosition(rb.position + direction * Time.fixedDeltaTime);
        }
    }
}
