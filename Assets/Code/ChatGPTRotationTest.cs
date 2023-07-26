using UnityEngine;

public class ChatGPTRotation : MonoBehaviour
{
    public float rotationSpeed = 180f;
    private float targetRotation = 180f;
    private float currentRotation = 0f;
    private float rotationTimer = 0f;
    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            rotationTimer += Time.deltaTime;
            float rotationStep = rotationSpeed * Time.deltaTime;
            currentRotation += rotationStep;

            if (rotationTimer >= 16.6f)
            {
                isRotating = false;
                rotationTimer = 0f;
                currentRotation = targetRotation;
            }

            transform.rotation = Quaternion.Euler(0f, currentRotation, 0f);
        }
    }

    public void StartRotation()
    {
        isRotating = true;
    }
}
