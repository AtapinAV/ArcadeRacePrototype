using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Cars
{
    public class Speedometer : MonoBehaviour
    {
        private const float c_convertMasterInSecFromKm = 3.6f;
        
        [SerializeField]
        private Transform _player;
        [SerializeField]
        private float _maxSpeed = 300f;
        [SerializeField]
        private Color _minColor = Color.yellow;
        [SerializeField]
        private Color _maxColor = Color.red;

        [Space, SerializeField, Range(0.1f, 1f)]
        private float _delay = 0.3f;

        [SerializeField]
        private Text _text;

        private void Start()
        {
            StartCoroutine(Speed());
        }

        private IEnumerator Speed()
        {
            var prevPos = _player.position;
            while (true)
            {
                var distance = Vector3.Distance(prevPos, _player.position);
                var speed = (float)System.Math.Round(distance / _delay * c_convertMasterInSecFromKm, 1);

                _text.color = Color.Lerp(_minColor, _maxColor, speed / _maxSpeed);
                _text.text = speed.ToString();
                prevPos = _player.position;
                
                yield return new WaitForSeconds(_delay);
            }
        }
    }
}


