
using UnityEngine;
using UnityEngine.SceneManagement;

public class begin : MonoBehaviour
{
    public void beginGame()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
