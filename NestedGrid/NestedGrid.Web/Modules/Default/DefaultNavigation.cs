using Serenity.Navigation;
using MyPages = NestedGrid.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Default/Child A", typeof(MyPages.ChildAController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Child B", typeof(MyPages.ChildBController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Main", typeof(MyPages.MainController), icon: null)]