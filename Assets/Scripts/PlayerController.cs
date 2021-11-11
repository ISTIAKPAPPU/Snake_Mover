using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerInput _playerInput;
    private LineRenderer line;
    [SerializeField] private float speed = 5f;
    private float _xThrow;
    private float _yThrow;
    private Vector3 _startPos;
    private Vector3 _endPos;
    public Mesh square;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.InputController.Movement.started += ctx =>
        {
            if (line == null)
                CreateLine();
            var playerPos = transform.position;
           // playerPos.z = 0;
            line.SetPosition(0, playerPos);
            _startPos = playerPos;
            Debug.Log("Start" + _startPos);
        };
        _playerInput.InputController.Movement.canceled += ctx =>
        {
            Debug.Log("PerForm");
            var playerPos = transform.position;
            //playerPos.z = 0;
            line.SetPosition(1, playerPos);
            _endPos = playerPos;
            AddColliderToLine();
            line = null;
        };
        _playerInput.InputController.Movement.performed += ctx =>
        {
            Debug.Log("End");
            var playerPos = transform.position;
           // playerPos.z = 0;
            line.SetPosition(1, playerPos);
            
        };
    }

    private void OnEnable()
    {
        _playerInput.InputController.Enable();
    }

    private void OnDisable()
    {
        _playerInput.InputController.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessTranslate();
    }

    private void ProcessTranslate()
    {
        _xThrow = _playerInput.InputController.Movement.ReadValue<Vector2>().x;
        _yThrow = _playerInput.InputController.Movement.ReadValue<Vector2>().y;

        var xOffset = _xThrow * speed * Time.deltaTime;
        var yOffset = _yThrow * speed * Time.deltaTime;

        var transform1 = transform;
        var position = transform1.position;
        var xPos = position.x + xOffset;
        var yPos = position.z + yOffset;

        transform1.position = new Vector3(xPos, position.y, yPos);
    }

    private void CreateLine()
    {
        line = new GameObject("Line").AddComponent<LineRenderer>();
        line.material = new Material(Shader.Find("Diffuse"));
        line.SetVertexCount(2);
        line.SetWidth(0.1f, 0.1f);
        line.SetColors(Color.black, Color.black);
        line.useWorldSpace = true;
    }

    // Following method adds collider to created line
    private void AddColliderToLine()
    {
        var col = new GameObject("Collider").AddComponent<BoxCollider>();
        col.transform.parent = line.transform;
        var lineLength = Vector3.Distance(_startPos, _endPos);
        col.size = new Vector3(lineLength, 0.1f, 1f);
        Debug.Log(_startPos);
        Debug.Log(_endPos);
        var midPoint = (_startPos + _endPos) / 2;
        col.transform.position = midPoint;
        var angle = (Mathf.Abs(_startPos.y - _endPos.y) / Mathf.Abs(_startPos.x - _endPos.x));
        if ((_startPos.y < _endPos.y && _startPos.x > _endPos.x) ||
            (_endPos.y < _startPos.y && _endPos.x > _startPos.x))
        {
            angle *= -1;
        }

        angle = Mathf.Rad2Deg * Mathf.Atan(angle);
        // col.transform.Rotate(0, 0, angle);
    }
}