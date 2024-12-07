// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickToScene : MonoBehaviour
{
    public string destination;
    Button button;

    void Start()
    {
        this.button = this.GetComponent<Button>();
        this.button.onClick.AddListener(
            delegate
            {
                SceneManager.LoadScene(this.destination);
            }
        );
    }

    void Update() { }
}
