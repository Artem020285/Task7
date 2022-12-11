
using UnityEngine;

public class Soldiers : MonoBehaviour
{
    float speed = 5f;
    private void Update()
    {
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed * v);

        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed * h);
    }
}
