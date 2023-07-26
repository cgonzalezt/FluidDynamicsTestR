using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Data;

public class RotationScript : MonoBehaviour
{
    //Adaption of the ChatGPT code. Also doesn't work because the target rotation cannot be more than 180f. Revisit if necessary but look to "BasicMovement" script for the final product.
    public float rotationSpeed = 720f;
    public Vector3 translationVelocity = new Vector3(0.03518f, 1.1574f, 0.018f);
    private float targetRotation = 720f;
    private float currentRotation = 0f;
    private float rotationTimer = 0f;
    private bool isMoving = true;

    void Update()
    {
        if (isMoving)
        {
            rotationTimer += Time.deltaTime;
            float rotationStep = rotationSpeed * Time.deltaTime;
            currentRotation += rotationStep;

            if (rotationTimer >= 16.6f)
            {
                isMoving = false;
                rotationTimer = 0f; 
                currentRotation = currentRotation+ (targetRotation*0.06024096386f);
            }

            transform.rotation = Quaternion.Euler(0f, currentRotation, 0f);

            Vector3 translationStep = translationVelocity * Time.deltaTime;
            transform.Translate(translationStep);
        }
    }
}









