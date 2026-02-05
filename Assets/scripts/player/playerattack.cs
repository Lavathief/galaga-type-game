using UnityEngine;

public class playerattack : MonoBehaviour
{
    private GameObject bullet;
    [SerializeField] private Transform bulletspawn;
    private float time;
    public float firerate = 2;
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
        float nextTimeToFire = 1 / firerate;
        if (Input.GetKey(KeyCode.Mouse0)) 
        {
            if (time > nextTimeToFire)
            {
                shoot();
                time = 0;
            }
        }
        if (bullet == null)
        {
            bullet = GameObject.Find("bullet");
        }
        //if (bulletspawn == null)//
        //{//
        //bulletspawn = GameObject.Find("bulletspawn");//
        //}//
    }
    private void shoot()
    {
        Instantiate(bullet, bulletspawn.position, Quaternion.identity);
    }
}
