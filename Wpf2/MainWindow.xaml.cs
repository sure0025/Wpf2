using System;
using System.Windows;


/*
    Exercise 02 

    Use the zip file wpf02 and finish the solution. And make it work.
The GUI must only use the controller
The propperties have the data to be shown on the gui
The methods
addPerson maks a new person objekt and maket it the new curentperson and chance the count and index
deleteperson remover curent person and chance the count and index
nextperson and prevperson chance curentperson

     */
namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controler controler;
        public MainWindow()
        {
           
            controler = Controler.GetInstance();
            InitializeComponent();
            Clear(); 
        }

     
        private void Clear()
        {
            FirstNameTXT.Clear();
            LastNameTXT.Clear();
            AgeTXT.Clear();
            TelephoneNrTXT.Clear();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {

          
                
            controler.AddPerson(FirstNameTXT.Text, LastNameTXT.Text, Convert.ToInt32(AgeTXT.Text), TelephoneNrTXT.Text);

            PersonCountNr.Content = controler.PerconCount;
            IndexNr.Content = controler.PersonIndex; 

            
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            controler.DeletePerson();

            PersonCountNr.Content = controler.PerconCount;
            IndexNr.Content = controler.PersonIndex;

        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            controler.NextPerson();
           

            FirstNameTXT.Text = controler.CurentPerson.FirstName;
            LastNameTXT.Text = controler.CurentPerson.LastName;
            AgeTXT.Text = controler.CurentPerson.Age.ToString();
            TelephoneNrTXT.Text = controler.CurentPerson.TelephoneNr;


            PersonCountNr.Content = controler.PerconCount;
            IndexNr.Content = controler.PersonIndex;


        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            controler.NextPerson();

            FirstNameTXT.Text = controler.CurentPerson.FirstName;
            LastNameTXT.Text = controler.CurentPerson.LastName;
            AgeTXT.Text = controler.CurentPerson.Age.ToString();
            TelephoneNrTXT.Text = controler.CurentPerson.TelephoneNr;


            PersonCountNr.Content = controler.PerconCount;
            IndexNr.Content = controler.PersonIndex;

        }

       
    }
}
