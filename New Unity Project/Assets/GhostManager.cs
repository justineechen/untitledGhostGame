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
    public string nextCylinder;
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
        nextCylinder = "cylinder2";
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
            //I NEED TO TELL LAWRENCE HERRER THAT THEY PRESS IT!!! 
        }
        else if (currentCylinder == "cylinder2"){
            // print("cur is 2");
            success = CylinderTwo();
        }
        else if (currentCylinder == "cylinder3"){
            // print("cur is 3");
            
            success = CylinderThree();
        }
        else if (currentCylinder == "cylinder4"){
            // print("cur is 3");
            
            success = CylinderFour();
        }
        else if (currentCylinder == "cylinder5"){
            // print("cur is 3");
            
            success = CylinderFive();
        }
        else if (currentCylinder == "cylinder6"){
            // print("cur is 3");
            
            success = CylinderSix();
        }
        else if (currentCylinder == "cylinder7"){
            // print("cur is 3");
            
            success = CylinderThree();
        }
        if (success){
            timerScript.reset = true;
            cameraMovementScript.Move(GameObject.Find(currentCylinder).transform.position);
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
        if (Input.GetKeyDown("q")){
            print("q key");
            currentCylinder = "cylinder2";
            return true;
        }
        return false;
    }

    bool CylinderTwo(){
        if (Input.GetKeyDown("d")){
            // print("up key was pressed");
            print("d key");
            currentCylinder = "cylinder3";
            return true;
        }
        return false;
    }

    bool CylinderThree(){
        if (Input.GetKeyDown("z")){
            // print("down key was pressed");
            print("z key");
            currentCylinder = "cylinder4";
            return true;
        }
        return false;
    }
    bool CylinderFour(){
        if (Input.GetKeyDown("e")){
            // print("down key was pressed");
            print("e key");
            currentCylinder = "cylinder5";
            return true;
        }
        return false;
    }
        bool CylinderFive(){
        if (Input.GetKeyDown("s")){
            // print("down key was pressed");
            print("s key");
            currentCylinder = "cylinder6";
            return true;
        }
        return false;
    }
        bool CylinderSix(){
        if (Input.GetKeyDown("w")){
            // print("down key was pressed");
            print("w key");
            currentCylinder = "cylinder7";
            print("YOU WIN!");
            return true;
        }
        return false;
    }
}
