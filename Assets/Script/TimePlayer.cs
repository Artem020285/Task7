
using UnityEngine;
using TMPro;

public class TimePlayer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timeText;

    private void Update()
    {
        _timeText.text = Time.time.ToString("0.0");
    }
}
