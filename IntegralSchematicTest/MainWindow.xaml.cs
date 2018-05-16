using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace IntegralSchematicTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int funcCount;
        TextBox[] funcTbs;
        TextBox[] funcNamesTbs;
        DataTable dataTbl;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                funcCount = Convert.ToInt32(FuncCountTb.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            showInputs();
        }

        void showInputs()
        {
            funcNamesTbs = new TextBox[funcCount];
            funcTbs = new TextBox[funcCount];


            RowDefinition firstRow = new RowDefinition();
            functionToInputControl.InputGrid.RowDefinitions.Add(firstRow);

            for (int i = 0; i < funcCount; i++)
            {
                RowDefinition rd = new RowDefinition();
                functionToInputControl.InputGrid.RowDefinitions.Add(rd);

                //-----------------------------------------------------------------------

                Label lb = new Label();
                lb.Content = i;
                Grid.SetRow(lb, i + 1);
                Grid.SetColumn(lb, 0);
                functionToInputControl.InputGrid.Children.Add(lb);

                //------------------------------------------------------------

                funcTbs[i] = new TextBox();
                funcTbs[i].Margin = new Thickness(5);


                Grid.SetRow(funcTbs[i], i + 1);
                Grid.SetColumn(funcTbs[i], 2);

                functionToInputControl.InputGrid.Children.Add(funcTbs[i]);

                //---------------------------
                funcNamesTbs[i] = new TextBox();
                funcNamesTbs[i].Margin = new Thickness(5);
                // funcNamesTbs[i].Width = 50;

                Grid.SetRow(funcNamesTbs[i], i + 1);
                Grid.SetColumn(funcNamesTbs[i], 1);

                functionToInputControl.InputGrid.Children.Add(funcNamesTbs[i]);
                //--------------------------------------

            }

            functionToInputControl.calculateBtn.Visibility = Visibility.Visible;
            functionToInputControl.calculateBtn.Click += Calculate_Button_Click;

        }

        
        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            dataTbl = new DataTable("emp");
            for (int i = 0; i < funcCount; i++)
            {
                DataColumn dc = new DataColumn(funcNamesTbs[i].Text, typeof(int));
                dataTbl.Columns.Add(dc);
                

                DataRow dr;
                dr = dataTbl.NewRow();
                // dataTbl.Rows.Remove(dr);
                dr[i] = i;
                dataTbl.Rows.Add(dr);
                
            }
            functionToShowControl.dataGrid1.ItemsSource = dataTbl.DefaultView;

            MessageBox.Show("Calculate was Finsihed");
        }

    }
}
