using UnityEngine;

public class Projectile : MonoBehaviour
{

    public Vector3 direction;
    public float speed;
    public System.Action Destroyed;

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.Destroyed != null) { 
        this.Destroyed.Invoke();
        }
        Destroy(this.gameObject);
    }

}
