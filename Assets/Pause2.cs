using UnityEngine;

public class Pause2 : MonoBehaviour
{
    private bool _isPause;

    public bool OnPause
    {
        set
        {
            if (_isPause == value) return;
            _isPause = value;
            if (_isPause)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) OnPause = true;
        if (Input.GetButtonDown("Fire2")) OnPause = false;
    }

    private void Pause()
    {
        Debug.Log("Pause");
    }

    private void Resume()
    {
        Debug.Log("Resume");
    }
}
