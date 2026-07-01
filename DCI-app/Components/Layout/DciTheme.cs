using MudBlazor;
namespace DCI_app.Components.Layout
{
    public static class DciTheme
    {
        public static MudTheme Theme = new()
        {
            PaletteLight = new PaletteLight
            {
                Primary = "#1565C0",      
                Secondary = "#2E7D32",    
                Background = "#F5F7FA",
                Surface = "#FFFFFF",
                AppbarBackground = "#1565C0",
                DrawerBackground = "#FFFFFF",
                DrawerText = "#1E293B",
                TextPrimary = "#1E293B"
            }
        };
    }
}
