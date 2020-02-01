using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugController : MonoBehaviour {
    public ConsoleController consoleController;
    public void CodeClicked(string code) {
        if(code == "Left") {
            consoleController._leftButton.transform.position = consoleController._downButton.transform.position;
            
        }
        
    }

}
