using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{
    [SerializeField]
    private Text _coinsText;
    [SerializeField]
    private UnityEvent _onCoinsUpdated;

    public void UpdateCoins(int coinsNumber)
    {
        _coinsText.text = "X " + coinsNumber;
        _onCoinsUpdated.Invoke();
    }
}
