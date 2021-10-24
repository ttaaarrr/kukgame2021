using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontroller : MonoBehaviour
{
    public Light light;
    public string lightName = "Living room";
   
    // Start is called before the first frame update
        void Start()
    {
        print("hello" + lightName);
    }
  private void Awake()
    {
        print("Hello awake");
    }
  /*  private void OnMouseDown()
 {
     print("mouse Down");
     if(light.enable)
     light.enabled = false;
 }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
