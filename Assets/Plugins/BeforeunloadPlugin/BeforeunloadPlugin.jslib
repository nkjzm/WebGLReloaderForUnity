var BeforeunloadPlugin = {
  $funcs: {},
  enableBeforeUnloadEvent: function () {
    enableBeforeUnloadEvent("Do you want to leave this page?");
  },
  enableBeforeUnloadEvent: function (message) {
    window.onbeforeunload = function (e) {
      e.returnValue = message;
      return message;
    }
  },
  disableBeforeUnloadEvent: function () {
    window.onbeforeunload = null;
  },
  isEnabledBeforeUnloadEvent: function () {
    return window.onbeforeunload != null;
  },
  reload: function () {
    location.reload();
  },
}
autoAddDeps(BeforeunloadPlugin, '$funcs');
mergeInto(LibraryManager.library, BeforeunloadPlugin);
