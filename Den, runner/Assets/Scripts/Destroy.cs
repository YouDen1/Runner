using UnityEngine;
public class Destroy : MonoBehaviour
{
    public float LifeTime;

    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }
}
