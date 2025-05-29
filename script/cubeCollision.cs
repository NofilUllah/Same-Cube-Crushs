using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cubeCollision : MonoBehaviour
{
    //public int score = 0; // Initial score, set in the Inspector
    //public Text scoreText; // Reference to the TextMesh component displaying the score

    private static GameObject selectedCube; // Static variable to store the currently selected cube
    private static Color selectedColor; // Static variable to store the color of the currently selected cube
                                        // private bool gameIsOver = false;
    void OnMouseDown()
    {
        if (!countdown.instance.gameIsRunning)
        {
            Debug.Log("Game is over. Cube destruction skipped.");
            return;
            // Do nothing if the game is over

        }

        // Check if another cube is already selected
        if (selectedCube == null)
        {
            // If no cube is selected, store the reference and color of the clicked cube
            selectedCube = gameObject;
            selectedColor = GetComponent<Renderer>().material.color;
            return;
        }
        else if (selectedCube != gameObject && selectedColor == GetComponent<Renderer>().material.color)
        {
            // If a different cube is selected and the colors match, increase the score
           // score++;
           // UpdateScore();

            // Destroy the selected and clicked cubes
            Destroy(selectedCube);
            Destroy(gameObject);

            // Reset the selected cube and color
            selectedCube = null;
            selectedColor = Color.black; // You can set this to any color not used in your scene
        }
        //else
        //{
        //    // If the colors don't match, reset the selected cube and color
        //    selectedCube = null;
        //    selectedColor = Color.black; // You can set this to any color not used in your scene
        //}
        Debug.Log("Cube clicked: " + gameObject.name);
    }

    void UpdateScore()
    {
        // Update the score text
      //  scoreText.text = "Score: " + score;
    }
    public void SetGameOver()
    {
        // gameIsOver = true;
        Debug.Log("Game Over!");
        // Add any additional actions to perform when the game is over
    }
}