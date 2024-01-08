using SingletonPattern;
using System;



Thread t1 = new Thread(() =>
{
    var instace = UploadService.Instance(1);
});

Thread t2 = new Thread(() =>
{
    var instace = UploadService.Instance(2);
});
t1.Start();
t2.Start();

t1.Join();
t2.Join();