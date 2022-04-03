using UnityEngine;

public class PCameraController : MonoBehaviour
{
    [SerializeField] private Player _self = null;
    [SerializeField] private PCamera _camera = null;

    private void Start()
    {
        if (!_self)
            _self = GetComponentInParent<Player>();
        if (!_camera)
            _camera = GetComponent<PCamera>();
    }
}
