using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directionallight : MonoBehaviour
{
    public int rotationScale;

    // Start is called before the first frame update
    void Start()
    {        
        rotationScale = 10;
        
    }

     // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationScale * Time.deltaTime, 0, 0);
    }
}
