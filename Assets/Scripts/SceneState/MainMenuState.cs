/*
 *  Title 地下守护神
 *
 *      模型层: 
 *
 *      Descripts:
 *          功能: 
 *          
 *      Date:
 *
 *      Version:0.1
 *
 *      Modify Recoder:
 */

using UnityEngine;
using UnityEngine.UI;

public class MainMenuState : ISceneState
{
    public MainMenuState(SceneStateController controller) : base("02_MainMenu", controller)
    {
    }

    private Button _button;

    public override void StateStart()
    {
        _button = GameObject.Find("BtnStartGame").GetComponent<Button>();
        _button.onClick.AddListener(OnStartButtonOnClick);
    }

    private void OnStartButtonOnClick()
    {
        _controller.SetState(new BattleState(_controller));
    }

}
