using UnityEngine;
using UnityEngine.UI;

public class bo : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text textscore;
    // Update is called once per frame
     void Update()
    {
        textscore.text=player.position.z.ToString("0");
    }
}
