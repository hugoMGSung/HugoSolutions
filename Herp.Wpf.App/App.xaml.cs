using System.IO;
using System.Windows;
using Herp.Wpf.App.Helpers;
using Newtonsoft.Json.Linq;

namespace Herp.Wpf.App
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            JObject obj = JObject.Parse(File.ReadAllText(@"config.json"));
            Commons.ConnString = $"Data Source={obj["sqlserver"]["host"]};" +
                                 $"Initial Catalog={obj["sqlserver"]["database"]};" +
                                 "Persist Security Info=True;" +
                                 $"User ID={obj["sqlserver"]["userid"]};" +
                                 $"Password={obj["sqlserver"]["password"]}";

            Commons.RegUserId = obj["userconfig"]["userid"].ToString();
            Commons.Version = obj["version"].ToString();
            Commons.Domain = obj["domain"].ToString();

            base.OnStartup(e);
        }
    }
}
