# Company.ProjectName
C# 项目模板  

安装模板
```
dotnet new install .\
```
卸载模板
```
dotnet new uninstall .\
```
根据模板创建项目
```
mkdir BD.ProjectName
cd BD.ProjectName
dotnet new bdcsproj
mkdir ref
cd ref
git submodule add https://github.com/BeyondDimension/DirectoryPackages.git
```

### 📁 项目文件夹结构
- ```pkg``` Release 配置下生成编译的 nuget 包存放目录
- ```ref``` 子模块引用其他仓库目录，在解决方案中的 ```1.Reference``` 文件夹下
- ```src``` 源码目录

### 🏗️ 解决方案结构
- 0.Root **项目根文件夹**
    - Source 共享源码
        - ImplicitUsings **全局命名空间引用**
        - AssemblyInfo.cs **程序集信息**
        - Utils.cs **项目工具类**
    - TFM **.NET 目标框架**
    - .editorconfig **代码样式配置**
    - .gitignore **Git 忽略扩展名与路径配置**
    - .gitmodules **Git 子模块配置**
    - Directory.Build.props **csproj 全局项目共享配置**
    - Directory.Packages.props **NuGet 中央包管理**
    - GeneratePackage.props **NuGet 发行包信息**
    - nuget.config **NuGet 包源配置**
- 1.Reference **引用子模块依赖项目**
- Company.ProjectName **库**
    - Constants 静态类常量
    - Extensions 扩展函数
    - Helpers 静态助手类
    - Services 服务接口
    - Services.Implementation 服务接口实现
- Company.ProjectName.Primitives **基本库**
    - Columns 列接口
    - Enums 枚举
    - Extensions 扩展函数
- Company.ProjectName.Primitives.Models **模型库**
    - Abstractions 模型抽象接口，抽象类
    - 模型类
- Company.ProjectName.Primitives.Resources **资源库**
- Company.ProjectName.Primitives.ViewModels **视图模型库**
    - Compile Link 模型库，通过 ```#if MVVM_VM``` 加上 ReactiveUI 内容，例如属性通知等
- Company.ProjectName.UnitTest **单元测试**
    - XXXXUnitTest.cs 对某个功能进行测试

### ⚠ 注意事项
1. ```ServiceCollectionExtensions.*.cs``` **DI 注册服务扩展类，命名空间统一使用**  
<pre>
// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;
</pre>
2. ```Extensions``` **扩展函数，命名空间使用** 
<pre>
// ReSharper disable once CheckNamespace
namespace Company.ProjectName;
</pre>