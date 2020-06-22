using UnityEngine;
using UnityEngine.UI;

namespace ETModel
{
    [ObjectSystem]
    public class UIStartComponetAwakeSystem : AwakeSystem<UIStartComponet>
    {
        public override void Awake(UIStartComponet self)
        {
            self.Awake();
        }
    }



    public class UIStartComponet:Component
    {
        private GameObject btnHotOne;
        private GameObject btnHotTwo;

        public void Awake()
        {
            ReferenceCollector rc = this.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            btnHotOne = rc.Get<GameObject>("HotOne");
            btnHotOne.GetComponent<Button>().onClick.Add(HotOne);
            btnHotTwo = rc.Get<GameObject>("HotTwo");
            btnHotTwo.GetComponent<Button>().onClick.Add(HotTwo);
        }

        public void HotOne()
        {
            Debug.Log("工程1");
            Game.EventSystem.Run(EventIdType.ScenceChange);
            Game.Hotfix.GotoHotfix();
        }

        public void HotTwo()
        {
            Debug.Log("工程2");
            Game.EventSystem.Run(EventIdType.ScenceChange);
            Game.Hot2.GotoHotfix();
        }
    }
}
