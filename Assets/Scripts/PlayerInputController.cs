using UnityEngine;

namespace Cars
{
    public class PlayerInputController : BaseInputController
    {
        private CarControls _control;

        protected override void FixedUpdate()
        {
            var direction = _control.Car.Rotate.ReadValue<float>();
            if (direction == 0f && Rotate != 0f)
            {
                Rotate = Rotate > 0f
                    ? Rotate - Time.fixedDeltaTime
                    : Rotate + Time.fixedDeltaTime;
            }
            else
            {
                Rotate = Mathf.Clamp(Rotate + direction * Time.fixedDeltaTime, -1f, 1f);
            }

            Acceleration = _control.Car.Acceleration.ReadValue<float>();
        }

        private void Awake()
        {
            _control = new CarControls();
            _control.Car.HandBrake.performed += _ => CallHandBrake(true);
            _control.Car.HandBrake.canceled += _ => CallHandBrake(false);
        }
        private void OnEnable() => _control.Car.Enable();
        private void OnDisable() => _control.Car.Disable();
        private void OnDestroy() => _control.Dispose();
    }
}


