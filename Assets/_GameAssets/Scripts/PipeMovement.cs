using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float _pipesSpeed;

    private void Start() 
    {
        Destroy(gameObject,8f);
    }
    private void Update()
    {
        transform.position += Vector3.left * _pipesSpeed * Time.deltaTime;
    }
}
