using UnityEngine;

namespace Muckus_Fuckus_Internal
{
    public class Loader
    {
        private static GameObject _load;
        
        
        public static void Init()
        {
            _load = new GameObject();
            
            _load.AddComponent<Esp>();
            _load.AddComponent<Achievement>();
            
            Object.DontDestroyOnLoad(_load);
            
        }

        public static void Unload()
        {
           Object.Destroy(_load); 
        }

        
    }
}