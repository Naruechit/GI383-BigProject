using UnityEngine;

public class Ammo : MonoBehaviour
{
    public int currentAmmo;
    public int maxAmmo = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
