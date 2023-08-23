using System;
using poc_maui.Models;
using System.Collections.ObjectModel;
using poc_maui.Views;
using System.Windows.Input;

namespace poc_maui.ViewModels
{
    public class BugPageViewModel : BaseViewModel
    {
        public ICommand ClickCommand { get { return new Command(ClickMethod); } }

        private async void ClickMethod()
        {
            await Shell.Current.GoToAsync(nameof(BugPage));
        }

        public bool IsNextEnabled
        {
            get { return _isNextEnabled; }
            set { _isNextEnabled = value; OnPropertyChanged(nameof(IsNextEnabled)); }
        }
        private bool _isNextEnabled;

        public BugPageViewModel()
        {
            LoadData();
        }

        public ObservableCollection<CodesModel> CodesList
        {
            get { return _codeList; }
            set { _codeList = value; OnPropertyChanged(nameof(CodesList)); }
        }
        private ObservableCollection<CodesModel> _codeList;

        private void LoadData()
        {
            var codeNumber = Guid.NewGuid().ToString();

            CodesList = new ObservableCollection<CodesModel>()
            {
                new CodesModel
                {
                   CodeNumber = "228.75(d)(3)",
                   CodeText = "A Time/Temperature controlled for Safety Food (TCS) received in compliance with laws allowing a temperature above 5 degrees Celsius (41 degrees Fahrenheit) during shipment from the supplier as specified in section §228.63(a)(2) of this title, shall be cooled within four hours to 5 degrees Celsius (41 degrees Fahrenheit) or less"
                },
                new CodesModel
                {
                   CodeNumber = "228.75(d)(2)",
                   CodeText = "Time/Temperature controlled for Safety Food (TCS) shall be cooled within four hours to 5 degrees Celsius (41 degrees Fahrenheit) or less, if prepared from ingredients at ambient temperature, such as reconstituted foods and canned tuna"
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Raw animal foods that are cooked using non-continuous cooking process shall be immediately after initial heating, cooled as specified in §228.75(d) of this title"
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Cook-Chill or Sous Vide. Except as specified under paragraphs (3) and (6) of this subsection, a establishment that packages Time/Temperature controlled for Safety Food (TCS) using cook-chill or sous vide process shall ensure the food is: cooled to 5 degrees Celsius (41 degrees Fahrenheit) in the sealed package or bag as specified under §228.75(d)"
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Food shall be protected from cross contamination by, except when combined as ingredients, separating types of raw animal foods from each other such as beef, fish, lamb, pork, and poultry during storage, preparation, holding, and display by using separate equipment for each type"
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Raw shell eggs shall be received as specified under section §228.63(a)(3) of this title and immediately placed in refrigerated equipment that maintains an ambient air temperature of 7 degrees Celsius (45 degrees Fahrenheit) or less"
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Cooked Time/Temperature controlled for Safety Food (TCS) shall be cooled within a total of six hours, from 57 degrees Celsius (135 degrees Fahrenheit) to 5 degrees Celsius (41 degrees Fahrenheit) or less"
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Cooked Time/Temperature controlled for Safety Food (TCS) shall be cooled within two hours, from 57 degrees Celsius (135 degrees Fahrenheit) to 21 degrees C (70 degrees Fahrenheit)"
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test asjdl alkdj lakdjsuioiaosdhaisodh ohsd iohasodiasoidha ofh aoishd oiashd oiashd ioasdhaoishd,Test asjdl alkdj lakdjsuioiaosdhaisodh ohsd iohasodiasoidha ofh aoishd oiashd oiashd ioasdhaoishd"
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },
                new CodesModel
                {
                   CodeNumber = codeNumber,
                   CodeText = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test "
                },

            };
        }

        public void HandleViolationCodeSelection()
        {
            //TODO: add logic to store selected ids
            if (CodesList.Where(x => x.IsSelected).Count() > 0)
            {
                IsNextEnabled = true;
            }
            else
            {
                IsNextEnabled = false;
            }
        }
    }
}

