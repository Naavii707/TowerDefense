using UnityEngine;
using UnityEngine.Events;

public class Tower : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onInitialized;
    [SerializeField]
    private UnityEvent _onHidden;

    public void Initialized()
    {
        _onInitialized?.Invoke();
    }
    public void Hide()
    {
        _onHidden?.Invoke();
    }
}
