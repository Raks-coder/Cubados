using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool flag=false;
	public float delay=2f;
   public GameObject clUI;
   public void completelevel()
   {
      clUI.SetActive(true);
   }
   public void GameOver()
   {
   	if(flag==false)
   	{
   	flag=true;
   	Debug.Log("Game Over!!!");
   	Invoke("Restart", delay);
   }
   }
   void Restart ()
   {
   	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
