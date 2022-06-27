using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
   **********************
	Author : Taii
	Company: SuperGame

   **********************
*/

public class CharacterRotation : MonoBehaviour
{
    public float rotateSmooth;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            RotateController();
        }
    }

    private void RotateController()
    {
        float yRotate = Input.GetAxis("Mouse X");
        if (yRotate != 0)
        {
            transform.Rotate(0, yRotate * Time.deltaTime * rotateSmooth, 0);
        }
    }
}
