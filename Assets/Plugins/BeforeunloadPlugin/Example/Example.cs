using UnityEngine;
using UnityEngine.UI;

namespace nkjzm.Example
{
    public class Example : MonoBehaviour
    {
        [SerializeField] Button EnableButton = null, DisableButton = null;
        [SerializeField] Text StatusText = null;
        [SerializeField] Button Reload = null;

        void Start()
        {
            UpdateStatus();

            // BeforeUnloadの有効化
            EnableButton.onClick.AddListener(() =>
            {
                WebGLHandler.EnableBeforeUnloadEvent();
                UpdateStatus();
            });

            // BeforeUnloadの無効化
            DisableButton.onClick.AddListener(() =>
            {
                WebGLHandler.DisableBeforeUnloadEvent();
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
