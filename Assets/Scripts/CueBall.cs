using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour
{
    public float StrikePower;
    public GameObject Ball;
    void Start()
    {
        
    }
    private void Update()
    {
        Ball.GetComponent<Rigidbody>().AddForce(-StrikePower, 0, 0, ForceMode.Acceleration);
    }
}
