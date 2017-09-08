using System.Windows;

namespace CpuPowerLimiter
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private NotifyIconWrapper _notifyIcon;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ShutdownMode = ShutdownMode.OnExplicitShutdown;
            _notifyIcon = new NotifyIconWrapper();
        }
        protected override void OnExit(ExitEventArgs e)
        {
            //アプリケーション終了時にデフォルト設定に戻す。
            Model.Instance.SetSettings(100,2);

            base.OnExit(e);
            _notifyIcon.Dispose();
        }
    }
}