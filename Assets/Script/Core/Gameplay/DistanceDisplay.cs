using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DistanceDisplay : MonoBehaviour
{
    public Distance distance;
    public TMP_Text distanceText;
    
    void Update()
    {
        distanceText.text = "Distance: "+(distance.distance.ToString());
    }
}
