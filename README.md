# WebGLReloaderForUnity
UnityのWebGLビルドでページ再読み込みやアラートの設定を行うためのプラグイン

## Example

![](https://github.com/nkjzm/WebGLReloaderForUnity/blob/master/Docs/Example.gif)

## Usage

```.cs
// ページ離脱時の警告を有効にする
nkjzm.WebGLHandler.EnableBeforeUnloadEvent();
nkjzm.WebGLHandler.EnableBeforeUnloadEvent("離脱時のメッセージ");

// ページ離脱時の警告を無効にする
nkjzm.WebGLHandler.DisableBeforeUnloadEvent();

// ページ離脱時の警告が有効かどうかを返す
nkjzm.WebGLHandler.IsEnabledBeforeUnloadEvent();

// ページ再読み込み
nkjzm.WebGLHandler.Reload();
```

## License

[MIT](https://github.com/nkjzm/WebGLReloaderForUnity/blob/master/LICENSE)
