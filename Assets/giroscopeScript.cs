using UnityEngine;

public class giroscopeScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Gyroscope gyroscopio;
    private void Start()
    {
        gyroscopio = Input.gyro;
        gyroscopio.enabled = true;
    }

    // Update is called once per frame
    private void Update()
    {
      Vector3 rotacion = gyroscopio.attitude.eulerAngles;

        transform.localRotation = Quaternion.Euler(new Vector3(rotacion.x, 0, rotacion.y));
    }
}
