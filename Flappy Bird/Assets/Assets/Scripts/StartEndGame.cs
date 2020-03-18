using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEndGame : MonoBehaviour
{
    public void ScreenSwitching()
    {
        SceneManager.LoadScene("Game");
        PlayerAction.points = 0;
    }
}
