using System;

public class Singleton {

    private static Singleton singleton;

    //コンストラクタ
    public Singleton() {
        Console.WriteLine("インスタンスを生成しました。");
    }

    public static Singleton getInstancne() {
        if (singleton == null) {
            singleton = new Singleton();
        }
        return singleton;
    }

}
