using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        Destroy(gameObject,10);
    }
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}   
