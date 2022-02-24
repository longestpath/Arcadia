using UnityEngine;
using UnityEditor;

namespace Arcadia
{
    [InitializeOnLoad]
    public class ArcadiaProjectInitialization
        // Starts with an "A" because Editor scripts are initialized alphabetically 
    {
        static ArcadiaProjectInitialization()
        {
            CheckSettings();
        }

        public static void CheckSettings()
        {
            Debug.Log("Checking Unity Settings...");

            // TODO: What are some sane Unity Editor settings, and what is
            // the best way to make this work in a fashion that supports
            // idiomatic clojure dev and the ClojureCLR equivalent of
            // "uberjar"?

            if (!PlayerSettings.runInBackground)
            {
                Debug.Log("Updating Run In Background to true");
                PlayerSettings.runInBackground = true;
            }
        }

    }
}
