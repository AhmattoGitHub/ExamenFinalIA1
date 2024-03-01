using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(2 * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0,0, 2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0,0, -2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            this.transform.Translate(-2 * Time.deltaTime, 0, 0);
        }
    }
}
