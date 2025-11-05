using UnityEngine;

public class QuitApp : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) 
        {
            Application.Quit();
        }
    }
}

