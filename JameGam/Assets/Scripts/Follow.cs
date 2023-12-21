using UnityEngine;

public enum PathMovementStyle
{
    Continuous,
    Slerp,
    Lerp,
}
public class Follow : MonoBehaviour
{
    public float MovementSpeed;
    public Transform PathContainer;
    public Transform stopRoute;
    public bool goIn;
    public Transform myStop;
    [Range(0f, 3f)] public float accuracy;
    public PathMovementStyle MovementStyle;
    public bool LoopThroughPoints;
    public bool StartAtFirstPointOnAwake;
    Vector2 pos;
    private Transform[] _points;

    private Rotate one;
    private Rotate two;
    private int _currentTargetIdx;
    private bool inR;
    private bool stop;
    public int lookIdx;
    private void Awake()
    {
        one = transform.GetChild(0).GetChild(0).GetComponent<Rotate>();
        two = transform.GetChild(0).GetChild(1).GetComponent<Rotate>();
        _points = PathContainer.GetComponentsInChildren<Transform>();
        if (StartAtFirstPointOnAwake)
        {
            transform.position = _points[0].position;
        }
    }

    private void Update()
    {
        one.player = _points[lookIdx].gameObject;
        two.player = _points[lookIdx].gameObject;
        if (_points == null || _points.Length == 0) return;
        var distance = Vector3.Distance(transform.position, _points[_currentTargetIdx].position);
        if (inR)
        {
            print(1);
            if (_points[_currentTargetIdx].name == "Stop")
            {
                print(2);
                if (_points[_currentTargetIdx] == myStop)
                {
                    print(3);
                    if (distance < 3f)
                    {
                        print("Test");
                        stop = true;
                        Invoke("startAgain", 2);
                        _currentTargetIdx++;
                        pos = _points[_currentTargetIdx].position + new Vector3(Random.Range(-accuracy, accuracy), Random.Range(-accuracy, accuracy));
                    }
                }
                else
                {
                    _currentTargetIdx++;
                    pos = _points[_currentTargetIdx].position + new Vector3(Random.Range(-accuracy, accuracy), Random.Range(-accuracy, accuracy));
                }
            }
        }
        if (_currentTargetIdx == lookIdx && Mathf.Abs(distance) < 7 && !stop && _points[_currentTargetIdx] != myStop)
        {
            lookIdx++;
            if (lookIdx >= _points.Length)
            {
                lookIdx = LoopThroughPoints ? 0 : _points.Length - 1;
            }
        }
        if (Mathf.Abs(distance) < 3 && !stop && _points[_currentTargetIdx] != myStop)
        {
            _currentTargetIdx++;

            if (_currentTargetIdx >= _points.Length)
            {
                _currentTargetIdx = LoopThroughPoints ? 0 : _points.Length - 1;
            }
            pos = _points[_currentTargetIdx].position + new Vector3(Random.Range(-accuracy, accuracy), Random.Range(-accuracy, accuracy));
        }
        if (_points[_currentTargetIdx].name == "Choose" && goIn)
        {
            _points = new Transform[0];
            inR = true;
            goIn = false;
            _points = stopRoute.GetComponentsInChildren<Transform>();
            _currentTargetIdx = 0;
            lookIdx = 0;
            pos = _points[_currentTargetIdx].position + new Vector3(Random.Range(-accuracy, accuracy), Random.Range(-accuracy, accuracy));

        }
        if (_points[_currentTargetIdx].name == "Back")
        {
            inR = false;
            _points = new Transform[0];
            _points = PathContainer.GetComponentsInChildren<Transform>();
            _currentTargetIdx = 12;
            lookIdx = 12;
            pos = _points[_currentTargetIdx].position + new Vector3(Random.Range(-accuracy, accuracy), Random.Range(-accuracy, accuracy));

        }

        if (!stop)
        {
            switch (MovementStyle)
            {
                default:
                case PathMovementStyle.Continuous:
                    transform.position = Vector3.MoveTowards(transform.position, pos, MovementSpeed * Time.deltaTime);
                    break;
                case PathMovementStyle.Lerp:
                    transform.position = Vector3.Lerp(transform.position, pos, MovementSpeed * Time.deltaTime);
                    break;
                case PathMovementStyle.Slerp:
                    transform.position = Vector3.Slerp(transform.position, pos, MovementSpeed * Time.deltaTime);
                    break;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (_points == null || _points.Length == 0) return;
        var idx = 0;
        foreach (var point in _points)
        {
            Gizmos.color = Color.yellow;
            if (idx < _currentTargetIdx)
            {
                Gizmos.color = Color.red;
            }

            if (idx > _currentTargetIdx)
            {
                Gizmos.color = Color.green;
            }

            Gizmos.DrawWireSphere(point.position, 1f);
            idx++;
        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, pos);
    }
    void startAgain()
    {
        stop = false;
        pos = _points[_currentTargetIdx].position + new Vector3(Random.Range(-accuracy, accuracy), Random.Range(-accuracy, accuracy));
        print((pos,transform.position));

    }
}