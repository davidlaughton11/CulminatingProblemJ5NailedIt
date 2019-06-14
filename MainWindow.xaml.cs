/*David Laughton
 * June 10th 2019
 * J5 for 2017
 */

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

namespace CulminatingProblemJ5NailedIt_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List of the two piece fences
        List<int> listOfInts = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, RoutedEventArgs e)
        {
            string lInput = LInput.Text;
            int N;
            int.TryParse(NInput.Text, out N);
            int[] L;
            string[] splitN = lInput.Split(null);
            L = Array.ConvertAll(splitN, int.Parse);
            int lengthOfFences = 1;
            int howManyFences = 1;
            
            //for the array if there are same lengths in the list add the length of fence
            for (int i = 1; i < N; i ++)
            {
                int Num = L[i] + L[0];
                listOfInts.Add(Num); 
                foreach (int Integer in L)
                {
                    if (Num == Integer)
                    {
                        lengthOfFences++;
                    }
                }                
            }
            
            //If length of fences is one
            if (lengthOfFences == 1)
            {
                howManyFences = N * 2;
                lengthOfFences++;
            }
            
            lblOutput.Content = lengthOfFences - 1 + " "+ howManyFences;
        }
    }
}
