using Singleton7Demo;

Parallel.Invoke(() =>
{
    var lz1 = LazySingleton.GetInstance;
    lz1.DisplayMsg("Lazy Singleton");
}, () =>
{
    var lz2 = LazySingleton.GetInstance;
    lz2.DisplayMsg("Lazy Singleton");
}, () =>
{
    var lz3 = LazySingleton.GetInstance;
    lz3.DisplayMsg("Lazy Singleton");

});