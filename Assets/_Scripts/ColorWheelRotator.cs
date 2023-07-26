using UnityEngine;

public class ColorWheelRotator : MonoBehaviour {

    [SerializeField] private float speed = 100f;

    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
