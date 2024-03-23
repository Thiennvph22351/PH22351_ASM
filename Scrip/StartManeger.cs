using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManeger : MonoBehaviour
{
    // private void OnGUI(){
    //     GUI.Box(new Rect(10,50,300,100),"Hello");
    //     if(GUI.Button(new Rect(128,100,60,30),"Button")){
    //         print("Aaaa");
    //     }
    //     GUI.Label(new Rect(128,70,50,50),"OK");
    // }
    public void PlayGameButton(){
       SceneManager.LoadScene(1);
    }
}
