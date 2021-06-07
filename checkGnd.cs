using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkGnd : MonoBehaviour
{
    public static bool isGrounded;
    
    

    private void OnTriggerEnter2D(Collider2D col) {
           if (col.gameObject.tag == "gnd")
           {
            isGrounded = true;
               
           }
    }
    
    private void OnTriggerExit2D(Collider2D col) {
            isGrounded = false;
    }
}
