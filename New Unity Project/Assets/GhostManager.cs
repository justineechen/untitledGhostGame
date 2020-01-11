using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostManager : MonoBehaviour
{   
    public String[] cylinders = {"cylinder1", "cylinder2", "cylinder3"};
    boolean reset 
    timer 
    private timer timerScript = GetComponent<timer.cs>();
    
    var timerStart = timerScript.reset;
    var success = False;
    public String currentCylinder;
    public String nextCylinder;
    
    // Start is called before the first frame update
    void Start()
    {
        currentCylinder = "cylinder1";
        timerStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        while (timerStart){
            if (currentCylinder == "cylinder1"){
                success = CylinderOne();
                //I NEED TO TELL LAWRENCE HERRER THAT THEY PRESS IT!!! 
            }
            elif (currentCylinder == "cylinder2"){
                success = CylinderTwo();
            }
            elif (currentCylinder == "cylinder3"){
                success = CylinderThree();
            }
            if (success){
                //Moving to the next cylinder                
                success = False;

            }
        }
        if (!success){
            //game over binch!
        }

        
    }

    bool CylinderOne(){
        if (Input.GetKeyDown("space")){
            print("space key was pressed");
            currentCylinder = "cylinder2";
            return True;
        }
        return False;
    }

    bool CylinderTwo(){
        if (Input.GetKeyDown("up")){
            print("up key was pressed");
            currentCylinder = "cylinder3";
            return True;
        }
        return False;
    }

    bool CylinderThree(){
        if (Input.GetKeyDown("down")){
            print("down key was pressed");
            currentCylinder = "cylinder1";
            return True;
        }
        return False;
    }
}
