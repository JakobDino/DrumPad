using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Media;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinRT;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DrumPad
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        AppWindow m_appWindow;

        private AppWindow GetAppWindowForCurrentWindow()
        {
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WindowId myWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(myWndId);
        }

        private void SwitchPresenter_CompOverlay(object sender, RoutedEventArgs e)
        {
            m_appWindow.SetPresenter(AppWindowPresenterKind.CompactOverlay); 
        }

        private void SwitchPresenter_OverLapped(object sender, RoutedEventArgs e)
        {
            m_appWindow.SetPresenter(AppWindowPresenterKind.Overlapped);
        }

        private void SwitchPresenter_Fullscreen(object sender, RoutedEventArgs e)
        {
            m_appWindow.SetPresenter(AppWindowPresenterKind.FullScreen);
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch.IsOn)
            {
                ((FrameworkElement)this.Content).RequestedTheme = ElementTheme.Dark;
            }
            else
            {
                ((FrameworkElement)this.Content).RequestedTheme = ElementTheme.Light;
            }
        }
        private void pad_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_rim.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad2_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_crash.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad3_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_elec1.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad4_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_high_snare.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad5_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_high_snare2.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad6_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_kick.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad7_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_snare.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad8_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_tom.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad9_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_trash.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad10_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_clip1.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad11_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_clip2.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad12_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_clip3.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad13_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_clip4.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad14_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_clip5.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad15_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_clip6.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad16_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "assets", "DrumPad_DrumPad_Assets_clip7.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        public MainWindow()
        {
            this.InitializeComponent();
            ((FrameworkElement)this.Content).RequestedTheme = ElementTheme.Light;
            m_appWindow = GetAppWindowForCurrentWindow();
            
        }

    }
}
