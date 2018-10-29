# windows.Browers
Windows 平台下，C# 内嵌网页的 demo，包括当前流行的 CEF  、FireFox、Miniblink

  CEF  与 FireFox 都可以在  nuget 下安装 
1.Cef 安装 直接 搜索 cef 即可 
  winform 选 cefsharp.winform; wpf 选 cefsharp.wpf ,  其它的相应依赖都会安装上的，不用自己单独安装  ；
  要注意的是  cef 的项目需要制定 x64 或 x86  不能使用 anyCPU；
  - Minimum of .Net 4.5.2
  - Make sure `VC++ 2015 Redist` is installed (either `x86` or `x64` depending on your application)
  更多详情 请至官网 查看
  
  官网Demo https://github.com/cefsharp
  建议 C#开发者使用 这个项目（完整的项目需要你的电脑安装很多的C++依赖） https://github.com/cefsharp/CefSharp.MinimalExample
  
 2.firefox 的内核 使用的是  Geckofx
   安装的时候请在 nuget 中 搜索 Geckofx 而不是 firefox ，ok?
   firefox 不用制定 平台目标 anyCpu 即可
   安装完成后 ，你的项目中会多一个文件夹 Firefox， 这个文件夹开发者处理，
   在 程序入口 初始化 项目   Xpcom.Initialize("Firefox");
      /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Xpcom.Initialize("Firefox");
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
  
 3.Miniblink
 官网 https://weolar.github.io/miniblink/index.html
 相比上面两个项目，这个最大的优点就是 小 ！！！  上面两项目起步大小就是一百多兆，还没开始写代码，项目就那么大了！！内心千万个拒绝
 C# demo    
      1. https://github.com/E024/MiniBlinkPinvoke   
      2.https://github.com/E024/MiniBlinkPinvokeDemo
      
      两个项目都要下载 才是一个C# 的完整项目， 项目二要应用项目一；当年应用完成之后 ，生成项目 并 运行 ，这时候会提示你 确实 node.dll 文件 ；
      这个node.dll 文件并不是 随便下一个就可以了;官网有解释
      ==============官方发言===============
      Miniblink只有一个dll：node.dll。很多人问这不是nodejs的dll吗，是的，因为miniblink有electron模式，所以需要伪装成nodejs的dll
      ==============官方发言结束===============
      
      这个node.dll 我有放在项目中，大家可以下载使用，也可以去官网下载最新的
      
      
 关于C# winform或 wpf 内嵌浏览器  ，在目前的形式下，需求还是有的；我也是在各个项目间徘徊了很久才弄清楚的；
 关于这三个项目之间的优劣 大家仁者见仁 智者见智；只有适合自己的才是最好的，
 
 
 
 小计：
   本人最开始使用的是CEF，一切的进展都很顺利，C# 与 JS 间的调用也没有问题；在PC与 平板上操作也OK；
   但是 因为本人的项目是校园项目，会运行在教室的 触摸屏一体机上， 程序时发现 CEF 无法识别 该一体机的触摸操作，
   然而平板却运行正常，最后没有办法，只能切换内核 为 Firefox， 那时还没有接触到 miniblink ，后来项目完成后，也懒得换了；
   
 
      
      
      
 
