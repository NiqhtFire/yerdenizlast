using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parala : MonoBehaviour
{
    public GameObject _cam;
    [SerializeField] private float _speed;
    void Update() {
        transform.Translate(-1 * _speed * Time.deltaTime, 0.0f, 0.0f);

        if(_cam.transform.position.x  >= transform.position.x + 60.7734f) {
            transform.position = new Vector2(
                
                _cam.transform.position.x + 60.7734f,
                transform.position.y
            );
            Debug.Log("workin");
        }
    }
}