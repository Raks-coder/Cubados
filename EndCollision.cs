
using UnityEngine;

public class EndCollision : MonoBehaviour
{
	public GameManager gameManager;

    void OnTriggerEnter()
    {
    	gameManager.completelevel();
    }
}
