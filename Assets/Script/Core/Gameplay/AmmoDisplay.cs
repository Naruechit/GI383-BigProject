using System;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    public Image ammoImage;
    public Ammo ammo;
    
    public void SetAmmo(float ammo)
    {
        ammoImage.fillAmount = ammo / 1f;
    }

    public void Update()
    {
        SetAmmo(ammo.currentAmmo);
    }
}
