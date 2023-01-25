using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superman : MonoBehaviour
{
    public float Power;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 7)
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(0, Power, 0, ForceMode.Impulse);
        }  
    }
}
