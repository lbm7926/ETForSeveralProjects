using ETModel;
using System;

namespace Hot2
{
    public static class Init
    {
        public static void Start()
        {
#if ILRuntime
            if (!Define.IsILRuntime)
            {
                Log.Error("mono层是mono模式, 但是Hotfix层是ILRuntime模式");
            }
#else
            if (Define.IsILRuntime)
            {
                Log.Error("mono层是ILRuntime模式, Hotfix层是mono模式");
            }
#endif
            try
            {
                // 注册热更层回调
                ETModel.Game.Hot2.Update = () => { Update(); };
                ETModel.Game.Hot2.LateUpdate = () => { LateUpdate(); };
                ETModel.Game.Hot2.OnApplicationQuit = () => { OnApplicationQuit(); };

                Game.Scene.AddComponent<UIComponent>();
                //Game.Scene.AddComponent<OpcodeTypeComponent>();
                //Game.Scene.AddComponent<MessageDispatcherComponent>();

                //// 加载热更配置
                //ETModel.Game.Scene.GetComponent<ResourcesComponent>().LoadBundle("config.unity3d");
                //Game.Scene.AddComponent<ConfigComponent>();
                //ETModel.Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle("config.unity3d");

                //UnitConfig unitConfig = (UnitConfig)Game.Scene.GetComponent<ConfigComponent>().Get(typeof(UnitConfig), 1001);
                //Log.Debug($"config {JsonHelper.ToJson(unitConfig)}");

                Log.Debug("我是Hot2");
                Game.EventSystem.Run(EventIdType.InitSceneStart);
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        public static void Update()
        {
            try
            {
                Game.EventSystem.Update();
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        public static void LateUpdate()
        {
            try
            {
                Game.EventSystem.LateUpdate();
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        public static void OnApplicationQuit()
        {
            Game.Close();
        }
    }
}
