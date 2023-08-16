using UnityEngine;
using UnityEngine.UI;

namespace Cars
{
    public class TimeTrack : MonoBehaviour
    {
        private float _timeStart;
        public float TimeStart => _timeStart;

        [SerializeField]
        private Text _textTimer;

        private void Start()
        {
            _textTimer.text = _timeStart.ToString("F4");
        }

        private void Update()
        {
            _timeStart += Time.deltaTime;
            _textTimer.text = _timeStart.ToString("F4");
        }
    }
}


