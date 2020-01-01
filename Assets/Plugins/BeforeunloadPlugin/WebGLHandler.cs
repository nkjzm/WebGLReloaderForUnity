using System.Runtime.InteropServices;
using UnityEngine;

namespace nkjzm
{
    /// <summary>
    /// WebGLビルドが動作するページから離脱する時に警告を出すためのクラス
    /// </summary>
    public static class WebGLHandler
    {
        [DllImport("__Internal")] static extern void enableBeforeUnloadEvent();
        [DllImport("__Internal")] static extern void enableBeforeUnloadEvent(string message);
        [DllImport("__Internal")] static extern void disableBeforeUnloadEvent();
        [DllImport("__Internal")] static extern bool isEnabledBeforeUnloadEvent();
        [DllImport("__Internal")] static extern bool reload();

        /// <summary>
        /// ページ離脱時の警告を有効にする
        /// </summary>
        public static void EnableBeforeUnloadEvent()
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            enableBeforeUnloadEvent();
#endif
        }

        /// <summary>
        /// ページ離脱時の警告を有効にする
        /// </summary>
        /// <param name="message">警告メッセージ (Chromeでは無効)</param>
        public static void EnableBeforeUnloadEvent(string message)
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            enableBeforeUnloadEvent(message);
#endif
        }

        /// <summary>
        /// ページ離脱時の警告を無効にする
        /// </summary>
        public static void DisableBeforeUnloadEvent()
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            disableBeforeUnloadEvent();
#endif
        }

        /// <summary>
        /// ページ離脱時の警告が有効かどうかを返す
        /// WebGL以外の環境ではfalseを返す
        /// </summary>
        /// <returns>ページ離脱時の警告が有効かどうか</returns>
        public static bool IsEnabledBeforeUnloadEvent()
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            return isEnabledBeforeUnloadEvent();
#else
            return false;
#endif
        }
        /// <summary>
        /// ページをリロードする
        /// </summary>
        public static void Reload()
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            reload();
#else
            Application.Quit();
#endif
        }
    }
}