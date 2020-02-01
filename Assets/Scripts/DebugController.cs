using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DebugController : MonoBehaviour {
    public ConsoleController consoleController;

    public GameObject leftDebugButton;
    public GameObject upDebugButton;
    public GameObject rightDebugButton;
    public GameObject downDebugButton;

    public void CodeClicked(string code) {
        //consoleController.consoleButtons[0].GetComponent<TextMeshProUGUI>().text = code;
        //consoleController.consoleButtons[0].name = code;

        consoleController.currentlyClicked.GetComponent<TextMeshProUGUI>().text = code;
        consoleController.currentlyClicked.name = code;

        HideAllDebugOptions();
    }
    public void ShowLeftButton() {
        leftDebugButton.SetActive(true);
    }
    public void ShowRighttButton() {
        rightDebugButton.SetActive(true);
    }
    public void ShowUpButton() {
        upDebugButton.SetActive(true);
    }
    public void ShowDownButton() {
        downDebugButton.SetActive(true);
    }

    public void HideAllDebugOptions() {
        rightDebugButton.SetActive(false);
        upDebugButton.SetActive(false);
        downDebugButton.SetActive(false);
        leftDebugButton.SetActive(false);
    }
}
//if(code == "Left") {
//    consoleController._downButton.GetComponent<TextMeshProUGUI>().text = "Left";
//    //consoleController._downButton.GetComponent<Button>().onClick.RemoveAllListeners();
//    //consoleController._downButton.GetComponent<Button>().onClick = consoleController._leftButton.GetComponent<Button>().onClick;
//}
//else if(code == "Right") {
//    consoleController._downButton.GetComponent<TextMeshProUGUI>().text = "Left";
//}