using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour

{
    [SerializeField] private Transform distance;
    private float movementSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        

        if (Input.GetButtonDown("Horizontal"))
        {
            transform.position += new Vector3(Horizontal * movementSpeed, 0);
        }
        if (Input.GetButtonDown("Vertical"))
        {
            transform.position += new Vector3(0, Vertical * movementSpeed);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && distance.localScale.z > 1)
        {
            distance.localScale -= new Vector3(8, 2+2/3f, 1);
        }
        if (Input.GetKeyDown(KeyCode.F) && distance.localScale.z < 16)
        {
            distance.localScale += new Vector3(8, 2+2/3f, 1);
        }
    }
}
