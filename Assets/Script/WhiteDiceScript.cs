using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteDiceScript : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    float rotSpeed = 10.0f;

    //use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    //Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        if (Input.GetMouseButton(0))
        {
            Debug.Log("마우스 눌림");

            DiceNumberTextScript.WhitediceNumber= 0;
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);
            Vector3 dir = new Vector3(dirX, dirY, dirZ);

            transform.position = new Vector3(2, 2, 2);
            transform.rotation =
                Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotSpeed);
                //transform.rotation = Quaternion.identity;
            rb.AddForce((transform.up * 500));
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
 }
