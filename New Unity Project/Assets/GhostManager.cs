using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostManager : MonoBehaviour
{   
    public string[] cylinders = {"cylinder1", "cylinder2", "cylinder3"};
    // private timer timerScript;
    bool timerStart;
    bool success = false;
    public string currentCylinder;
    public Vector3 cameraPosition;
    GameObject mainCamera;
    timer timerScript;
    CameraMovement cameraMovementScript;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
        timerScript = mainCamera.GetComponent<timer>();
        timerStart = timerScript.reset;
        
        cameraMovementScript = mainCamera.GetComponent<CameraMovement>();
        currentCylinder = "cylinder1";
        // timerScript = GetComponent<timer>();
        // timerScript.reset = false;
        // print(timerScript.reset);
        // timerStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown("space")){
        //     timerScript.reset = true;
        //     cameraMovementScript.Move(GameObject.Find(nextCylinder).transform.position);
        //     print("we pressed space");
        // }
        
        if (currentCylinder == "cylinder1"){
            // print("cur is 1");
            success = CylinderOne();
            cameraPosition = new Vector3(5.28f, 2.22f, -6.16f);
            
            //I NEED TO TELL LAWRENCE HERRER THAT THEY PRESS IT!!! 
        }
        else if (currentCylinder == "cylinder2"){
            // print("cur is 2");
            success = CylinderTwo();
            cameraPosition = new Vector3(-8.5f, 9.7f, -9.2f);
        }
        else if (currentCylinder == "cylinder3"){
            // print("cur is 3");
            success = CylinderThree();
            cameraPosition = new Vector3(11f, 3.4f, -2.1f);
        }
        else if (currentCylinder == "cylinder4"){
            // print("cur is 3");
            cameraPosition = new Vector3(-1.5f, 2.5f, 7.4f);
            success = CylinderFour();
        }
        else if (currentCylinder == "cylinder5"){
            // print("cur is 3");
            cameraPosition = new Vector3(11.7f, 5.9f, 2.6f);
            success = CylinderFive();
        }
        else if (currentCylinder == "cylinder6"){
            // print("cur is 3");
            cameraPosition = new Vector3(-8f, 3.5f, 9.8f);
            success = CylinderSix();
        }
        else if (currentCylinder == "cylinder7"){
            // print("cur is 3");
            cameraPosition = new Vector3(20.6f, 2.7f, -7.8f);
            success = CylinderThree();
        }
        if (success){
            timerScript.reset = true;
            cameraMovementScript.Move(cameraPosition);
            // cameraMovementScript.Move(GameObject.Find(currentCylinder).transform.position);
            //Moving to the next cylinder
            // CameraMovement.Move(GameObject.Find(currentCylinder).transform.position);             
            success = false;
        }
        
        if (timerScript.t == 0.0){
            print("game over");
            //game over binch!
        }

        
    }

    bool CylinderOne(){
        // print("in cylinderr 1");
        print("Press Q.");
        if (Input.GetKeyDown("q")){
            currentCylinder = "cylinder2";
            return true;
        }
        return false;
    }

    bool CylinderTwo(){
        print("Press D.");
        if (Input.GetKeyDown("d")){
            // print("up key was pressed");
            currentCylinder = "cylinder3";
            return true;
        }
        return false;
    }

    bool CylinderThree(){
        print("Press Z.");
        if (Input.GetKeyDown("z")){
            // print("down key was pressed");
            currentCylinder = "cylinder4";
            return true;
        }
        return false;
    }
    bool CylinderFour(){
        print("Press E.");
        if (Input.GetKeyDown("e")){
            // print("down key was pressed");
            currentCylinder = "cylinder5";
            return true;
        }
        return false;
    }
        bool CylinderFive(){
        print("Press S.");
        if (Input.GetKeyDown("s")){
            // print("down key was pressed");
            currentCylinder = "cylinder6";
            return true;
        }
        return false;
    }
        bool CylinderSix(){
        print("Press W.");
        if (Input.GetKeyDown("w")){
            // print("down key was pressed");
            currentCylinder = "cylinder7";
            print("YOU WIN!");
            return true;
        }
        return false;
    }
}
