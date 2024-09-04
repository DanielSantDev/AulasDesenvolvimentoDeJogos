using UnityEngine;

public class Spaceship : MonoBehaviour
{

    public Projectile ProjectilePrefabs;
    public float speed = 5f;

    void Update()
    {
        //transform.Translate(new Vector3(0.01f, 0, 0));
        //if (Input.GetKey(KeyCode.RightArrow))
        //transform.Translate(Time.deltaTime * new Vector3(5f, 0, 0));

        //Debug.Log(Input.GetAxis("Horizontal"));

        //if (Input.GetAxis("Horizontal") > 0){
        //    transform.Translate(Time.deltaTime * new Vector3(5f, 0, 0));
        //} else if (Input.GetAxis("Horizontal") < 0)
        //{
        //    transform.Translate(Time.deltaTime * new Vector3(-5f, 0, 0));
        //}

        ApplyMovement();
        FireProjectile();

    }

    void ApplyMovement()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        transform.Translate(Time.deltaTime * speed * new Vector3(horizontal, vertical));
    }

    void FireProjectile()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefabs, transform.position, Quaternion.identity);
        }
    }
}