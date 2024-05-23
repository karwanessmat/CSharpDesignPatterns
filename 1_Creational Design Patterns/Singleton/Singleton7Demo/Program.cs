using Singleton7Demo;

Parallel.Invoke(() =>
{
    LazySingleton? lz1 = LazySingleton.GetInstance;
    lz1.DisplayMsg("Lazy Singleton");
}, () =>
{
    LazySingleton? lz2 = LazySingleton.GetInstance;
    lz2.DisplayMsg("Lazy Singleton");
}, () =>
{
    LazySingleton? lz3 = LazySingleton.GetInstance;
    lz3.DisplayMsg("Lazy Singleton");

});