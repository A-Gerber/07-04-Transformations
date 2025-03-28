using UnityEngine;

public class MovingForward : MonoBehaviour
{
    private float _speed = 5f;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}