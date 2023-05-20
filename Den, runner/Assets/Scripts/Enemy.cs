using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float Damage;
    public float Speed;

    private void Update()
    {
        transform.Translate(Vector2.left * Speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().Hp -= Damage;
            Destroy(gameObject);
        }
    }
}
