using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue;
    [SerializeField] float yValue;
    [SerializeField] float zValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
