using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float currentAmmo;
    public float maxAmmo = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmmo == 1)
        {
            currentAmmo = 1;
        }
    }
}
