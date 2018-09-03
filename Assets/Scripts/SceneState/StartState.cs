
using UnityEngine;
using UnityEngine.UI;

public class StartState : ISceneState
{
    public StartState(SceneStateController controller) : base("01_Start", controller)
    {
        controller.isLoadScene = false;
    }

    private Image _logo;
    private float _smoothingTime = 1;

    public override void StateStart()
    {
        _logo = GameObject.Find("Logo").GetComponent<Image>();
        _logo.color = Color.black;
    }

    public override void StateUpdate()
    {
        _logo.color = Color.Lerp(_logo.color, Color.white, _smoothingTime * Time.deltaTime);

        //记时 跳转场景
        _waitTimer += Time.deltaTime;
        if (_waitTimer >= _waitTime)
        {
            _controller.SetState(new MainMenuState(_controller));
        }
    }

    private float _waitTime = 2;
    private float _waitTimer = 0;

}
