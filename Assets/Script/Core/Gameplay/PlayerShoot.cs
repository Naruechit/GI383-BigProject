using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 10f;

    public float bulletLifeTime = 2f; // ⏱ เวลาก่อนกระสุนหาย (วินาที)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * bulletSpeed; // ⬆️ ยิงขึ้นด้านบน

        Destroy(bullet, bulletLifeTime); // 💥 ทำลายหลังผ่านเวลา
    }
}