using UnityEngine;

public class ChatGPTRotation : MonoBehaviour
{
    //Reccomendation for Chat GPT for rotation the particle. Does not really work well. Some code states (liek the start rotation function and superfluous) and the if statement doesn't work. If you have time you can take more time to asses this.
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
