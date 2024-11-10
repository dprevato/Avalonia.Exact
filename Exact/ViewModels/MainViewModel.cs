using MvvmGen;

namespace Exact.ViewModels;

[ViewModel]
public partial class MainViewModel
{
    #region Properties
    [Property] private string? _greeting = "Welcome to Avalonia!";
    #endregion Properties

    #region Commands
    // Comandi menu Operazioni
    [Command] public void AutoImport() { }
    [Command] public void ImportFromFile() { }
    [Command] public void ExportData() { }
    [Command] public void ValidateReadings() { }
    [Command] public void ChartSetup() { }
    [Command] public void ChartShow() { }
    [Command] public void TabReport() { }
    [Command] public void ChartReport() { }
    [Command] public void ApplicationExit() { }

    // Comandi menu Tabelle
    [Command] public void EditMap() { }
    [Command] public void EditPlants() { }
    [Command] public void EditJournal() { }
    [Command] public void EditGauges() { }
    [Command] public void EditReadings() { }
    [Command] public void EditEmployees() { }
    #endregion Commands
}
