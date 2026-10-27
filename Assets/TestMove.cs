using UnityEngine;

public class TestMove : MonoBehaviour
{
    void Update()
    {
        transform.Translate(transform.forward * 20f * Time.deltaTime);
    }
}
