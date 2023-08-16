using UnityEngine;

namespace Cars
{
    [RequireComponent(typeof(WheelsComponent), typeof(BaseInputController), typeof(Rigidbody))]
    public class CarComponent : MonoBehaviour
    {
        private WheelsComponent _wheels;
        private BaseInputController _input;
        private Rigidbody _rigidbody;

        [SerializeField, Range(5f, 60f)]
        private float _maxSteerAngle = 25f;
        [SerializeField]
        private float _torque = 2500f;
        [SerializeField, Range(0f, float.MaxValue)]
        private float _handBrakeTorque = float.MaxValue;
        [SerializeField]
        private Vector3 _centerOfMass;

        private void FixedUpdate()
        {
            _wheels.UpdateVisual(_input.Rotate * _maxSteerAngle);
            var torque = _input.Acceleration * _torque / 2f;
            foreach (var wheel in _wheels.GetFrontWheels)
                wheel.motorTorque = torque;
        }

        private void Start()
        {
            _wheels = GetComponent<WheelsComponent>();
            _input = GetComponent<BaseInputController>();
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.centerOfMass = _centerOfMass;

            _input.OnHandBrakeEvent += OnHandBrake;
        }

        private void OnHandBrake(bool value)
        {
            if (value)
            {
                foreach (var wheel in _wheels.GetRearWheels)
                {
                    wheel.brakeTorque = _handBrakeTorque;
                    wheel.motorTorque = 0f;
                }        
            }
            else
            {
                foreach (var wheel in _wheels.GetRearWheels)
                    wheel.brakeTorque = 0f;
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(transform.TransformPoint(_centerOfMass), 0.5f);
        }

        private void OnDestroy()
        {
            _input.OnHandBrakeEvent -= OnHandBrake;
        }
    }
}


