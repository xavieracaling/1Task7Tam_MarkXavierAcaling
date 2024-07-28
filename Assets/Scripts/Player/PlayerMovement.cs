using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerConfig playerConfig;
    [SerializeField] private Joystick joystick;
    void Update()
    {
        Vector2 moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);

        // Rotate the player towards the movement direction
        RotateTowardsMovementDirection(moveInput);

        // Move the player
        Move(moveInput);
    }

    private void Move(Vector2 moveInput)
    {
        transform.Translate(moveInput * playerConfig.Speed * Time.deltaTime, Space.World);
    }

    private void RotateTowardsMovementDirection(Vector2 moveInput)
    {
        if (moveInput != Vector2.zero)
        {
            float angle = Mathf.Atan2(-moveInput.x, moveInput.y) * Mathf.Rad2Deg;//

            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
