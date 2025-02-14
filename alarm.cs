using System;
using System.Timers;

class Program
{
    private static Timer timer;
    private static DateTime alarmTime = DateTime.Now.AddSeconds(10); // 10秒後にアラーム

    static void Main()
    {
        timer = new Timer(1000); // 1秒ごとにチェック
        timer.Elapsed += CheckAlarm;
        timer.Start();

        Console.WriteLine("アラームをセットしました。Enterキーで終了します。");
        Console.ReadLine();
    }

    private static void CheckAlarm(object sender, ElapsedEventArgs e)
    {
        if (DateTime.Now >= alarmTime)
        {
            timer.Stop();
            Console.WriteLine("アラーム！ 時間になりました！");
        }
    }
}
