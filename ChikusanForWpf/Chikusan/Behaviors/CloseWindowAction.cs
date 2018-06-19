using System.Windows;
using System.Windows.Interactivity;

namespace JaGunma.Chikusan.Behavior
{
    public class CloseWindowAction : TriggerAction<DependencyObject>
    {
        protected override void Invoke(object parameter)
        {
            Window.GetWindow(this.AssociatedObject)?.Close();
        }
    }
}
