using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Cars
{
    public class TriggerFinishComponent : MonoBehaviour
    {
        [SerializeField]
        private TimeTrack _timeTrack;
        [SerializeField]
        private Button _button;
        [SerializeField]
        private Text _textEnd;

        private void OnTriggerEnter(Collider other)
        {
            _textEnd.text = _timeTrack.TimeStart.ToString();
            _timeTrack.gameObject.SetActive(false);
            _textEnd.gameObject.SetActive(true);
            _button.gameObject.SetActive(true);
            InputSystem.DisableDevice(Keyboard.current);
        }
    }
}


