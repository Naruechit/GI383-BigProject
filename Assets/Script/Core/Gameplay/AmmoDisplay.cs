using System;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    public Image ammoImage;
    public Ammo ammo;
    
    public void SetAmmo(int ammo)
    {
        ammoImage.fillAmount = ammo / 10f;
    }

    public void Update()
    {
        SetAmmo(ammo.currentAmmo);
    }
}
