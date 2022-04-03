using UnityEngine;

public class PCamera : MonoBehaviour
{
    [Header("Camera Settings")]
    [SerializeField] private float minY = 10;
    [SerializeField] private float maxY = 180;
    [Space]
    [SerializeField] private Camera _camera = null;

    public Camera Camera()
        => _camera;
    public Vector3 LocalRotation()
        => _camera.transform.localRotation.eulerAngles;
    public Vector3 WorldRotation()
        => _camera.transform.rotation.eulerAngles;
    public Vector3 LocalPosition()
        => _camera.transform.localPosition;
    public Vector3 WorldPosition()
        => _camera.transform.position;
    public float FiedOfView()
        => _camera.fieldOfView;
}