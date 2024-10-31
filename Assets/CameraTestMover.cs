using UnityEngine;

public class CameraTestMover : MonoBehaviour
{
    [SerializeField] private float _swapDirectionTimeThreshold = 4f;

    private float _timer;
    private bool _isMovingRight = true;
    
    [SerializeField] private float _speed = 1f;
    
    void Update()
    {
        var camXPosition = Camera.main.transform.position.x;

        if (_timer >= _swapDirectionTimeThreshold)
        {
            _isMovingRight = !_isMovingRight;
            _timer = 0;
        }

        float newXPosition;
        if (_isMovingRight)
        {
            newXPosition = camXPosition + _speed * Time.deltaTime;
        }
        else
        {
            newXPosition = camXPosition - _speed * Time.deltaTime;
        }
        
        Camera.main.transform.position = new Vector3(newXPosition, 0, -10);
        
        _timer += Time.deltaTime;
    }
}
