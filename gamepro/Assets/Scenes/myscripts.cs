using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myscripts : MonoBehaviour
{
    int count=0;
    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        print(count+"hello Update?");
        count++;
    }
}
