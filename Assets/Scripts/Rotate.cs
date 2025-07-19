using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private Vector3 _rotationSpeed = new Vector3(0, 10f, 0);

    void Update()
    {
        transform.Rotate(_rotationSpeed * Time.deltaTime, Space.Self);
    }
}
