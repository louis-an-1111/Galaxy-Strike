using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{   
    [SerializeField] ParticleSystem laser;
    bool isFiring = false;

    // Update is called once per frame
    void Update()
    {
        ProcessFiring();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    void ProcessFiring()
    {
        var emissionModule = laser.emission;
        emissionModule.enabled = isFiring;
    }

}
