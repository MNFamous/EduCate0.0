using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class button : MonoBehaviour
{
 public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
