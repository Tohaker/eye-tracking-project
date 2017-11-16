using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tobii.Interaction;
using Tobii.Interaction.Framework;

namespace LED_Blink
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Declarations
        private static FixationDataStream fixationDataStream;
        private static DateTime fixationBeginTime = default(DateTime);
        #endregion


        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitTobiiStreams()
        {
            
        }

        private static void CreateAndVisualizeSlowFilteredFixationsStream()
        {
            if (fixationDataStream != null)
                fixationDataStream.Next -= OnNextFixation;
            fixationDataStream = _host.Streams.CreateFixationDataStream(FixationDataMode.Slow);
            fixationDataStream.Next += OnNextFixation;
        }

        private static void OnNextFixation(object sender, StreamData<FixationData> fixation)
        {
            switch (fixation.Data.EventType)
            {
                case FixationDataEventType.Begin:
                    Console.WriteLine("\n" +
                                      "Fixation started at X: {0}, Y: {1}", fixation.Data.X, fixation.Data.Y);
                    _fixationBeginTimestamp = fixation.Data.Timestamp;
                    break;

                case FixationDataEventType.Data:
                    Console.WriteLine("During fixation, currently at: X: {0}, Y: {1}", fixation.Data.X, fixation.Data.Y);
                    break;

                case FixationDataEventType.End:
                    Console.WriteLine("Fixation ended at X: {0}, Y: {1}", fixation.Data.X, fixation.Data.Y);
                    if (!Double.IsNaN(_fixationBeginTimestamp))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Fixation duration: {0}", TimeSpan.FromMilliseconds(fixation.Data.Timestamp - _fixationBeginTimestamp));
                        Console.ForegroundColor = _defaultForegroundColor;
                    }
                    break;
            }
        }
    }
}
