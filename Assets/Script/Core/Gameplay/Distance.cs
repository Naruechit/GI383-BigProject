using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    [SerializeField] public Image finishLine;
    [SerializeField] public Player player;

    public int distance = 0;
    
    // Update is called once per frame
    void Update()
    {
        distance = (int)(finishLine.transform.position.y - player.transform.position.y);
    }
}
