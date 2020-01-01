using UnityEngine;
using UnityEngine.UI;

namespace nkjzm.Example
{
    public class Example : MonoBehaviour
    {
        [SerializeField] Button SwitchButton = null;
        [SerializeField] Text StatusText = null;
        [SerializeField] Button Reload = null;

        void Start()
        {
            UpdateStatus();

            SwitchButton.onClick.AddListener(() =>
            {
                if (WebGLHandler.IsEnabledBeforeUnloadEvent())
                {
                    // 無効化
                    WebGLHandler.DisableBeforeUnloadEvent();
                }
                else
                {
                    // 有効化
                    WebGLHandler.EnableBeforeUnloadEvent();
                }
                UpdateStatus();
            });

            // ページ再読み込み
            Reload.onClick.AddListener(WebGLHandler.Reload);
        }
        void UpdateStatus()
        {
            var status = WebGLHandler.IsEnabledBeforeUnloadEvent() ? "Enable" : "Disable";
            StatusText.text = $"BeforeUnloadEvent: {status}";
        }
    }
}
