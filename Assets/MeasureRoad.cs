using UnityEngine;

public class MeasureRoad : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Road width: " + GetComponent<MeshRenderer>().bounds.size.x);
    }
}
