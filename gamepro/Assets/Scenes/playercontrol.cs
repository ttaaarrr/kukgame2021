using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerconton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed;
        float newX = transform.position.x;
        float newY = transform.position.y;
        float newZ = transform.position.z;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newZ = transform.position.z + speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newZ = transform.position.z - speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            newX = transform.position.z + speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newX = transform.position.z - speed * Time.deltaTime;
        }
        transform.position = new Vector3(newX, newY, newZ);
    }
}

