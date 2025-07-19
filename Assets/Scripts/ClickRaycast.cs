using UnityEngine;
using UnityEngine.Events;

public class ClickRaycast : MonoBehaviour
{
    [SerializeField]
    private float _raycastDistance = 100f;
    [SerializeField]
    private LayerMask _raycastLayerMask;
    [SerializeField]
    private string _coinTag = "Coin";
    [SerializeField]
    private UnityEvent<Transform> _onCoinPressed;
    private bool _isActive = false;


    public void SetActive(bool isActive)
    {
        _isActive = isActive;
    }

    private void Update()
    {
        if (!_isActive) return;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, _raycastDistance, _raycastLayerMask))
            {
                if (hit.collider.CompareTag(_coinTag))
                {
                    PressCoin(hit.collider.GetComponent<Coin>());
                }
            }
        }
    }

    private void PressCoin(Coin coin)
    {
        coin.Collect();
        _onCoinPressed?.Invoke(coin.transform);
    }
}
