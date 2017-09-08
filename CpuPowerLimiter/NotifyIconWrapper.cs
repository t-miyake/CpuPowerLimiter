using System.ComponentModel;
using System.Windows;

namespace CpuPowerLimiter
{
    public partial class NotifyIconWrapper : Component
    {
        private Model Model = Model.Instance;

        public NotifyIconWrapper()
        {
            InitializeComponent();

            //Defaultは常に100%
            toolStripMenuItem_Set100.Checked = true;

            toolStripMenuItem_Set100.Click += (sender, args) =>
            {
                Model.SetSettings(100, 2);
                ResetCheck();
                toolStripMenuItem_Set100.Checked = true;
            };

            toolStripMenuItem_Set90.Click += (sender, args) =>
            {
                Model.SetSettings(90, 0);
                ResetCheck();
                toolStripMenuItem_Set90.Checked = true;
            };

            toolStripMenuItem_Set80.Click += (sender, args) =>
            {
                Model.SetSettings(80, 0);
                ResetCheck();
                toolStripMenuItem_Set80.Checked = true;
            };

            toolStripMenuItem_Set70.Click += (sender, args) =>
            {
                Model.SetSettings(70, 0);
                ResetCheck();
                toolStripMenuItem_Set70.Checked = true;
            };

            toolStripMenuItem_Set60.Click += (sender, args) =>
            {
                Model.SetSettings(60, 0);
                ResetCheck();
                toolStripMenuItem_Set60.Checked = true;
            };

            toolStripMenuItem_Set50.Click += (sender, args) =>
            {
                Model.SetSettings(50, 0);
                ResetCheck();
                toolStripMenuItem_Set50.Checked = true;
            };

            toolStripMenuItem_Exit.Click += (sender, args) => Application.Current.Shutdown();
        }

        private void ResetCheck()
        {
            toolStripMenuItem_Set100.Checked = false;
            toolStripMenuItem_Set90.Checked = false;
            toolStripMenuItem_Set80.Checked = false;
            toolStripMenuItem_Set70.Checked = false;
            toolStripMenuItem_Set60.Checked = false;
            toolStripMenuItem_Set50.Checked = false;
        }

        public NotifyIconWrapper(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}