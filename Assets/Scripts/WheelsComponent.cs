using UnityEngine;

namespace Cars
{
    public class WheelsComponent : MonoBehaviour
    {
        private WheelCollider[] _allWheels;

        [SerializeField]
        private Transform[] _frontMeshes;
        [SerializeField]
        private Transform[] _rearMeshes;

        [SerializeField]
        private WheelCollider[] _frontWheels;
        [SerializeField]
        private WheelCollider[] _rearWheels;

        public WheelCollider[] GetFrontWheels => _frontWheels;
        public WheelCollider[] GetRearWheels => _rearWheels;
        public WheelCollider[] GetAllWheels => _allWheels;

        public void UpdateVisual(float angle)
        {
            for (int i = 0; i < _frontMeshes.Length; i++)
            {
                _frontWheels[i].steerAngle = angle;
                _frontWheels[i].GetWorldPose(out var pos, out var rot);
                _frontMeshes[i].SetPositionAndRotation(pos, rot);

                _rearWheels[i].GetWorldPose(out pos, out rot);
                _rearMeshes[i].SetPositionAndRotation(pos, rot);
            }
        }

        private void Start()
        {
            _allWheels = new WheelCollider[] { _frontWheels[0], _frontWheels[1], _rearWheels[0], _rearWheels[1] };
        }
    }
}


