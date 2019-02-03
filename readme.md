# No Slang
## 概要
把垃圾話轉成人類能懂的話
例如把 [**ji3rm,62k71j4vu/6**]<br>
轉換成 [*ㄨㄛˇㄐㄩㄝˊㄉㄜ˙ㄅㄨˋㄒㄧㄥˊ*]

## 使用方式
```csharp
var data = "ji3rm,62k71j4vu/6"; // 我覺得不行
var processor = new Bopomofo();

// output: ㄨㄛˇㄐㄩㄝˊㄉㄜ˙ㄅㄨˋㄒㄧㄥˊ
var result = Parser.From(data, processor).Value;
```