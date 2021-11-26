using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0,100f)] private float speed = 50f;

    BoxCollider myBoxCollider;
    // Start is called before the first frame update
    void Start()
    {
        myBoxCollider = GetComponent<BoxCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0f)
        {
            transform.Translate(Input.GetAxis("Vertical") * transform.forward * speed);

            Debug.Log(Input.GetAxis("Vertical"));
        }
    }

    void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
