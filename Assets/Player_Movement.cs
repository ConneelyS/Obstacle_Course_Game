using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField]float movementSpeed;
 
    // Start is called before the first frame update
    void Start()
    {
        PrintToConsole();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PrintToConsole()
    {
        Debug.Log("This is printing to the Console");
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
