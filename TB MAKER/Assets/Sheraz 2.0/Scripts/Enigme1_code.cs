using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigme1_code : MonoBehaviour
{

    public InputField Pass;
    public string code = null;
    public Text txt;
    public string To_Load;


    public void Enter_Push()
    {
        code = Pass.text;
        if (Pass.text != null)
        {
            if (code == "1735")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load);
            }
            else if(code == "5384")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load);
            }
            else if (code == "586")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load);
            }
            else if (code == "369")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load);
            }
            else if (code == "319")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load);
            }
            else if (code == "132")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load);
            }
            else if (code == "PLC" || code == "plc")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load);
            }
            else
            {
                txt.text = "Code erroné !";
                Pass.text = null;
            }
        }
    }
}
