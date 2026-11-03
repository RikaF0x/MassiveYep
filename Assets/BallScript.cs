using System;
using Unity.Properties;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    private Rigidbody _rb;

    [SerializeField] private float SpeedVel;
    [SerializeField] private Color defaultColor;
    [SerializeField] private Color accentColor;
    [SerializeField] private Material ballMaterial;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(_rb.linearVelocity.y) < SpeedVel)
        {
            ballMaterial.color = accentColor;
        }
        else
        {
            ballMaterial.color = defaultColor;
        }
    }
}
