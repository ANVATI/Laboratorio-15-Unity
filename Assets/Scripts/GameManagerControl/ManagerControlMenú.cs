using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerControlMen� : MonoBehaviour
{
    void Update()
    {

    }
    public void DoSomething()
    {
        SceneManager.LoadScene("Level");
    }
}