using UnityEngine;

public class DestroyOffscreen : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
