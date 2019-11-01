# オブジェクト指向 プログラミングの基礎

## クラス

### クラスを定義する

``` C#
// Productクラス
public class Product {
    // 商品コード
    public int Code {get; set;}

    public string Name{get; set;}

    public int Price{get; set;}

    public int GetTax() {
        return (int)(Price * 0.08);
    }

    public int GetPriceIncludingTax() {
        return Price * GetTax();
    }

    // コンストラクタ
    public Product(int code, string name, int price) {
        this.Code = code;
        this.Name = name;
        this.Price = price;
    }
}
```

### クラスのインスタンスを生成する

``` C#
    Product karinto = new Product(123, "かりんとう", 180);
```

#### かりんとうオブジェクトのイメージ

```
 変数 karinto                     100番地
 ----------            --------------------------
 | 100番地 |    ===>   |  商品番号：123           |
 ----------            |   商品名： "かりんとう"  |
                       |    商品価格： 180       |
                       --------------------------
```

### オブジェクトを利用する

```C#
    int price = karinto.Price;
    int taxIncluded = karinto.GetPriceIncludingTax();
```

### インスタンスは複数作れる

```C#
    Product karinto = new Product(123, "かりんとう", 180);
    Product daifuku = new Product(235, "大福もち", 160);
```

## 構造体

```C#
    DateTime date = new DateTime(2015, 7, 29);
```

### クラスと構造体

```C#
    // クラス
    class MyClass {
        public int X{get; set;}
        public int Y{get; set;}
    }

    // 構造体
    struct MyStruct {
        public int X{get; set;}
        public int Y{get; set;}
    }

    MyClass myClass = new MyClass {X = 1, Y = 2};
    MyStruct myStruct = new MyStruct {X = 1, Y = 2};
```

#### クラスと構造体の違い

```
 変数 myClass             100番地
 ----------           -----------
 | 100番地 |   ===>   |  X：1   |
 ----------           |  Y：2  |
                      ----------

 変数 myStruct
 ----------
 |  X：1  |
 |  Y：2  |
 ----------
```

* クラス：ヒープ領域
* 構造体：スタック領域

## 値型と参照型

* 型は値型か参照型に分類される。
* 構造体は値型。クラスは参照型
* 構造体は継承できない

## 値型の動き

```C#
struct MyPoint {
    public int X { get; set; }
    public int Y { get; set; }

    public MyPoint(int x, int y) {
        this.X = x;
        this.Y = y;
    }
}

```


