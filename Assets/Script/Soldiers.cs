
using UnityEngine;

public class Soldiers : MonoBehaviour
{
    float speed = 5f;
    private void Update()
    {
        float v = Input.GetAxis("Vertical");     
        float h = Input.GetAxis("Horizontal");
        
        Vector3 direction = Vector3.forward * v + Vector3.right * h;    
        transform.position += direction * speed * Time.deltaTime;
    }
}
