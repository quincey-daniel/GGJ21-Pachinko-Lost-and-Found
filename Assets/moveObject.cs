using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{

    float speed = 1.0f;
    bool toggleTouch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toggleTouch == true)
        {
            var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += move * speed * Time.deltaTime;
        }
    }

    private void OnMouseDown()
    {
        if(toggleTouch == true)
        {
            toggleTouch = false;
        } else
        {
            toggleTouch = true;
        }
    }
}
