using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(20f, 0f, 0f);
    [SerializeField] float period = 2f;

    const float tau = Mathf.PI * 2;
    float movementFactor;

    Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycles = Time.time / period;
        float rawSinWave = Mathf.Sin(cycles * tau);

        movementFactor = (rawSinWave / 2f) + 0.5f;
        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
