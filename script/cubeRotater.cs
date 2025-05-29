using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cubeRotater : MonoBehaviour
{
    

    // Start is called before the first frame update
    //void Start()
    //{
    //    // Add a listener to the button click event
    //    quitButton.onClick.AddListener(QuitGame);
    //}

    //// Function to quit the application
    //void QuitGame()
    //{
 
    //    UnityEditor.EditorApplication.isPlaying = false;
 
    //}

    // Update is called once per frame
    void Update()
    {

        // Rotate the cube around the Y-axis by 90 degrees per second
        transform.Rotate(Vector3.up, 90.0f * Time.deltaTime);
    }
    //public void ExitGame()
    //{
 
    //    UnityEditor.EditorApplication.isPlaying = false;
 
    //        Application.Quit();
 
    //}
}
