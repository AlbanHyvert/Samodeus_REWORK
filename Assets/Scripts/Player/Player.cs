using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float _movementSpeed = 0;
    [SerializeField] private float _rotationSpeed = 0;
    [SerializeField] private e_World _currentWorld = e_World.VERTUMN;
    [SerializeField] private float _maxVelocity = 30f;

    [Header("Player Object")]
    [SerializeField] private PCamera _camera = null;
    [SerializeField] private Collider _body = null;

    private Vector3 _currentVelocity = Vector3.zero;

    public PCamera Camera => _camera;
    public Collider Body => _body;
    public bool IsHolding { get; set; }
    public e_World World { get => _currentWorld; set => _currentWorld = value; }

    public Vector3 LocalPosition()
        => this.transform.localPosition;
    public Vector3 WorldPosition()
        => this.transform.position;
    public Vector3 LocalRotation()
        => this.transform.localRotation.eulerAngles;
    public Vector3 WorldRotation()
        => this.transform.rotation.eulerAngles;

    private void Awake()
    {
        if (_camera == null)
            _camera = GetComponentInChildren<PCamera>();
        if (_body == null)
            _body = GetComponent<Collider>();

        IsHolding = false;
        _currentVelocity = Vector3.zero;
    }
}