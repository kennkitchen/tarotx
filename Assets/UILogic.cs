using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UILogic : MonoBehaviour
{

    public void reDealCards()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
