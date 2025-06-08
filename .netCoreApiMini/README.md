## 架构

### API

### Model
* 对于模型的定义

### Common
* 通用方法

### Repository
* 只控制对数据库进行操作

### Service
* 获取数据，从 Repository 获取数据，并做处理

通用范型服务层
通过 Model 转换成 VO，剔除不需要返回的数据


### 添加引用
一个解决方案下面多个项目，
当前项目引用其他项目
<code>.csproj</code>文件中添加<code>ItemGroup</code>
   
> <code>dotnet add reference ../MyApp.Domain/MyApp.Domain.csproj</code>

```c#
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <RootNamespace>_netCoreApiMini.Model</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\.netCoreApiMini.Common\.netCoreApiMini.Common.csproj" />
  </ItemGroup>

</Project>

```