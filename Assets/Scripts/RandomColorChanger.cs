using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorChanger : MonoBehaviour
{
   

    bool isBlue;
    int count =0;
    private new Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        count = Random.Range(1,2 );
    }

    void ColorChanger()
    {
        if(count == 1)
        {
            renderer.material.color = Color.blue;
        }else{
            renderer.material.color = Color.green;
        }
    }
}
