using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Cars
{
    public class TimeStart : MonoBehaviour
    {
        private float _timeStart = 5f;

        [SerializeField]
        private TimeTrack _timeTrack;
        [SerializeField]
        private Text _textTimer;

        private void Start()
        {
            _textTimer.text = _timeStart.ToString();
        }

        private void Update()
        {
            InputSystem.DisableDevice(Keyboard.current);
            _timeTrack.gameObject.SetActive(false);
            _timeStart -= Time.deltaTime;
            _textTimer.text = _timeStart.ToString();
            if (_timeStart <= 0f)
            {
                Destroy(gameObject);
                _timeTrack.gameObject.SetActive(true);
                InputSystem.EnableDevice(Keyboard.current);
            }
        }
    }
}


