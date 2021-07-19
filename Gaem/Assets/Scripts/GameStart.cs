using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void StartGame ()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Debug.Log("Enter");
            SceneManager.LoadScene("GaemScene"); 
        } 
    }
}
