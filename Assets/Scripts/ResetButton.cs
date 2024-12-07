// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public Button button;

    void Start()
    {
        this.button.onClick.AddListener(
            delegate
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        );
    }

    void Update() { }
}
