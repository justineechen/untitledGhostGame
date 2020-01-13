using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 moveToPosition;
    Vector3 rotateValue;
    float speed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // print("hello");
        // Debug.Log("helo");
        // if (Input.GetKey("up")){
        //     print("up arrow key is held down");
        //     // moveToPosition = new Vector3 (0, 2, -0.01f);
        //     moveToPosition = new Vector3 (6.7f, 1.6f, -2.2f);
        //     transform.position = Vector3.Lerp (transform.position, moveToPosition, speed);
            
        // }

        // if (Input.GetKey("down")){
        //     print("down arrow key is held down");
        //     rotateValue = new Vector3(0,180,0);
        //     transform.eulerAngles = transform.eulerAngles - rotateValue;
        // }
        
    }
    
    public void Move(Vector3 position)
    {
        float x = position[0];
        float y = position[1];
        float z = position[2];
        moveToPosition = new Vector3(x, y, z);
        transform.position = moveToPosition;
    }

    public void NewMove(Transform target) {
        transform.LookAt(target);
    }
}
